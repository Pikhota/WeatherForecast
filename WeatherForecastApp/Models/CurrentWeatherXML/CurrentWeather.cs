using System.Xml.Serialization;

namespace WeatherForecastApp.Models.CurrentWeatherXML
{

	[XmlRoot(ElementName = "current")]
	public class CurrentWeather
	{
		[XmlElement(ElementName = "city")]
		public City City { get; set; }

		[XmlElement(ElementName = "temperature")]
		public Temperature Temperature { get; set; }

		[XmlElement(ElementName = "humidity")]
		public Humidity Humidity { get; set; }

		[XmlElement(ElementName = "pressure")]
		public Pressure Pressure { get; set; }

		[XmlElement(ElementName = "wind")]
		public Wind Wind { get; set; }

		[XmlElement(ElementName = "clouds")]
		public Clouds Clouds { get; set; }

		[XmlElement(ElementName = "visibility")]
		public Visibility Visibility { get; set; }

		[XmlElement(ElementName = "precipitation")]
		public Precipitation Precipitation { get; set; }

		[XmlElement(ElementName = "weather")]
		public Weather Weather { get; set; }

		[XmlElement(ElementName = "lastupdate")]
		public Lastupdate Lastupdate { get; set; }
	}
}