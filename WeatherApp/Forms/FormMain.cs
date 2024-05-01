using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp.API;

namespace WeatherApp.Forms
{
    public partial class FormMain : UserControl
    {
        public FormMain()
        {
            InitializeComponent();
        }

            private WeatherService _weatherService = new WeatherService();
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            string city = SearchBox.Text;
            DateTime date = DateTime.Today;

            try
            {
                CurrentWeather currentWeather = await _weatherService.GetCurrentWeatherAsync(city);
                if (currentWeather != null)
                {
                    LblCurrentLocation.Text = city.ToUpper();
                    LblMainTemp.Text = $"{currentWeather.Main.Temp}°C";
                    Humidity.Text = $"{currentWeather.Main.Humidity}%";
                    FeelsLike.Text = $"{currentWeather.Main.Feels_Like}°C";
                    Pressure.Text = $"{currentWeather.Main.Pressure}Hpa";
                    WindSpeed.Text = $"{currentWeather.Wind.Speed} km/h";
                    Visibility.Text = $"{currentWeather.Visibility / 1000}km";
                    //ChanceOfRain.Text = $"{currentWeather.ChanceOfRain}%";
                    Sunset.Text = $"{currentWeather.Sys.sunset}";
                }
                else
                {
                    MessageBox.Show("не-а", "не-а");
                }

            }
            catch
            {

            }
        }
    }
}
