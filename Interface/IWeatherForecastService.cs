using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PizzaAPI.Service
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
        IEnumerable<WeatherForecast> Get(int ile, int min, int max);
    }
}