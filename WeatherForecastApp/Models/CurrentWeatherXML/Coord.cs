using System.Xml.Serialization;

namespace WeatherForecastApp.Models.CurrentWeatherXML
{
	[XmlRoot(ElementName = "coord")]
	public class Coord
	{
		[XmlAttribute(AttributeName = "lon")]
		public string Lon { get; set; }
		[XmlAttribute(AttributeName = "lat")]
		public string Lat { get; set; }
	}
}