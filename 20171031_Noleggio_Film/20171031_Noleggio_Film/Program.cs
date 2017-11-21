using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171031_Noleggio_Film
{
    static class Program
    {
        public static string utente;
        public static string conn_str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/ADO_Noleggio_Film (esperienza 3)/20170929_FILM.accdb";
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
