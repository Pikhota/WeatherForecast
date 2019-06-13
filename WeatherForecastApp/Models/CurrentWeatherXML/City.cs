using System.Xml.Serialization;

namespace WeatherForecastApp.Models.CurrentWeatherXML
{
	[XmlRoot(ElementName = "city")]
	public class City
	{
		[XmlElement(ElementName = "coord")]
		public Coord Coord { get; set; }
		[XmlElement(ElementName = "country")]
		public string Country { get; set; }
		[XmlElement(ElementName = "sun")]
		public Sun Sun { get; set; }
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}
}