using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using WeatherForecastApp.Services;

namespace WeatherForecastApp.App_Start
{
	public class AutofacConfig
	{
		/// <summary>
		/// Configures  dependency injection
		/// </summary>
		public static void ConfigureContainer()
		{
			var builder = new ContainerBuilder();
			builder.RegisterControllers(typeof(MvcApplication).Assembly);
			builder.RegisterType<WeatherService>().As<IWeatherService>();

			var container = builder.Build();

			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
		}
	}
}