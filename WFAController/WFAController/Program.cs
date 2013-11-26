using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAController
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var obj = new MainForm();
                Application.Run(obj);

            
            //}
            //catch (NullReferenceException e)
            //{
            //    MessageBox.Show(e.TargetSite.ToString());
            //}
        }
    }
}
