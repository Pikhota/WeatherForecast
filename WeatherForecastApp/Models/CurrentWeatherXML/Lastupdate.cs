using System.Xml.Serialization;

namespace WeatherForecastApp.Models.CurrentWeatherXML
{
	[XmlRoot(ElementName = "lastupdate")]
	public class Lastupdate
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}