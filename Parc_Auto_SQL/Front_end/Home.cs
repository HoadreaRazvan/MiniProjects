using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Front_end
{
    public class Home : Form
    {
        private Form afisare, adaugare, stergere, modificare;

        public Home()
        {
            this.afisare = new Form();
            this.adaugare = new Form();
            this.stergere = new Form();
            this.modificare = new Form();
            layoutForm();
            layoutButtons();
        }

        public void layoutForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = SystemColors.ControlLightLight;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(350, 200);

            Label t = new Label();
            t.Text = "Parc Auto";
            t.Font = new Font("Calibri", 20, FontStyle.Bold);
            t.Location = new Point(10, 0);
            t.Size = new Size(this.Width, 40);
            t.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(t);

            Button exit = new Button();
            exit.Text = "X";
            exit.Location = new Point(310, 0);
            exit.Size = new Size(30, 30);
            exit.Font = new Font("Calibri", 10, FontStyle.Bold);
            exit.Click += new EventHandler(exit_Click);
            t.Controls.Add(exit);

        }

        public void layoutButtons()
        {
            Button afisare = new Button();
            Button adaugare = new Button();
            Button stergere = new Button();
            Button modificare = new Button();
            afisare.Text = "Afisare";
            adaugare.Text = "Adaugare";
            stergere.Text = "Stergere";
            modificare.Text = "Modificare";


            afisare.Font = new Font("Calibri", 16, FontStyle.Bold);
            adaugare.Font = new Font("Calibri", 16, FontStyle.Bold);
            stergere.Font = new Font("Calibri", 16, FontStyle.Bold);
            modificare.Font = new Font("Calibri", 16, FontStyle.Bold);

            afisare.Location = new Point(20, 70);
            adaugare.Location = new Point(20, 120);
            stergere.Location = new Point(170, 70);
            modificare.Location = new Point(170, 120);

            afisare.Size = new Size(150, 50);
            adaugare.Size = new Size(150, 50);
            stergere.Size = new Size(150, 50);
            modificare.Size = new Size(150, 50);

            afisare.Click += new EventHandler(afisare_Click);
            adaugare.Click += new EventHandler(adaugare_Click);
            stergere.Click += new EventHandler(stergere_Click);
            modificare.Click += new EventHandler(modificare_Click);

            this.Controls.Add(afisare);
            this.Controls.Add(adaugare);
            this.Controls.Add(stergere);
            this.Controls.Add(modificare);
        }

        public void afisare_Click(object sender, EventArgs e)
        {
            Panel form_afisare = new Afisare();
            layoutAfisare(afisare);
            afisare.Controls.Add(form_afisare);
        }
        public void layoutAfisare(Form afisare)
        {
            afisare.StartPosition = FormStartPosition.CenterScreen;
            afisare.BackColor = SystemColors.ControlLightLight;
            afisare.FormBorderStyle = FormBorderStyle.None;
            afisare.Size = new Size(450, 350);

            Button exit = new Button();
            exit.Text = "X";
            exit.Location = new Point(420, 0);
            exit.Size = new Size(30, 30);
            exit.Font = new Font("Calibri", 10, FontStyle.Bold);
            exit.Click += new EventHandler(exitAfisare_Click);
            afisare.Controls.Add(exit);
            afisare.Show();
        }
        public void exitAfisare_Click(object sender, EventArgs e)
        {
            afisare.Hide();
        }


        public void adaugare_Click(object sender, EventArgs e)
        {
            Panel form_adaugare = new Adaugare();
            layoutAdaugare();
            adaugare.Controls.Add(form_adaugare);
        }
        public void layoutAdaugare()
        {
            adaugare.StartPosition = FormStartPosition.CenterScreen;
            adaugare.BackColor = SystemColors.ControlLightLight;
            adaugare.FormBorderStyle = FormBorderStyle.None;
            adaugare.Size = new Size(450, 350);

            Button exit = new Button();
            exit.Text = "X";
            exit.Location = new Point(420, 0);
            exit.Size = new Size(30, 30);
            exit.Font = new Font("Calibri", 10, FontStyle.Bold);
            exit.Click += new EventHandler(exitAdaugare_Click);
            adaugare.Controls.Add(exit);
            adaugare.Show();
        }
        public void exitAdaugare_Click(object sender, EventArgs e)
        {
            adaugare.Hide();
        }



        public void stergere_Click(object sender, EventArgs e)
        {
            Panel form_stergere = new Stergere();
            layoutStergere();
            stergere.Controls.Add(form_stergere);
        }
        public void layoutStergere()
        {
            stergere.StartPosition = FormStartPosition.CenterScreen;
            stergere.BackColor = SystemColors.ControlLightLight;
            stergere.FormBorderStyle = FormBorderStyle.None;
            stergere.Size = new Size(450, 350);

            Button exit = new Button();
            exit.Text = "X";
            exit.Location = new Point(420, 0);
            exit.Size = new Size(30, 30);
            exit.Font = new Font("Calibri", 10, FontStyle.Bold);
            exit.Click += new EventHandler(exitStergere_Click);
            stergere.Controls.Add(exit);
            stergere.Show();
        }
        public void exitStergere_Click(object sender, EventArgs e)
        {
            stergere.Hide();
        }


        public void modificare_Click(object sender, EventArgs e)
        {
            Panel form_modificare = new Modificare();
            layoutModificare();
            modificare.Controls.Add(form_modificare);
        }
        public void layoutModificare()
        {
            modificare.StartPosition = FormStartPosition.CenterScreen;
            modificare.BackColor = SystemColors.ControlLightLight;
            modificare.FormBorderStyle = FormBorderStyle.None;
            modificare.Size = new Size(450, 350);

            Button exit = new Button();
            exit.Text = "X";
            exit.Location = new Point(420, 0);
            exit.Size = new Size(30, 30);
            exit.Font = new Font("Calibri", 10, FontStyle.Bold);
            exit.Click += new EventHandler(exitModificare_Click);
            modificare.Controls.Add(exit);
            modificare.Show();
        }
        public void exitModificare_Click(object sender, EventArgs e)
        {
            modificare.Hide();

        }


        public void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
