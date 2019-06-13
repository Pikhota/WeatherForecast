using System.Xml.Serialization;

namespace WeatherForecastApp.Models.WeatherForecastXML
{
	[XmlRoot(ElementName = "windSpeed")]
	public class WindSpeed
	{
		[XmlAttribute(AttributeName = "mps")]
		public string Mps { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}
}