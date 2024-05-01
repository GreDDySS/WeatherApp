using System;
using System.Collections.Generic;

// Модель для текущей погоды
public class CurrentWeather
{
    public MainCurrent Main {  get; set; }
    public WindCurrent Wind { get; set; }
    public CloudCurrent Cloud { get; set; }
    public SysCurrent Sys { get; set; }

    public int Visibility {  get; set; }
}

public class MainCurrent
{
    public double Temp { get; set; }
    public double Feels_Like { get; set; }
    public int Pressure { get; set; }
    public int Humidity { get; set; }
}
public class WindCurrent
{
    public int Speed { get; set; }
    public int Deg { get; set; }
}
public class CloudCurrent
{
    public int all { get; set; }
}
public class SysCurrent
{
    public string Country { get; set; }
    public int sunrise { get; set; }
    public int sunset { get; set; }
}

// Модель для прогноза погоды на определенное время суток
public class WeatherForecast
{
    public string TimeOfDay { get; set; } // Время суток (утро, день, ночь)
    public float Temperature { get; set; } // Температура в градусах Цельсия
    public int Humidity { get; set; } // Влажность в процентах
    public float FeelsLike { get; set; } // Ощущаемая температура в градусах Цельсия
    public float Pressure { get; set; } // Давление в гектопаскалях
    public float WindSpeed { get; set; } // Скорость ветра в метрах в секунду
    public int ChanceOfRain { get; set; } // Вероятность дождя в процентах
    public string Cloud { get; set; } // Облачность
}

// Модель для прогноза погоды на определенный день
public class DailyWeatherForecast
{
    public DateTime Date { get; set; } // Дата прогноза
    public WeatherForecast Morning { get; set; } // Прогноз на утро
    public WeatherForecast Day { get; set; } // Прогноз на день
    public WeatherForecast Night { get; set; } // Прогноз на ночь
}
