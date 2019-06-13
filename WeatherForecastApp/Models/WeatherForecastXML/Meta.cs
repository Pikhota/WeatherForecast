﻿using System.Xml.Serialization;

namespace WeatherForecastApp.Models.WeatherForecastXML
{
	[XmlRoot(ElementName = "meta")]
	public class Meta
	{
		[XmlElement(ElementName = "lastupdate")]
		public string Lastupdate { get; set; }
		[XmlElement(ElementName = "calctime")]
		public string Calctime { get; set; }
		[XmlElement(ElementName = "nextupdate")]
		public string Nextupdate { get; set; }
	}
}