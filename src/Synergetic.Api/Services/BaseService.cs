namespace Synergetic.Api.Services
{
    using Synergetic.Api.Common;
    using Synergetic.Api.Entities.Common;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    public abstract class BaseApiService
    {
        internal async Task<U> Execute<T, U>(HttpMethod method, string url, T data = null)
          where T : class, new()
          where U : class, new()
        {
            return await this.ExecuteRequest<T, U>(method, url, data);
        }

        internal async Task<T> Execute<T>(HttpMethod method, string url)
            where T : class, new()
        {
            return await this.ExecuteRequest<object, T>(method, url, null);
        }

        private async Task<U> ExecuteRequest<T, U>(HttpMethod method, string url, T data = null)
          where T : class, new()
          where U : class, new()
        {
            var requestUrl = $"{url}";

            HttpResponseMessage response = null;

            //Check for valid token before the network request
            if (!SynergeticClient.IsTokenValid())
            {
                //automatically acquire it if it is not valid
                if (SynergeticClient.AutomaticallyAcquireToken)
                {
                    await SynergeticClient.AquireToken();
                }
                else
                {
                    throw new SynergeticApiException("AuthToken has not been acquired, or has expired.");
                }
            }

            if (method == HttpMethod.Get || method == HttpMethod.Delete)
            {
                if (data != null)
                {
                    requestUrl += $"?{Helpers.ObjectToQueryString(data)}";
                }

                if (method == HttpMethod.Get)
                {
                    response = await SynergeticClient.ApiClient.GetAsync(requestUrl);
                }
                else if (method == HttpMethod.Delete)
                {
                    response = await SynergeticClient.ApiClient.DeleteAsync(requestUrl);
                }
            }
            else
            {
                var jsonString = JsonSerializer.Serialize(data, SynergeticClient.JsonSerialiserOptions);
                var json = new StringContent(
                                jsonString,
                                Encoding.UTF8,
                                "application/json");

                if (method == HttpMethod.Post)
                {
                    response = await SynergeticClient.ApiClient.PostAsync(requestUrl, json);
                }
                else if (method == HttpMethod.Put)
                {
                    response = await SynergeticClient.ApiClient.PutAsync(requestUrl, json);
                }
            }

            using (var responseStream = await response.Content.ReadAsStreamAsync())
            {
                if (!response.IsSuccessStatusCode)
                {
                    var error = await JsonSerializer.DeserializeAsync<Error>(responseStream);
                    throw new SynergeticApiException(error.Message);
                };

                var returnObject = await JsonSerializer.DeserializeAsync<U>(responseStream);
                return returnObject;
            }
        }
    }
}