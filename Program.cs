using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ATMSimulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ATMNetwork Network = new ATMNetwork();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           // Application.Run(new ATMDisplay(Network));


            //code inspired by https://stackoverflow.com/questions/15300887/run-two-winform-windows-simultaneously && https://stackoverflow.com/questions/3360555/how-to-pass-parameters-to-threadstart-method-in-thread
            var atmOne = new Thread(() => atmStart(Network));
            atmOne.Start();

            var atmTwo = new Thread(() => atmStart(Network));
            atmTwo.Start();

        }

        private static void atmStart(ATMNetwork network)
        {
            Application.Run(new ATMDisplay(network));
        }
    }
}
