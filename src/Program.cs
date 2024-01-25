using QuickCashClient.BusinessLogic;
using QuickCashClient.BusinessLogic.Implementation;

namespace NewApiTestApp
{
	internal static class Program
	{
		internal static readonly ICerebroPlayerService CerebroPlayerService;

		static Program()
		{
			CerebroPlayerService= new CerebroPlayerService();
		}

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}