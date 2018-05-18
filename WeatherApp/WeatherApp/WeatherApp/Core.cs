using System;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Core
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public static async Task<Weather> GetWeather(string zipCode)
        {
            const string key = "1c655688dd5648fa75230968bf9fcc91";

            var queryString =
                $"http://api.openweathermap.org/data/2.5/weather?zip={zipCode},us&appid={key}&units=imperial";

            var results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                var weather = new Weather
                {
                    Title = results["name"],
                    Temperature = $"{results["main"]["temp"]} F",
                    Wind = $"{results["wind"]["speed"]} mph",
                    Humidity = $"{results["main"]["humidity"]} %",
                    Visibility = $"{results["weather"][0]["main"]}",
                    Sunrise = $"{epoch.AddSeconds((double)results["sys"]["sunrise"])} UTC",
                    Sunset = $"{epoch.AddSeconds((double)results["sys"]["sunset"])} UTC",
                };

                return weather;
            }
            return null;
        }
    }
}
