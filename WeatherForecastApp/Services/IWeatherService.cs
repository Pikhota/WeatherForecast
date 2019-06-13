using WeatherForecastApp.Models.CurrentWeatherXML;
using WeatherForecastApp.Models.WeatherForecastXML;

namespace WeatherForecastApp.Services
{
	/// <summary>
	/// IWeatherService interface
	/// </summary>
	public interface IWeatherService
	{
		CurrentWeather GetCurrentWeather(string city);
		WeatherForecast GetWeatherForecast(string city);
	}
}
