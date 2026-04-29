using Microsoft.Extensions.DependencyInjection;
using Opica.Contracts;
using Opica.WinForms;

namespace Opica.TestApp
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var services = new ServiceCollection();
			services.AddSingleton<ICommonDialogService, WinFormsCommonDialogService>();

			ServiceProvider provider = services.BuildServiceProvider();

			ICommonDialogService dialogService = provider.GetRequiredService<ICommonDialogService>();

			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			OpicaTestForm OpicaTestForm = new OpicaTestForm(dialogService);

			Application.Run(OpicaTestForm);
		}
	}
}