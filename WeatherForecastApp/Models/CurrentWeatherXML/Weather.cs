using System.Xml.Serialization;

namespace WeatherForecastApp.Models.CurrentWeatherXML
{
	[XmlRoot(ElementName = "weather")]
	public class Weather
	{
		[XmlAttribute(AttributeName = "number")]
		public string Number { get; set; }
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "icon")]
		public string Icon { get; set; }
	}
}