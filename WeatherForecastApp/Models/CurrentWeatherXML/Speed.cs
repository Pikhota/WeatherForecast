using System.Xml.Serialization;

namespace WeatherForecastApp.Models.CurrentWeatherXML
{
	[XmlRoot(ElementName = "speed")]
	public class Speed
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}
}