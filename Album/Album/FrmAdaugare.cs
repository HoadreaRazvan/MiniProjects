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
    public partial class FrmAdaugare : Form
    {
        public FrmAdaugare()
        {
            InitializeComponent();
        }

        private void BtnTrimitere_Click(object sender, EventArgs e)
        {
            if (TxtMarca.Text != "" && TxtKm.Text != "" && TxtPret.Text != "")
            {
                ControlMasini controlMasini = new ControlMasini();
                controlMasini.adauga(TxtMarca, TxtKm, TxtPret);
                
                MessageBox.Show("Masina a fost adaugata cu succes");
                this.Close();
            }
            else
                if (TxtMarca.Text == "")
                     MessageBox.Show("Nu ati introdus marca");
                else
                    if(TxtKm.Text != "")
                        MessageBox.Show("Nu ati introdus numarul de kilometri");
                    else
                        if(TxtPret.Text == "")
                             MessageBox.Show("Nu ati introdus marca");
        }
    }
}
