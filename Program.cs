using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Grading ID: D3100
//Due Date: 11/12/2018
//Section NUmber: 01
//In this program we are adding to our previous solution, an option to edit or addresses and add in more addresses if we'd like too

namespace UPVApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Prog2Form());
        }
    }
}
