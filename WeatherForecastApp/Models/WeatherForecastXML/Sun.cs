using System.Xml.Serialization;

namespace WeatherForecastApp.Models.WeatherForecastXML
{
	[XmlRoot(ElementName = "sun")]
	public class Sun
	{
		[XmlAttribute(AttributeName = "rise")]
		public string Rise { get; set; }
		[XmlAttribute(AttributeName = "set")]
		public string Set { get; set; }
	}
}