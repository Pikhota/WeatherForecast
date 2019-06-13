using System.Xml.Serialization;

namespace WeatherForecastApp.Models.WeatherForecastXML
{
	[XmlRoot(ElementName = "clouds")]
	public class Clouds
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "all")]
		public string All { get; set; }
		[XmlAttribute(AttributeName = "unit")]
		public string Unit { get; set; }
	}
}