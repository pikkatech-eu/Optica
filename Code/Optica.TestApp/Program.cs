using Microsoft.Extensions.DependencyInjection;
using Optica.Contracts;
using Optica.WinForms;

namespace Optica.TestApp
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
			services.AddSingleton<IListViewService<Location>, WinFormsListViewService<Location>>();

			ServiceProvider provider = services.BuildServiceProvider();

			ICommonDialogService dialogService = provider.GetRequiredService<ICommonDialogService>();
			IListViewService<Location> listViewService = provider.GetRequiredService<IListViewService<Location>>();

			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			OpticaTestForm opticaTestForm = new OpticaTestForm(dialogService, listViewService);

			Application.Run(opticaTestForm);
		}
	}
}