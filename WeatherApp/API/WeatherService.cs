using System;
using System.Drawing.Design;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace WeatherApp.API
{
    public class WeatherService
    {

    
    

        private readonly HttpClient _httpClient;
         private const string ApiKey = ""; // paste apikey 
        private const string ApiUrl = "http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric";
        public WeatherService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<CurrentWeather> GetCurrentWeatherAsync(string city)
        {
            var apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey}&units=metric";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                
                string json = await response.Content.ReadAsStringAsync();

                CurrentWeather currentWeather = JsonConvert.DeserializeObject<CurrentWeather>(json);

                return currentWeather;


            }
            else
            {
                // Обработка ошибки запроса
                Console.WriteLine("Error fetching current weather data");
                return null;
            }
        }
        /*
        public async Task<DailyWeatherForecast> GetDailyWeatherForecast(string city, DateTime date)
        {
            string formattedDate = date.ToString("yyyy-MM-dd");
            string url = $"http://api.openweathermap.org/data/2.5/forecast?q=omsk&appid={ApiKey}&units=metric";

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                dynamic WeatherData = JsonConvert.DeserializeObject(json);

                // Поиск прогноза на указзонную дату
                foreach (var item in WeatherData.list)
                {
                    string itemDate = item.dt_txt;
                    DateTime forecastDate = DateTime.Parse(itemDate);

                    if (forecastDate.Date == date.Date)
                    {
                        // Преобразование данных прогноза в объект DailyWeatherForecast
                        DailyWeatherForecast dailyForecast = new DailyWeatherForecast
                        {
                            Date = forecastDate,
                            Morning = new WeatherForecast
                            {
                                TimeOfDay = "Morning",
                                Temperature = item.main.temp,
                                Humidity = item.main.humidity,
                                FeelsLike = item.main.feels_like,
                                Pressure = item.main.pressure,
                                WindSpeed = item.wind.speed,
                                ChanceOfRain = item.pop,
                                Cloud = item.weather[0].description
                            },
                            Day = new WeatherForecast
                            {
                                TimeOfDay = "Day",
                                Temperature = item.main.temp,
                                Humidity = item.main.humidity,
                                FeelsLike = item.main.feels_like,
                                Pressure = item.main.pressure,
                                WindSpeed = item.wind.speed,
                                ChanceOfRain = item.pop,
                                Cloud = item.weather[0].description
                            },
                            Night = new WeatherForecast
                            {
                                TimeOfDay = "Night",
                                Temperature = item.main.temp,
                                Humidity = item.main.humidity,
                                FeelsLike = item.main.feels_like,
                                Pressure = item.main.pressure,
                                WindSpeed = item.wind.speed,
                                ChanceOfRain = item.pop,
                                Cloud = item.weather[0].description
                            }
                        };

                        return dailyForecast;
                    }
                }
            }
            return null;
        }
        */
    }

}
