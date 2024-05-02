using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementareCodInterfata
{
    public partial class FrmProblema2 : Form
    {
        public FrmProblema2()
        {
            InitializeComponent();
        }

        Solutii solutii = new Solutii();
        
        //14

        private void btnPb14_Click(object sender, EventArgs e)
        {
            solutii.soluti14();
        }

        private void btnPb14_MouseHover(object sender, EventArgs e)
        {
            lblCerinta2.Text = "Sa se verifice daca cifrele unui numar oscileaza";
            lblCerinta2.Visible = true;
        }

        private void btnPb14_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta2.Visible = false;
        }

        //15

        private void btnPb15_Click(object sender, EventArgs e)
        {
            solutii.soluti15();
        }

        private void btnPb15_MouseHover(object sender, EventArgs e)
        {
            lblCerinta2.Text = "Sa se verifice daca un numar are aspect de fierastrau";
            lblCerinta2.Visible = true;
        }

        private void btnPb15_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta2.Visible = false;
        }

        //16

        private void btnPb16_Click(object sender, EventArgs e)
        {
            solutii.soluti16();
        }

        private void btnPb16_MouseHover(object sender, EventArgs e)
        {
            lblCerinta2.Text = "Sa se calculeze cifra de control a unui numar";
            lblCerinta2.Visible = true;
        }

        private void btnPb16_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta2.Visible = false;
        }

        //17
        private void btnPb17_Click(object sender, EventArgs e)
        {
            solutii.soluti17();
        }

        private void btnPb17_MouseHover(object sender, EventArgs e)
        {
            lblCerinta2.Text = "Sa se verifice daca un numar se regaseste in alt numar";
            lblCerinta2.Visible = true;
        }

        private void btnPb17_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta2.Visible = false;
        }

        //18

        private void btnPb18_Click(object sender, EventArgs e)
        {
            solutii.soluti18();
        }

        private void btnPb18_MouseHover(object sender, EventArgs e)
        {
            lblCerinta2.Text = "Sa se permute circular spre stanga cifrele unui numar";
            lblCerinta2.Visible = true;
        }

        private void btnPb18_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta2.Visible = false;
        }

        //19

        private void btnPb19_Click(object sender, EventArgs e)
        {
            solutii.soluti19();
        }

        private void btnPb19_MouseHover(object sender, EventArgs e)
        {
            lblCerinta2.Text = "Sa se permute spre dreapta cifrele unui numar";
            lblCerinta2.Visible = true;
        }

        private void btnPb19_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta2.Visible = false;
        }

        //20

        private void btnPb20_Click(object sender, EventArgs e)
        {
            solutii.soluti20();
        }

        private void btnPb20_MouseHover(object sender, EventArgs e)
        {
            lblCerinta2.Text = "Se citesc numere pana la 0.De cate ori \ns-a repetat o cifra data in acele numere";
            lblCerinta2.Visible = true;
        }

        private void btnPb20_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta2.Visible = false;
        }

        //21

        private void btnPb21_Click(object sender, EventArgs e)
        {
            solutii.soluti21();
        }

        private void btnPb21_MouseHover(object sender, EventArgs e)
        {
            lblCerinta2.Text = "Se citesc numere pana la 0.Sa se adune \nprima cifra a fiecarui numar citit.";
            lblCerinta2.Visible = true;
        }

        private void btnPb21_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta2.Visible = false;
        }
    }
}
