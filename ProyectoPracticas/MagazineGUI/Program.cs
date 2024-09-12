using Magazine.Persistence;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazineGUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IMagazineService ms = new MagazineService(new EntityFrameworkDAL(new MagazineDbContext()));
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MagazineAPP(ms));
        }
    }
}
