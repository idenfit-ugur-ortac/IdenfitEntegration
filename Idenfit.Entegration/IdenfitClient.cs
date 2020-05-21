using Idenfit.Entegration.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Idenfit.Entegration
{
    public class IdenfitClient
    {

        private const string SERVER = "https://clean-circle-264508.appspot.com/entegration";

        private const string ENTEGRATION_KEY = "** ENTEGRATION KEY **";


        private ServerResult SendRequest(string path, object data, HttpMethod method, out HttpStatusCode statusCode)
        {
            string json = JsonConvert.SerializeObject(data);

            using (var httpClient = new HttpClient())
            {
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage(method, SERVER + "/" + path);

                httpRequestMessage.Headers.Add("authorization", ENTEGRATION_KEY);

                httpRequestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");

                var httpResponse = httpClient.SendAsync(httpRequestMessage).Result;

                statusCode = httpResponse.StatusCode;

                if (httpResponse.Content != null)
                {
                    var responseContent = httpResponse.Content.ReadAsStringAsync().Result;

                    if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Created || statusCode == HttpStatusCode.NoContent)
                    {
                        return JsonConvert.DeserializeObject<ServerResult>(responseContent);
                    }
                }
            }

            return null;
        }

        public ServerResult Insert(string path, object data)
        {
            HttpStatusCode statusCode;

            var result = SendRequest(path, data, HttpMethod.Post, out statusCode);

            if (statusCode == HttpStatusCode.Created)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public ServerResult Update(string path, object data)
        {
            HttpStatusCode statusCode;

            var result = SendRequest(path, data, HttpMethod.Put, out statusCode);

            if (statusCode == HttpStatusCode.OK)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public ServerResult Delete(string path)
        {
            HttpStatusCode statusCode;

            var result = SendRequest(path, null, HttpMethod.Delete, out statusCode);

            if (statusCode == HttpStatusCode.NoContent)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
