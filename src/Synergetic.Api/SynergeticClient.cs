namespace Synergetic.Api
{
    using Synergetic.Api.Common;
    using Synergetic.Api.Entities.Auth;
    using Synergetic.Api.Entities.Common;
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    public static class SynergeticClient
    {
        internal static HttpClient ApiClient;
        internal static HttpClient TokenClient;
        internal static Token AuthToken { get; set; }
        internal static string ApiVersion { get; set; }
        internal static string ClientVersion { get; set; }

        internal static JsonSerializerOptions JsonSerialiserOptions = new JsonSerializerOptions
        {
            IgnoreNullValues = true,
            WriteIndented = true,
        };

        /// <summary>Initialises a new Synergetic Client and requests an authentication token.</summary>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="clientSecret">The client secret.</param>
        /// <param name="url">The URL.</param>
        /// <param name="version">The API version to use (optional).</param>
        /// <exception cref="Synergetic.Api.SynergeticApiException">
        /// Client ID cannot be a blank GUID
        /// or
        /// clientSecret is required
        /// or
        /// url is required
        /// or
        /// Version number cannot be less than 1
        /// or
        /// url must use HTTPS scheme
        /// </exception>
        public static async Task Initialise(Guid clientId, string clientSecret, string url, int version = 1)
        {
            if (clientId == Guid.Empty)
                throw new SynergeticApiException("Client ID cannot be a blank GUID");

            if (string.IsNullOrEmpty(clientSecret))
            {
                throw new SynergeticApiException("clientSecret is required");
            }

            if (string.IsNullOrEmpty(url))
            {
                throw new SynergeticApiException("url is required");
            }

            if (version < 1)
            {
                throw new SynergeticApiException("Version number cannot be less than 1");
            }

            ApiVersion = $"v{version}";
            ClientVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            await AquireToken(clientId, clientSecret, url);
            ApiClient = new HttpClient();

            if (!url.EndsWith("/")) //Base uri must end with a trailing /
                url = url + "/";

            url = url + "api/";

            var baseUri = new Uri(url);
            if (baseUri.Scheme != "https")
            {
                throw new SynergeticApiException("url must use HTTPS scheme");
            }
            ApiClient.BaseAddress = baseUri;
            ApiClient.DefaultRequestHeaders.Add("ContentType", "application/json");

            ApiClient.DefaultRequestHeaders.Add("User-Agent", $"{Constants.UAString} {ClientVersion}");

            var authorisationHeader = $"Bearer {AuthToken.AccessToken}";
            ApiClient.DefaultRequestHeaders.Add("Authorization", authorisationHeader);
        }

        private static async Task AquireToken(Guid clientId, string clientSecret, string url)
        {
            TokenClient = new HttpClient(); //Keep this for when we need to reaquire expired tokens
                                            //has to be different from main Api client as the token endpoint behaves differently to every other endpoint

            if (!url.EndsWith("/")) //Base uri must end with a trailing '/'
                url = url + "/";

            var baseUri = new Uri(url);
            if (baseUri.Scheme != "https") //perform HTTPS check
            {
                throw new SynergeticApiException("url must be https");
            }
            TokenClient.BaseAddress = baseUri;
            TokenClient.DefaultRequestHeaders.Add("ContentType", "application/x-www-form-urlencoded");
            TokenClient.DefaultRequestHeaders.Add("User-Agent", $"{Constants.UAString} {ClientVersion}");

            //Get Auth Token
            var requestUrl = $"token";
            var authRequestContent = new StringContent(
                       $"grant_type=client_credentials&client_id={clientId}&client_secret={clientSecret}",
                       Encoding.UTF8);

            var response = await TokenClient.PostAsync(requestUrl, authRequestContent);

            using (var responseStream = await response.Content.ReadAsStreamAsync())
            {
                if (response.IsSuccessStatusCode)
                {
                    AuthToken = await JsonSerializer.DeserializeAsync<Token>(responseStream, JsonSerialiserOptions);
                }
                else
                {
                    var error = await JsonSerializer.DeserializeAsync<Error>(responseStream, JsonSerialiserOptions);
                    throw new SynergeticApiException(error.Message ?? "An unknown error occured");
                }
            }
        }
    }
}