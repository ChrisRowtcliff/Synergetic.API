namespace Synergetic.Api.Entities.Auth
{
    using Synergetic.Api.Json.Serialisers;
    using System;
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
        [JsonConverter(typeof(TokenDateTimeConverter))]
        public DateTime Issued { get; set; }
        
        [JsonPropertyName(".expires")]
        [JsonConverter(typeof(TokenDateTimeConverter))]
        public DateTime Expires { get; set; }

     
    }
}