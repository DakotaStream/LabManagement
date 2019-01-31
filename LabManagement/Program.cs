﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManagement
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


            if (Constants.deleteDB == true)
            {
                LabManagement.Db.TestTables();
            }
            //Application.Run(new EmailCombinations());
            Db.ImportExcelData();
            Application.Run(new Main());
        }
    }
}
