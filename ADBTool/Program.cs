using ADBTool.Controller;
using ADBTool.Model;
using ADBTool.View;

namespace ADBTool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            FileConfiguration fileConfiguration = new FileConfiguration();
            MainForm mainForm = new MainForm();
            ADBToolController controller = new ADBToolController(fileConfiguration, mainForm);
            
            controller.LoadConfiguration();
            

            Application.Run(mainForm);
        }
    }
}