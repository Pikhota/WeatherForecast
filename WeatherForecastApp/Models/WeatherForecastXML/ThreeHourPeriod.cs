using System.Xml.Serialization;

namespace WeatherForecastApp.Models.WeatherForecastXML
{
	[XmlRoot(ElementName = "time")]
	public class ThreeHourPeriod
	{
		[XmlElement(ElementName = "symbol")]
		public Symbol Symbol { get; set; }

		[XmlElement(ElementName = "precipitation")]
		public Precipitation Precipitation { get; set; }

		[XmlElement(ElementName = "windDirection")]
		public WindDirection WindDirection { get; set; }

		[XmlElement(ElementName = "windSpeed")]
		public WindSpeed WindSpeed { get; set; }

		[XmlElement(ElementName = "temperature")]
		public Temperature Temperature { get; set; }

		[XmlElement(ElementName = "pressure")]
		public Pressure Pressure { get; set; }

		[XmlElement(ElementName = "humidity")]
		public Humidity Humidity { get; set; }

		[XmlElement(ElementName = "clouds")]
		public Clouds Clouds { get; set; }

		[XmlAttribute(AttributeName = "from")]
		public string From { get; set; }

		[XmlAttribute(AttributeName = "to")]
		public string To { get; set; }
	}
}