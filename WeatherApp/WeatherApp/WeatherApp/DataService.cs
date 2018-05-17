using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace WeatherApp
{
    public class DataService
    {
        public static async Task<dynamic> GetDataFromService(string queryString)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(queryString);

            dynamic data = null;

            if (response != null)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }

            return data;
        }
    }
}
