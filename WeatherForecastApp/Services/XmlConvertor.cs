using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace WeatherForecastApp.Services
{
	public static class XmlConvertor
	{
		/// <summary>
		/// Convert XML data to a special object type
		/// </summary>
		/// <typeparam name="T">a special object type</typeparam>
		/// <param name="url">link from get data</param>
		/// <returns>returns a special object with a special type</returns>
		public static T ConvertXmlToObject<T>(string url)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(T));

			WebClient web = new WebClient();

			string strData = web.DownloadString(url);

			Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(strData));

			return (T)serializer.Deserialize(stream);
		}
	}
}