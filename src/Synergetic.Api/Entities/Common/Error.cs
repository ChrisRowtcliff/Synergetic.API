namespace Synergetic.Api.Entities.Common
{
    using System.Text.Json.Serialization;

    internal class Error
    {
        [JsonPropertyName("Message")]
        public string Message { get; set; }
    }
}