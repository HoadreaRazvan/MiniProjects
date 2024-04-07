using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Curse_TIR
{
    public class ControlView
    {
        private Form forma;
        private ControlCursa control;
        private Panel header;
        private Panel aside;
        private Panel main;
        private Panel footer;
        private Button afisare;
        private Button adaugare;
        private Button stergere;
        private Button modificare;
        private Button inchiriere;
        private Button returnare;
        private Button filtrare;

        public ControlView(Form forma)
        {
            this.forma = forma;
            this.control = new ControlCursa();
            this.header = new Panel();
            this.aside = new Panel();
            this.main = new Panel();
            this.footer = new Panel();
            this.afisare = new Button();
            this.adaugare = new Button();
            this.stergere = new Button();
            this.modificare = new Button();
            this.inchiriere = new Button();
            this.returnare = new Button();
            this.filtrare = new Button();
        }


        public void start()
        {
            decor();
            layoutPanel();
            functii();
        }

        public void decor()
        {
            this.forma.MaximumSize = new Size(1000, 600);
            this.forma.MinimumSize = new Size(1000, 600);
            this.forma.BackColor = Color.DarkGray;
            this.main.BackColor = Color.White;
            this.aside.BackColor = Color.White;
            this.forma.Text = "By HoadreaR S&E";
        }

        public void clear()
        {
            this.main.Controls.Clear();
            this.footer.Controls.Clear();
        }

        public void layoutPanel()
        {
            this.header.Location = new Point(10, 10);
            this.aside.Location = new Point(10, this.forma.Height / 6 + 20);
            this.main.Location = new Point(this.forma.Height / 3 + 20, this.forma.Height / 6 + 20);
            this.footer.Location = new Point(this.forma.Height / 3 + 20, this.forma.Height / 6 * 4 + 50);

            this.header.Size = new Size(this.forma.Width - 35, this.forma.Height / 6);
            this.aside.Size = new Size(this.forma.Height / 3, this.forma.Height - 80 - this.forma.Height / 6 * 2);
            this.main.Size = new Size(this.forma.Width - 45 - this.forma.Height / 3, this.forma.Height - 80 - this.forma.Height / 6 * 2);
            this.footer.Size = new Size(this.forma.Width - 45 - this.forma.Height / 3, this.forma.Height / 6);

            forma.Controls.Add(this.header);
            forma.Controls.Add(this.aside);
            forma.Controls.Add(this.main);
            forma.Controls.Add(this.footer);

            Label t = new Label();
            t.Text = "Curse TIR";
            t.Font = new Font("Calibri", 20, FontStyle.Bold);
            t.Location = new Point(0, 0);
            t.Size = new Size(this.header.Width, this.header.Height);
            t.TextAlign = ContentAlignment.MiddleCenter;
            this.header.Controls.Add(t);
        }

        public void functii()
        {
            this.afisare.Text = "Afisare";
            this.adaugare.Text = "Adaugare";
            this.stergere.Text = "Stergere";
            this.modificare.Text = "Modificare";
            this.inchiriere.Text = "Incepe cursa";
            this.returnare.Text = "Renuntare cursa";
            this.filtrare.Text = "Filtrare";

            this.afisare.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.adaugare.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.stergere.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.modificare.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.inchiriere.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.returnare.Font = new Font("Calibri", 16, FontStyle.Bold);
            this.filtrare.Font = new Font("Calibri", 16, FontStyle.Bold);

            this.afisare.Location = new Point(0, 0);
            this.adaugare.Location = new Point(0, this.aside.Height / 7);
            this.stergere.Location = new Point(0, this.aside.Height / 7 * 2);
            this.modificare.Location = new Point(0, this.aside.Height / 7 * 3);
            this.inchiriere.Location = new Point(0, this.aside.Height / 7 * 4);
            this.returnare.Location = new Point(0, this.aside.Height / 7 * 5);
            this.filtrare.Location = new Point(0, this.aside.Height / 7 * 6);

            this.afisare.Size = new Size(this.aside.Width, this.aside.Height / 7);
            this.adaugare.Size = new Size(this.aside.Width, this.aside.Height / 7);
            this.stergere.Size = new Size(this.aside.Width, this.aside.Height / 7);
            this.modificare.Size = new Size(this.aside.Width, this.aside.Height / 7);
            this.inchiriere.Size = new Size(this.aside.Width, this.aside.Height / 7);
            this.returnare.Size = new Size(this.aside.Width, this.aside.Height / 7);
            this.filtrare.Size = new Size(this.aside.Width, this.aside.Height / 7);

            this.afisare.Click += new EventHandler(afisare_Click);
            this.adaugare.Click += new EventHandler(adaugare_Click);
            this.stergere.Click += new EventHandler(stergere_Click);
            this.modificare.Click += new EventHandler(modificare_Click);
            this.inchiriere.Click += new EventHandler(inchiriere_Click);
            this.returnare.Click += new EventHandler(returnare_Click);
            this.filtrare.Click += new EventHandler(filtrare_Click);

            this.aside.Controls.Add(this.afisare);
            this.aside.Controls.Add(this.adaugare);
            this.aside.Controls.Add(this.stergere);
            this.aside.Controls.Add(this.modificare);
            this.aside.Controls.Add(this.inchiriere);
            this.aside.Controls.Add(this.returnare);
            this.aside.Controls.Add(this.filtrare);
        }

        //AFISARE
        public void afisare_Click(object sender, EventArgs e)
        {
            ControlAfisare a = new ControlAfisare(main, footer, control);
            a.start(); 
        }

        //ADAUGARE
        public void adaugare_Click(object sender, EventArgs e)
        {
            ControlAdaugare a = new ControlAdaugare(main,footer,control);
            a.start();
        }

        //STERGERE
        public void stergere_Click(object sender, EventArgs e)
        {
            ControlStergere a = new ControlStergere(main, footer, control);
            a.start();
        }

        //MODIFICARE
        public void modificare_Click(object sender, EventArgs e)
        {
            ControlModificare a = new ControlModificare(main, footer, control);
            a.start();
        }

        //INCHIRIERE
        public void inchiriere_Click(object sender, EventArgs e)
        {
            ControlInchiriere a = new ControlInchiriere(main, footer, control);
            a.start();
        }

        //RETURNARE
        public void returnare_Click(object sender, EventArgs e)
        {
            ControlReturnare a = new ControlReturnare(main, footer, control);
            a.start();
        }

        //FILTRARE
        public void filtrare_Click(object sender, EventArgs e)
        {
            ControlFiltrare a = new ControlFiltrare(main, footer, control);
            a.start();
        }

    }
}
