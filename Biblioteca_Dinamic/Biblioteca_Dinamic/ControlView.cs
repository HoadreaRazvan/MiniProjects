using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Dinamic
{
    public class ControlView
    {
        private Form forma;
        private Panel aside;
        private Panel header;
        private Panel main;
        private Panel footer;
        private Button afisare;
        private Button adaugare;
        private Button stergere;
        private Button modificare;

        public ControlCarte control;

        public ControlView(Form forma)
        {
            control = new ControlCarte();
            this.forma = forma;

            aside = new Panel();
            main = new Panel();
            footer = new Panel();
            header = new Panel();
            afisare = new Button();
            adaugare = new Button();
            stergere = new Button();
            modificare = new Button();
        }


        //PROPRIETATI

        public Form Forma
        {
            get => this.forma;
            set => this.forma = value;
        }

        public Panel Aside
        {
            get => this.aside;
            set => this.aside = value;
        }

        public Panel Header
        {
            get => this.header;
            set => this.header = value;
        }

        public Panel Main
        {
            get => this.main;
            set => this.main = value;
        }

        public Panel Footer
        {
            get => this.footer;
            set => this.footer = value;
        }

        public Button Afisare
        {
            get => this.afisare;
            set => this.afisare = value;
        }

        public Button Adaugare
        {
            get => this.adaugare;
            set => this.adaugare = value;
        }

        public Button Stergere
        {
            get => this.stergere;
            set => this.stergere = value;
        }

        public Button Modificare
        {
            get => this.modificare;
            set => this.modificare = value;
        }



        public void START()
        {
            layout();
            Functii();
        }

        public void layout()
        {
            header.Location = new Point(12, 12);
            header.Size = new Size(this.forma.Width - 40, this.forma.Height / 5);
            Label t = new Label();
            t.Text = "Biblioteca";
            t.Font = new Font("Calibri", 20, FontStyle.Bold);
            t.Location = new Point(0, 0);
            t.Size = new Size(this.header.Width, this.header.Height);
            t.TextAlign = ContentAlignment.MiddleCenter;
            this.header.BorderStyle = BorderStyle.FixedSingle;
            this.header.Controls.Add(t);
            forma.Controls.Add(header);

            aside.Location = new Point(12, this.forma.Height / 5 + 24);
            aside.Size = new Size(this.forma.Width / 5, this.forma.Height - (this.forma.Height / 5) * 2 - 80);
            this.aside.BorderStyle = BorderStyle.FixedSingle;
            forma.Controls.Add(aside);

            footer.Location = new Point(12, this.forma.Height - this.forma.Height / 3 + 24);
            footer.Size = new Size(this.forma.Width - 40, this.forma.Height / 3 - 72);
            this.footer.BorderStyle = BorderStyle.FixedSingle;
            forma.Controls.Add(footer);

            main.Location = new Point(this.forma.Width / 5 + 24, this.forma.Height / 5 + 24);
            main.Size = new Size(this.forma.Width - 40 - this.forma.Width / 5 - 12, this.forma.Height - 2 * (this.forma.Height / 5) - 80);
            this.main.BorderStyle = BorderStyle.FixedSingle;
            forma.Controls.Add(main);
        }

        public void Functii()
        {
            afisare.Location = new Point(0, 0);
            adaugare.Location = new Point(0, this.aside.Height / 4);
            stergere.Location = new Point(0, this.aside.Height / 4 * 2);
            modificare.Location = new Point(0, this.aside.Height / 4 * 3);

            afisare.Size = new Size(this.aside.Width, this.aside.Height / 4);
            adaugare.Size = new Size(this.aside.Width, this.aside.Height / 4);
            stergere.Size = new Size(this.aside.Width, this.aside.Height / 4);
            modificare.Size = new Size(this.aside.Width, this.aside.Height / 4);

            afisare.Text = "Afisare";
            adaugare.Text = "Adaugare";
            stergere.Text = "Stergere";
            modificare.Text = "Modificare";

            afisare.Font = new Font("Calibri", 16, FontStyle.Bold);
            adaugare.Font = new Font("Calibri", 16, FontStyle.Bold);
            stergere.Font = new Font("Calibri", 16, FontStyle.Bold);
            modificare.Font = new Font("Calibri", 16, FontStyle.Bold);

            afisare.Click += new EventHandler(afisare_click);
            adaugare.Click += new EventHandler(adaugare_click);
            stergere.Click += new EventHandler(stergere_click);
            modificare.Click += new EventHandler(modificare_click);

            this.aside.Controls.Add(afisare);
            this.aside.Controls.Add(adaugare);
            this.aside.Controls.Add(stergere);
            this.aside.Controls.Add(modificare);
        }

        public void info(string text)
        {
            Label infoL = new Label();
            infoL.Text = text;
            infoL.Location = new Point(0, 0);
            infoL.Size = new Size(this.footer.Width, this.footer.Height / 2);
            infoL.Font = new Font("Calibri", 16, FontStyle.Bold);
            infoL.TextAlign = ContentAlignment.MiddleCenter;
            this.footer.Controls.Add(infoL);
        }

        public void clear()
        {
            this.main.Controls.Clear();
            this.footer.Controls.Clear();
        }






        //AFISARE

        public void afisare_click(object sender, EventArgs e)
        {
            clear();
            layoutAfisare();
        }

        public void layoutAfisare()
        {
            info("Acestea sunt cartile!");

            ListView tabel = new ListView();
            creareTabelView(tabel);
            this.main.Controls.Add(tabel);

            Button iesire = new Button();
            creareButonIesire(iesire);
            footer.Controls.Add(iesire);
        }

        public void creareTabelView(ListView tabel)
        {
            tabel.Location = new Point(0, 0);
            tabel.Size = new Size(this.main.Width, this.main.Height);
            tabel.View = View.Details;
            tabel.GridLines = true;
            tabel.BackColor = Color.Gray;
            tabel.Clear();
            tabel.Columns.Add("Titlul", tabel.Width / 5, HorizontalAlignment.Center);
            tabel.Columns.Add("Autor", tabel.Width / 5, HorizontalAlignment.Center);
            tabel.Columns.Add("Pret", tabel.Width / 5 - 1, HorizontalAlignment.Center);
            tabel.Columns.Add("Status", tabel.Width / 5, HorizontalAlignment.Center);
            tabel.Columns.Add("Client", tabel.Width / 5, HorizontalAlignment.Center);
            foreach (Carte carte in control.Carti)
            {
                ListViewItem linie = new ListViewItem();
                linie.Text = carte.Titlul;
                linie.SubItems.Add(carte.Autor);
                linie.SubItems.Add(carte.Pret.ToString());
                linie.SubItems.Add(carte.Status.ToString() == "1" ? "Disponibil" : "Indisponibil");
                linie.SubItems.Add(carte.Client);
                tabel.Items.Add(linie);
            }
        }

        public void creareButonIesire(Button iesire)
        {
            iesire.Location = new Point(footer.Width / 2, footer.Height / 2);
            iesire.Size = new Size(footer.Width / 2, footer.Height / 2);
            iesire.Text = "Iesire";
            iesire.Font = new Font("Calibri", 12, FontStyle.Bold);
            iesire.Click += new EventHandler(iesire_click);
        }

        public void iesire_click(object sender, EventArgs e)
        {
            clear();
        }






        //ADAUGARE

        public void adaugare_click(object sender, EventArgs e)
        {
            clear();
            layoutAdaugare();
        }

        void layoutAdaugare()
        {
            info("Introduceti caracteristicile noii carti. Fara casute libere!");

            Label titlulL = new Label();
            titlulL.Name = "LblTitlul";
            TextBox titlulT= new TextBox();
            titlulT.Name = "TxtTitlul";
            OpTitlul(titlulL, titlulT);
            this.main.Controls.Add(titlulL);
            this.main.Controls.Add(titlulT);


            Label autorL= new Label();
            autorL.Name = "LblAutor";
            TextBox autorT = new TextBox();
            autorT.Name = "TxtAutor";
            OpAutor(autorL, autorT);
            this.main.Controls.Add(autorL);
            this.main.Controls.Add(autorT);


            Label pretL = new Label();
            pretL.Name = "LblPret";
            TextBox pretT = new TextBox();
            pretT.Name = "TxtPret";
            OpPret(pretL, pretT);
            this.main.Controls.Add(pretL);
            this.main.Controls.Add(pretT);


            Button iesire = new Button();
            creareButonIesire(iesire);
            this.footer.Controls.Add(iesire);

            Button trimitere = new Button();
            trimitere.Name = "BtnTrimitereA";
            creareButonTrimitereA(trimitere);
            footer.Controls.Add(trimitere);
        }

        public void trimitereAdaugare_Click(object sender, EventArgs e)
        {
            adauga();
        }

        public void adauga()
        {
            TextBox titlul = null;
            TextBox autor = null;
            TextBox pret = null;

            foreach (Control control in this.main.Controls) 
            {
                if (control.Name.Equals("TxtTitlul") == true)
                {
                    titlul = control as TextBox;
                }
                else
                    if (control.Name.Equals("TxtAutor") == true)
                    {
                        autor = control as TextBox;
                    }
                    else
                        if (control.Name.Equals("TxtPret") == true)
                        {
                            pret = control as TextBox;
                        }
            }

            if (titlul.Text.Equals("") == false && autor.Text.Equals("") == false && pret.Text.Equals("") == false)
            {
                control.adaugare(titlul.Text, autor.Text, int.Parse(pret.Text));
                titlul.Text = "";
                autor.Text = "";
                pret.Text = "";
                MessageBox.Show("Adaugat cu SUCCES!");
            }
            else
                MessageBox.Show("Nu se poate adauga!");
        }

        public void creareButonTrimitereA(Button trimitere)
        {
            trimitere.Text = "Adaugati";
            trimitere.Location = new Point(0, footer.Height / 2);
            trimitere.Size = new Size(this.footer.Width / 2, this.footer.Height / 2);
            trimitere.Font = new Font("Calibri", 12, FontStyle.Bold);
            trimitere.Click += new EventHandler(trimitereAdaugare_Click);
        }

        public void OpTitlul(Label titlulL,TextBox titlulT)
        {      
            titlulL.Text = "Titlul";
            titlulL.Font = new Font("Calibri", 16, FontStyle.Bold);
            titlulL.Location = new Point(this.main.Width / 2 - 160, 70);
            titlulL.Size = new Size(150, 30);
            titlulL.TextAlign = ContentAlignment.MiddleRight;

            titlulT.Font = new Font("Calibri", 12, FontStyle.Bold);
            titlulT.Location = new Point(this.main.Width / 2, 70);
            titlulT.Size = new Size(150, 30);
        }

        public void OpAutor(Label autorL,TextBox autorT)
        {
            autorL.Text = "Autor";
            autorL.Font = new Font("Calibri", 16, FontStyle.Bold);
            autorT.Font = new Font("Calibri", 12, FontStyle.Bold);
            autorL.Location = new Point(this.main.Width / 2 - 160, 110);
            autorL.Size = new Size(150, 30);
            autorL.TextAlign = ContentAlignment.MiddleRight;
            autorT.Location = new Point(this.main.Width / 2, 110);
            autorT.Size = new Size(150, 30);
        }

        public void OpPret(Label pretL,TextBox pretT)
        {
            pretL.Text = "Pret";
            pretL.Font = new Font("Calibri", 16, FontStyle.Bold);
            pretT.Font = new Font("Calibri", 12, FontStyle.Bold);
            pretL.Location = new Point(this.main.Width / 2 - 160, 150);
            pretL.Size = new Size(150, 30);
            pretL.TextAlign = ContentAlignment.MiddleRight;
            pretT.Location = new Point(this.main.Width / 2, 150);
            pretT.Size = new Size(150, 30);
        }






        //STERGERE

        public void stergere_click(object sender, EventArgs e)
        {
            clear();
            layoutStergere();
        }

        public void layoutStergere()
        {
            info("Stergeti cartea dupa titlu'!");
            Label titlulL = new Label();
            TextBox titlulT = new TextBox();
            titlulT.Name = "TxtTitlul";
            OpTitlul(titlulL, titlulT);
            this.main.Controls.Add(titlulL);
            this.main.Controls.Add(titlulT);

            Button iesire = new Button();
            creareButonIesire(iesire);
            this.footer.Controls.Add(iesire);


            Button trimitere = new Button();
            trimitere.Name = "BtnTrimitereS";
            creareButonTrimitereS(trimitere);
            footer.Controls.Add(trimitere);
        }

        public void creareButonTrimitereS(Button trimitere)
        {
            trimitere.Text = "Stergeti";
            trimitere.Location = new Point(0, footer.Height / 2);
            trimitere.Size = new Size(this.footer.Width / 2, this.footer.Height / 2);
            trimitere.Font = new Font("Calibri", 12, FontStyle.Bold);
            trimitere.Click += new EventHandler(trimitereStergere_Click);        
        }

        public void trimitereStergere_Click(object sender, EventArgs e)
        {
            sterge();
        }

        public void sterge()
        {
            TextBox titlul = null;

            foreach (Control control in this.main.Controls)
            {
                if (control.Name.Equals("TxtTitlul") == true)
                {
                    titlul = control as TextBox;
                }
            }

            if (titlul.Text.Equals("") == false && control.pozCarte(titlul.Text)!=-1)
            {
                control.stergere(titlul.Text);
                titlul.Text = "";               
                MessageBox.Show("Sters cu SUCCES!");
            }
            else
                MessageBox.Show("Nu se poate sterge!");
        }






        //MODIFICARE

        public void modificare_click(object sender, EventArgs e)
        {
            clear();
            layoutModificare();
        }

        public void layoutModificare()
        {
            info("Modificati cartea. Daca lasati casuta libera atunci nu ii modificati caracteristica respectiva!");

            Label titlulLC = new Label();
            titlulLC.Name = "LblTitlulC";
            TextBox titlulTC = new TextBox();
            titlulTC.Name = "TxtTitlulC";
            OpTitlulMC(titlulLC, titlulTC);
            this.main.Controls.Add(titlulLC);
            this.main.Controls.Add(titlulTC);

            Label titlulL = new Label();
            titlulL.Name = "LblTitlul";
            TextBox titlulT = new TextBox();
            titlulT.Name = "TxtTitlul";
            OpTitlulM(titlulL, titlulT);
            this.main.Controls.Add(titlulL);
            this.main.Controls.Add(titlulT);

            Label autorL = new Label();
            autorL.Name = "LblAutor";
            TextBox autorT = new TextBox();
            autorT.Name = "TxtAutor";
            OpAutorM(autorL, autorT);
            this.main.Controls.Add(autorL);
            this.main.Controls.Add(autorT);

            Label pretL = new Label();
            pretL.Name = "LblPret";
            TextBox pretT = new TextBox();
            pretT.Name = "TxtPret";
            OpPretM(pretL, pretT);
            this.main.Controls.Add(pretL);
            this.main.Controls.Add(pretT);


            Button iesire = new Button();
            creareButonIesire(iesire);
            this.footer.Controls.Add(iesire);

            Button trimitere = new Button();
            trimitere.Name = "BtnTrimitereA";
            creareButonTrimitereM(trimitere);
            footer.Controls.Add(trimitere);
        }

        public void creareButonTrimitereM(Button trimitere)
        {
            trimitere.Text = "Modificati";
            trimitere.Location = new Point(0, footer.Height / 2);
            trimitere.Size = new Size(this.footer.Width / 2, this.footer.Height / 2);
            trimitere.Font = new Font("Calibri", 12, FontStyle.Bold);
            trimitere.Click += new EventHandler(trimitereModificare_Click);
        }

        public void trimitereModificare_Click(object sender, EventArgs e)
        {           
           modifica();
        }

        public void modifica()
        {
            TextBox titlulC = null;
            TextBox titlul = null;
            TextBox autor = null;
            TextBox pret = null;

            foreach (Control control in this.main.Controls)
            {
                if (control.Name.Equals("TxtTitlul") == true)
                {
                    titlul = control as TextBox;
                }
                else
                    if (control.Name.Equals("TxtTitlulC") == true)
                    {
                        titlulC = control as TextBox;
                    }
                    else
                        if (control.Name.Equals("TxtAutor") == true)
                        {
                            autor = control as TextBox;
                        }
                        else
                            if (control.Name.Equals("TxtPret") == true)
                            {
                                pret = control as TextBox;
                            }
            }


            if (control.pozCarte(titlulC.Text) != -1)
            {
                control.modificare(titlul.Text, autor.Text, pret.Text, titlulC.Text);
                MessageBox.Show("Modificat cu SUCCES!");
                titlulC.Text = "";
                titlul.Text = "";
                autor.Text = "";
                pret.Text = "";
            }
            else
                MessageBox.Show("Nu se poate modifica");
        }

        public void OpTitlulMC(Label titlulL, TextBox titlulT)
        {
            titlulL.Text = "Titlul Cautat";
            titlulL.Font = new Font("Calibri", 16, FontStyle.Bold);
            titlulL.Location = new Point(this.main.Width / 2 - 160, 30);
            titlulL.Size = new Size(150, 30);
            titlulL.TextAlign = ContentAlignment.MiddleRight;
            titlulT.Font = new Font("Calibri", 12, FontStyle.Bold);
            titlulT.Location = new Point(this.main.Width / 2, 30);
            titlulT.Size = new Size(150, 30);
        }

        public void OpTitlulM(Label titlulL, TextBox titlulT)
        {
            titlulL.Text = "Noul Titlul";
            titlulL.Font = new Font("Calibri", 16, FontStyle.Bold);
            titlulL.Location = new Point(this.main.Width / 2 - 160, 70);
            titlulL.Size = new Size(150, 30);
            titlulL.TextAlign = ContentAlignment.MiddleRight;
            titlulT.Font = new Font("Calibri", 12, FontStyle.Bold);
            titlulT.Location = new Point(this.main.Width / 2, 70);
            titlulT.Size = new Size(150, 30);
        }

        public void OpAutorM(Label autorL, TextBox autorT)
        {
            autorL.Text = "Noul Autor";
            autorL.Font = new Font("Calibri", 16, FontStyle.Bold);
            autorT.Font = new Font("Calibri", 12, FontStyle.Bold);
            autorL.Location = new Point(this.main.Width / 2 - 160, 110);
            autorL.Size = new Size(150, 30);
            autorL.TextAlign = ContentAlignment.MiddleRight;
            autorT.Location = new Point(this.main.Width / 2, 110);
            autorT.Size = new Size(150, 30);
        }

        public void OpPretM(Label pretL, TextBox pretT)
        {
            pretL.Text = "Noul Pret";
            pretL.Font = new Font("Calibri", 16, FontStyle.Bold);
            pretT.Font = new Font("Calibri", 12, FontStyle.Bold);
            pretL.Location = new Point(this.main.Width / 2 - 160, 150);
            pretL.Size = new Size(150, 30);
            pretL.TextAlign = ContentAlignment.MiddleRight;
            pretT.Location = new Point(this.main.Width / 2, 150);
            pretT.Size = new Size(150, 30);
        }



    }
}
