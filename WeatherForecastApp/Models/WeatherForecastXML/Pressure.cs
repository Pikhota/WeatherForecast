using System.Xml.Serialization;

namespace WeatherForecastApp.Models.WeatherForecastXML
{
	[XmlRoot(ElementName = "pressure")]
	public class Pressure
	{
		[XmlAttribute(AttributeName = "unit")]
		public string Unit { get; set; }
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}