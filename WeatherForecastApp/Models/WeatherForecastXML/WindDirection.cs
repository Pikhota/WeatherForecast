using System.Xml.Serialization;

namespace WeatherForecastApp.Models.WeatherForecastXML
{
	[XmlRoot(ElementName = "windDirection")]
	public class WindDirection
	{
		[XmlAttribute(AttributeName = "deg")]
		public string Deg { get; set; }
		[XmlAttribute(AttributeName = "code")]
		public string Code { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}
}