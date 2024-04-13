using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchiriere_Masina_2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());

            //ControlMasina cm = new ControlMasina();
            //cm.load();
            //cm.save();
            //cm.testAfisare();

        }
    }
}
