using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindRider
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            FormTesting frmVarMain = new FormTesting();
            Application.Run(frmVarMain);
        }
    }
}