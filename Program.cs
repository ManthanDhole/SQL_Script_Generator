using SQL_ScriptGenUtility.Forms;
using SQL_ScriptGenUtility.Forms.DDL_Forms;

namespace SQL_ScriptGenUtility
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
            Application.Run(new SQL_ScriptGenForm());
        }
    }
}