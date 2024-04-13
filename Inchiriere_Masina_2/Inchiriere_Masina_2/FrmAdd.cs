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
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void BtnRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTrimitere_Click(object sender, EventArgs e)
        {
            if (TxtMarca.Text != "" && TxtPret.Text != "" && TxtKilometri.Text != "" && TxtCombustibil.Text != "" && TxtAni.Text != "")
            {
                ControlMasina cm = new ControlMasina();
                cm.adaugare(TxtMarca, TxtAni, TxtKilometri, TxtCombustibil, TxtPret);
                this.Close();
            }
        }


    }
}
