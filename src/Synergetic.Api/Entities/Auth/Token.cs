namespace Synergetic.Api.Entities.Auth
{
    using System.Text.Json.Serialization;

    internal class Token
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonPropertyName(".issued")]
        public string Issued { get; set; }

        [JsonPropertyName(".expires")]
        public string Expires { get; set; }
    }
}