using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Album
{
    public partial class FrmReturnare : Form
    {
        public FrmReturnare()
        {
            InitializeComponent();
        }

        private void BtnTrimitere_Click(object sender, EventArgs e)
        {
            ControlMasini controlMasini = new ControlMasini();
            if (TxtMarca.Text != "" && controlMasini.verfStatus(TxtMarca.Text))
            {
                controlMasini.returnareMasina(TxtMarca);
                MessageBox.Show("Masina a fost returnata cu succes!");
                this.Close();
            }
            else
                if (TxtMarca.Text == "")
                MessageBox.Show("Nu ati introdus marca");
            else
                MessageBox.Show("Aceasta masina nu este inchiriata");

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
