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
    public partial class FrmProblema : Form
    {
        private Solutii solutii = new Solutii();
        public FrmProblema()
        {
            InitializeComponent();
        }

        //1

        private void btnPb1_MouseHover(object sender, EventArgs e)//trec cu mouse-ul peste buton
        {
            lblCerinta.Text = "Se introduce un numar .Se afiseaza numarulk de cifre";

            lblCerinta.Visible = true;
        }

        private void btnPb1_MouseLeave(object sender, EventArgs e)//parasesc butonul cu mouse-ul (fara sa apas pe el)
        {
            lblCerinta.Visible = false;
        }

        private void btnPb1_Click(object sender, EventArgs e)//Functie care apasa butonul
        {

            solutii.soluti1();
        }

        //2

        private void btnPb2_Click(object sender, EventArgs e)
        {
            solutii.soluti2();
        }

        private void btnPb2_MouseHover(object sender, EventArgs e)
        {
            lblCerinta.Text = "Se introduce doua numere. Sa se verifice \n daca numarul 2 este inclus in numarul 1";

            lblCerinta.Visible = true;
        }

        private void btnPb2_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta.Visible = false;
        }

        //3

        private void btnPb3_Click_1(object sender, EventArgs e)
        {
            solutii.soluti3();
        }

        private void btnPb3_MouseHover(object sender, EventArgs e)
        {
            lblCerinta.Text = "Se introduce un numer. Sa se verifice \n daca numarul are cifrele identice";
            lblCerinta.Visible = true;
        }

        private void btnPb3_MouseLeave_1(object sender, EventArgs e)
        {
            lblCerinta.Visible = false;
        }

        //4

        private void btnPb4_MouseHover(object sender, EventArgs e)
        {
            lblCerinta.Text = "Se introduce un numer. Sa se afiseze \n maximul si minimul din numar";
            lblCerinta.Visible = true;
        }

        private void btnPb4_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta.Visible = false;
        }

        private void btnPb4_Click(object sender, EventArgs e)
        {
            solutii.soluti4();
        }

        //5
            
        private void bntPb5_Click(object sender, EventArgs e)
        {
            solutii.soluti5();
        }

        private void bntPb5_MouseHover(object sender, EventArgs e)
        {
            lblCerinta.Text = "Se introduce un numer. Sa se afiseze \n maximul si minimul par din numar";
            lblCerinta.Visible = true;
        }

        private void bntPb5_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta.Visible = false;
        }

        //6
        private void btnPb6_Click(object sender, EventArgs e)
        {
            solutii.soluti6();
        }

        private void btnPb6_MouseHover(object sender, EventArgs e)
        {
            lblCerinta.Text="Sa se afiseze toate sufixele unui numar";
            lblCerinta.Visible = true;
  
        }

        private void btnPb6_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta.Visible = false;
        }

        //7

        private void btnPb7_Click(object sender, EventArgs e)
        {
            solutii.soluti7();
        }

        private void btnPb7_MouseHover(object sender, EventArgs e)
        {
            lblCerinta.Text = "Sa se afiseze prefixele unui numar";
            lblCerinta.Visible = true;
        }

        private void btnPb7_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta.Visible = false;
        }

        //8

        private void btnPb8_Click(object sender, EventArgs e)
        {
            solutii.soluti8();
        }

        private void btnPb8_MouseHover(object sender, EventArgs e)
        {
            lblCerinta.Text = "Sa se afiseze cifra de rang k";
            lblCerinta.Visible = true;
        }

        private void btnPb8_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta.Visible = false;
        }

        //9

        private void btnPb9_Click(object sender, EventArgs e)
        {
            solutii.soluti9();
        }

        private void btnPb9_MouseHover(object sender, EventArgs e)
        {
            lblCerinta.Text = "Sa se elimine cifra de rang k";
            lblCerinta.Visible = true;
        }

        private void btnPb9_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta.Visible = false;
        }

        private void btnPb10_Click(object sender, EventArgs e)
        {
            solutii.soluti10();
        }

        private void btnPb10_MouseHover(object sender, EventArgs e)
        {
            lblCerinta.Text = "Sa se elimine ultima si prima cifra a numarului";
            lblCerinta.Visible = true;
        }

        private void btnPb10_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta.Visible = false;
        }

        private void btnPb11_Click(object sender, EventArgs e)
        {
            solutii.soluti11();
        }

        private void btnPb11_MouseHover(object sender, EventArgs e)
        {
            lblCerinta.Text = "Sa se verifice daca un numar este palindrom";
            lblCerinta.Visible = true;
        }

        private void btnPb11_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta.Visible = false;
        }

        private void btnPb12_Click(object sender, EventArgs e)
        {
            solutii.soluti12();
        }

        private void btnPb12_MouseHover(object sender, EventArgs e)
        {
            lblCerinta.Text = "Sa se verifice daca cifrele unui numar sunt in ordine crescatoare";
            lblCerinta.Visible = true;
        }

        private void btnPb12_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta.Visible = true;
        }

        private void btnPb13_Click(object sender, EventArgs e)
        {
            solutii.soluti13();
        }

        private void btnPb13_MouseHover(object sender, EventArgs e)
        {
            lblCerinta.Text = "Sa se verifice daca un numar are cifrele in ordine descrescatoare";
            lblCerinta.Visible = true;
        }

        private void btnPb13_MouseLeave(object sender, EventArgs e)
        {
            lblCerinta.Visible = false;
        }
    }

}
