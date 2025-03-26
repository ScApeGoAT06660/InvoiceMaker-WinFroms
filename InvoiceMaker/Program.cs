using InvoiceMaker.Domains;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceMaker
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalState.isSetUp = false;

            GlobalState.InvoicesFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Faktury");
            
            if (!Directory.Exists(GlobalState.InvoicesFolderPath))
            {
                Directory.CreateDirectory(GlobalState.InvoicesFolderPath);
            }

            Application.Run(new frmInvoiceManagement());

        }
    }
}
