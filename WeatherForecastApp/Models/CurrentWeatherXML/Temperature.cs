using System.Xml.Serialization;

namespace WeatherForecastApp.Models.CurrentWeatherXML
{
	[XmlRoot(ElementName = "temperature")]
	public class Temperature
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "min")]
		public string Min { get; set; }
		[XmlAttribute(AttributeName = "max")]
		public string Max { get; set; }
		[XmlAttribute(AttributeName = "unit")]
		public string Unit { get; set; }
	}
}