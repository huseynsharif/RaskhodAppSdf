using Microsoft.EntityFrameworkCore;
using RaskhodApp.Models2;
using RaskhodApp.UI;
using RaskhodApp.utils;

namespace RaskhodApp
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
            ApplicationConfiguration.Initialize();
            MyDbContext2 dbContext = new MyDbContext2();
            
            try
            {
                Login loginPage = new Login(dbContext);
                if (loginPage.ShowDialog() == DialogResult.OK)
                {

                    Application.Run(new HomePage(dbContext, loginPage.loggedInUser));
                }
            }
            catch (Exception ex)
            {
                JsonLogger.LogError(ex);
            }

        }
    }
}