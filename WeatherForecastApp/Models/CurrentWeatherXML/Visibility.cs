using System.Xml.Serialization;

namespace WeatherForecastApp.Models.CurrentWeatherXML
{
	[XmlRoot(ElementName = "visibility")]
	public class Visibility
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}
}