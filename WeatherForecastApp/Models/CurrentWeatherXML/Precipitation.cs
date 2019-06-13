using System.Xml.Serialization;

namespace WeatherForecastApp.Models.CurrentWeatherXML
{
	[XmlRoot(ElementName = "precipitation")]
	public class Precipitation
	{
		[XmlAttribute(AttributeName = "mode")]
		public string Mode { get; set; }
	}
}