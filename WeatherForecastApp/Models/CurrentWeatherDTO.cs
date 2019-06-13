namespace WeatherForecastApp.Models
{
	/// <summary>
	/// Current Weather DTO class
	/// </summary>
	public class CurrentWeatherDTO
	{
		public string City { get; set; }
		public string Country { get; set; }
		public string WeatherIcon { get; set; }
		public string Temperature { get; set; }
		public string Cloudiness { get; set; }
		public string Wind { get; set; }
		public string WindDirection { get; set; }
		public string Pressure { get; set; }
		public string Humidity { get; set; }
		public string Sunrise { get; set; }
		public string Sunset { get; set; }
		public string CoordLat { get; set; }
		public string CoordLon { get; set; }
	}
}