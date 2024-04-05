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
    public partial class FrmInchiriere : Form
    {
        public FrmInchiriere()
        {
            InitializeComponent();
        }

        private void TxtNume_Leave(object sender, EventArgs e)
        {
            ControlMasini control = new ControlMasini();
            control.verificNume(TxtNume);
        }

        private void LblTrimite_Click(object sender, EventArgs e)
        {
            if (TxtNume.Text != "" && TxtNumeClient.Text != "")
            {
                ControlMasini control = new ControlMasini();
                control.inchiriaza(TxtNume, TxtNumeClient);
                MessageBox.Show("Masina a fost inchiriata cu succes!");
                this.Close();

            }
            else if(TxtNume.Text=="")
            {
                TxtNume.Focus();

            }
            else
            {
                TxtNumeClient.Focus();
            }


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {    
            this.Close();          
        }

 
    }
}
