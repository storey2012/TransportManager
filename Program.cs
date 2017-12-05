using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace TransManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            User user;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Log.Create("C:\\transmanager\\Log", "TransManager");
#if DEBUG
            Log.WriteLine("Starting TransManager in DEBUG mode");
#else
            Log.WriteLine("Starting TransManager");
#endif 
            
            try
            {
                Application.Run(new frmSwitchboard());
            }
            catch (System.Exception e) {
                Log.WriteLine("ERROR - " + e.Message);
                MessageBox.Show("An error has occured in the application as follows: " + e.Message + ". Please refer to the log file for details.");
            }


        }
    }
}
