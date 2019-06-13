using System.Collections.Generic;
using System.Xml.Serialization;

namespace WeatherForecastApp.Models.WeatherForecastXML
{
	[XmlRoot(ElementName = "forecast")]
	public class Forecast
	{
		[XmlElement(ElementName = "time")]
		public List<ThreeHourPeriod> ThreeHoursPeriod { get; set; }
	}
}