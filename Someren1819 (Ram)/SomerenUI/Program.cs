using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
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
            Application.Run(new SomerenUI());
        }
        //public static Control ShowTeachers()
        //{
        //    ListView teachersList = new ListView();
        //    teachersList.Height =350;
        //    teachersList.Width = 600;
        //    return teachersList;
        //}
    }
}
