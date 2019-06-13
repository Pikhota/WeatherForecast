using System.Xml.Serialization;

namespace WeatherForecastApp.Models.CurrentWeatherXML
{
	[XmlRoot(ElementName = "wind")]
	public class Wind
	{
		[XmlElement(ElementName = "speed")]
		public Speed Speed { get; set; }
		[XmlElement(ElementName = "gusts")]
		public string Gusts { get; set; }
		[XmlElement(ElementName = "direction")]
		public Direction Direction { get; set; }
	}
}