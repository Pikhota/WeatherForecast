namespace WeatherForecastApp.Models
{
	/// <summary>
	/// Three hours period DTO class
	/// </summary>
	public class TimePeriodDTO
	{
		public string Date { get; set; }
		public string Location { get; set; }
		public string Time { get; set; }
		public string Temp { get; set; }
		public string WindSpeed { get; set; }
		public string WindDirection { get; set; }
		public string Pressure { get; set; }
		public string Humidity { get; set; }
		public string CloudsName { get; set; }
		public string CloudsValue { get; set; }
		public string Icon { get; set; }
	}
}