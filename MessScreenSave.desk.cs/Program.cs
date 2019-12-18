using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessScreenSave.desk.cs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
/*
 * if (args.Length > 0)
            {
                if (args[0].ToLower().Trim().Substring(0, 2) == "/s") //show
                {
                      
                }
                else if (args[0].ToLower().Trim().Substring(0, 2) == "/p") //preview
                {
                    //preview the screen saver
                }
                else if (args[0].ToLower().Trim().Substring(0, 2) == "/c") //configure
                {
                    //configure the screen saver
                }
            }
            else
            {
                //no arguments were passed (we should probably show the screen saver)
            }
            */
