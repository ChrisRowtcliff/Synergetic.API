namespace Synergetic.Api.Common
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.Text.Json.Serialization;

    internal static class Helpers
    {
        public static string ObjectToQueryString<T>(T requestEntity)
        {
            var type = typeof(T);

            var parameters = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(prop => !Attribute.IsDefined(prop, typeof(JsonIgnoreAttribute)))
                .Select(p => $"{WebUtility.UrlEncode(p.Name)}={WebUtility.UrlEncode(Convert.ToString(p.GetValue(requestEntity)))}");

            return string.Join('&', parameters);
        }
    }
}