using System.Collections.Generic;
using System.Web.Mvc;
using WeatherForecastApp.Extensions;
using WeatherForecastApp.Models;
using WeatherForecastApp.Models.CurrentWeatherXML;
using WeatherForecastApp.Models.WeatherForecastXML;
using WeatherForecastApp.Services;

namespace WeatherForecastApp.Controllers
{
	public class WeatherController : Controller
    {
		private IWeatherService _weatherService;

		/// <summary>
		/// Get instance of weather service from constructor used autofac IoC
		/// </summary>
		/// <param name="weatherService"></param>
		public WeatherController(IWeatherService weatherService)
		{
			_weatherService = weatherService;
		}

        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

		/// <summary>
		/// An action method to get wheather forecast data by a special city name 
		/// </summary>
		/// <param name="city">a special city name</param>
		/// <returns></returns>
		[HttpPost]
		[MultipleButton(Name = "action", Argument = "CurrentWeather")]
		public ActionResult CurrentWeather(string city)
		{
			if (string.IsNullOrWhiteSpace(city)) return View();

			CurrentWeather weather = _weatherService.GetCurrentWeather(city);

			CurrentWeatherDTO weatherDTO = new CurrentWeatherDTO
			{
				City = weather.City.Name,
				Country = weather.City.Country,
				WeatherIcon = weather.Weather.Icon,
				Temperature = $"{weather.Temperature.Value.Split('.')[0]} °C",
				Cloudiness = weather.Clouds.Name.ToUpper(),
				Wind = $"{weather.Wind.Speed.Name}, {weather.Wind.Speed.Value} m/s",
				WindDirection = $"{weather.Wind.Direction.Name} ( {weather.Wind.Direction.Value} )",
				Pressure = $"{weather.Pressure.Value} {weather.Pressure.Unit.ToLower()}",
				Humidity = $"{weather.Humidity.Value} {weather.Humidity.Unit}",
				Sunrise = weather.City.Sun.Rise.Split('T')[1],
				Sunset = weather.City.Sun.Set.Split('T')[1],
				CoordLat = weather.City.Coord.Lat,
				CoordLon = weather.City.Coord.Lon
			};

			return PartialView("_currentWeather", weatherDTO);
		}
		
		/// <summary>
		/// An action method to get wheather forecast data by a special city name 
		/// </summary>
		/// <param name="city">a special city name</param>
		/// <returns></returns>
		[HttpPost]
		[MultipleButton(Name = "action", Argument = "WeatherForecast")]
		public ActionResult WeatherForecast(string city)
		{
			if (string.IsNullOrWhiteSpace(city)) return View();

			WeatherForecast weather = _weatherService.GetWeatherForecast(city);

			List<TimePeriodDTO> weatherForecast = new List<TimePeriodDTO>();

			foreach (var period in weather.Forecast.ThreeHoursPeriod)
			{
				weatherForecast.Add(new TimePeriodDTO
				{
					Location = city.ToUpper(),
					Time = $"{period.From.Split('T')[1].Split(':')[0]}:{period.From.Split('T')[1].Split(':')[1]}",
					Date = period.From.Split('T')[0],
					Temp = $"{period.Temperature.Value.Split('.')[0]} °C",
					WindSpeed = $"{period.WindSpeed.Mps} m/s({period.WindSpeed.Name})",
					WindDirection = $"{period.WindDirection.Name}( {period.WindDirection.Deg} )",
					Humidity = $"{period.Humidity.Value} {period.Humidity.Unit}",
					Pressure = $"{period.Pressure.Value}{period.Pressure.Unit.ToLower()}",
					CloudsName = $"{period.Clouds.Value}",
					CloudsValue = $"clouds:{period.Clouds.All}%",
					Icon = $"https://openweathermap.org/img/w/{period.Symbol.Var}.png"
				});
			}

			return PartialView("_weatherForecast",weatherForecast);
		}
	}
}