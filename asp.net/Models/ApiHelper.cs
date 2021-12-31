using System.Net.Http;
using System.Net.Http.Headers;

namespace asp.net.Models
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; } = new HttpClient();
        public static void InitizalizeClient() {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
    


}