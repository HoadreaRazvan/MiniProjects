using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spalatorie_auto
{
    public partial class FrmSpalatorie : Form
    {
        public FrmSpalatorie()
        {
            InitializeComponent();
        }


       

        private void FrmSpalatorie_Load(object sender, EventArgs e)
        {

        }

        private void chAutoturism_CheckedChanged(object sender, EventArgs e)
        {
            if (chAutoturism.Checked == true)
            {
                chSUV.Checked = false;
                chMare35t.Checked = false;
                chMica35t.Checked = false;
            }
        }

        private void chSUV_CheckedChanged(object sender, EventArgs e)
        {
            if (chSUV.Checked == true)
            {
                chMare35t.Checked = false;
                chMica35t.Checked = false;
                chAutoturism.Checked = false;
            }
        }

        private void chMare35t_CheckedChanged(object sender, EventArgs e)
        {
            if (chMare35t.Checked == true)
            {
                chMica35t.Checked = false;
                chSUV.Checked = false;
                chAutoturism.Checked = false;
            }
        }

        private void chMica35t_CheckedChanged(object sender, EventArgs e)
        {
            if (chMica35t.Checked == true)
            {
                chSUV.Checked = false;
                chAutoturism.Checked = false;
                chMare35t.Checked = false;
            }
        }


        private void chInterior_CheckedChanged(object sender, EventArgs e)
        {
            if(chInterior.Checked==true)              
            {
                chAmbele.Checked = false;              
            }
            if(chExterior.Checked==true)
            {
                chInterior.Checked = false;
                chExterior.Checked = false;
                chAmbele.Checked = true;
            }         
        }

        private void chExterior_CheckedChanged(object sender, EventArgs e)
        {
            if(chExterior.Checked==true)
            {
                chAmbele.Checked = false;
            }
            if (chInterior.Checked == true)
            {
                chInterior.Checked = false;
                chExterior.Checked = false;
                chAmbele.Checked = true;
            }
        }

        private void chAmbele_CheckedChanged(object sender, EventArgs e)
        {
            if (chAmbele.Checked == true)
            {
                chInterior.Checked = false;
                chExterior.Checked = false;
            }              
        }

        private void lblPreturi_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //servicii
            //if(chAutoturism.Checked==false&&chSUV.Checked==false&&chMare35t.Checked==false&&chMica35t.Checked==false)


            int suma = 0;
            if(chAmbele.Checked==true)
                suma += 20;
            if(chInterior.Checked==true)
                suma += 10;
            if(chExterior.Checked==true)
                suma += 10;
            if(chMotor.Checked==true)
                suma += 20;

            if(chAutoturism.Checked==true)
                suma += 5;
            if(chSUV.Checked==true)
                suma += 10;
            if(chMica35t.Checked==true)
                suma += 15;
            if(chMare35t.Checked==true)
                suma += 20;

            if (!txtBaccis.Text.Equals(""))
            {
                int baccis = int.Parse(txtBaccis.Text);
                suma += baccis;
            }

            lblAfisare.Text= $"Suma de achitat este {suma}";
            lblAfisare.Visible =true;
            if (txtAchitare.Text != "") 
            tbRest.Text = (int.Parse(txtAchitare.Text) - suma).ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chAmbele.Checked = false;         
            chInterior.Checked = false;
            chExterior.Checked = false;
            chMotor.Checked = false;
            chAutoturism.Checked = false;
            chSUV.Checked = false;
            chMare35t.Checked = false;
            chMica35t.Checked = false;
            lblAfisare.Visible = false;
            txtBaccis.Text = "";
        }


    }
}
