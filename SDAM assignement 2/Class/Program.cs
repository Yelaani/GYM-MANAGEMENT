using SDAM_assignement_2.Forms;
using System;
using System.Windows.Forms;

namespace SDAM_assignement_2.Class
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1()); 
        }
    }
}
