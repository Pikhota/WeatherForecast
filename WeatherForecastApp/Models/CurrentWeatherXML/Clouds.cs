using System.Xml.Serialization;

namespace WeatherForecastApp.Models.CurrentWeatherXML
{
	[XmlRoot(ElementName = "clouds")]
	public class Clouds
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}
}