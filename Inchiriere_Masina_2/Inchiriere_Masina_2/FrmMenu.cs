using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchiriere_Masina_2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            ControlMasina ca = new ControlMasina();
            ca.afisareTabel(LvwTabel);
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            ControlMasina ca = new ControlMasina();
            ca.afisareTabel(LvwTabel);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmAdd fd = new FrmAdd();
            fd.Show();



        }
    }
}
