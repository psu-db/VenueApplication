using Syncfusion.Licensing;

namespace VenueApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NDaF1cX2hIfEx0RHxbf1x0ZFRGalhSTnRXUiweQnxTdEFiWH1fcXVWR2BdUEV0XQ==");
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}