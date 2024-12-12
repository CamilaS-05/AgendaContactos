using System;
using System.Windows.Forms;

namespace AgendaContactos
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Asegúrate de que aquí está `MainForm`
        }
    }
}
