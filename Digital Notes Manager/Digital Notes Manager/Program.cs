using System.Globalization;

namespace Digital_Notes_Manager
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
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-EG");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-EG");
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginRegisterMDI());
        }
    }
}