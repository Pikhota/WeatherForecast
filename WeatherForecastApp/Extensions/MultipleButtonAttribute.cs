using System;
using System.Reflection;
using System.Web.Mvc;

namespace WeatherForecastApp.Extensions
{
	/// <summary>
	/// A special class to use multiple submit data in a form which allows transfer each request by a special attributes
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public class MultipleButtonAttribute : ActionNameSelectorAttribute
	{
		public string Name { get; set; }
		public string Argument { get; set; }

		/// <summary>
		/// Method which check valid name of an name and argument in the attribute which relate on a special action method if is valid, transfer a request from view to this method. 
		/// </summary>
		/// <param name="controllerContext">controller context</param>
		/// <param name="actionName">an action name</param>
		/// <param name="methodInfo">don't need use it</param>
		/// <returns></returns>
		public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
		{
			var isValidName = false;
			var keyValue = $"{Name}:{Argument}";
			var value = controllerContext.Controller.ValueProvider.GetValue(keyValue);

			if (value != null)
			{
				controllerContext.Controller.ControllerContext.RouteData.Values[Name] = Argument;
				isValidName = true;
			}

			return isValidName;
		}
	}
}