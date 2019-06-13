using WeatherForecastApp.Models.CurrentWeatherXML;
using WeatherForecastApp.Models.WeatherForecastXML;

namespace WeatherForecastApp.Services
{
	public class WeatherService : IWeatherService
	{
		/// <summary>
		/// The key which allows us use openweathermap api
		/// </summary>
		private string Key { get; }

		public WeatherService()
		{
			Key = "f828b04a4cd77e31cfb448ed6b0aae3e";
		}

		/// <summary>
		/// Get current weather for a special city.
		/// </summary>
		/// <param name="city">City name</param>
		/// <returns>returns data in CurrentWeather object type</returns>
		public CurrentWeather GetCurrentWeather(string city)
		{
			if (string.IsNullOrWhiteSpace(city)) return null;

			var url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&mode=xml&units=metric&APPID={Key}";

			CurrentWeather currentWeather = XmlConvertor.ConvertXmlToObject<CurrentWeather>(url);

			currentWeather.Weather.Icon = $"http://openweathermap.org/img/w/{currentWeather.Weather.Icon}.png";

			return currentWeather;
		}

		/// <summary>
		/// Get the weather forecast for a special city
		/// </summary>
		/// <param name="city">City name</param>
		/// <returns>returns data in WeatherForecast object type</returns>
		public WeatherForecast GetWeatherForecast(string city)
		{
			if (string.IsNullOrWhiteSpace(city)) return null;

			var url = $"http://api.openweathermap.org/data/2.5/forecast?q={city}&mode=xml&units=metric&APPID={Key}";

			WeatherForecast weatherForecast = XmlConvertor.ConvertXmlToObject<WeatherForecast>(url);

			return weatherForecast;
		}
	}
}