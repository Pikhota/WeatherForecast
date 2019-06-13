using System.Xml.Serialization;

namespace WeatherForecastApp.Models.CurrentWeatherXML
{
	[XmlRoot(ElementName = "direction")]
	public class Direction
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "code")]
		public string Code { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}
}