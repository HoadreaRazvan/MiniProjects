using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InvadersVSTowers
{
    public class ControlView
    {
        private Form forma;
        static public int pozitie=0;
        static public ControlViewInitiere c;

        public ControlView(Form forma)
        {
            this.forma = forma;
            c = new ControlViewInitiere(this.forma);
        }

        public void start()
        {
            pozitie = 0;
            layoutForma();
            layoutControale();
            images(450,5);
        }
        public void layoutForma()
        {
            this.forma.MinimumSize = new Size(500, 700);
            this.forma.MaximumSize = new Size(500, 700);
            this.forma.Location = new Point(400, 35);
            this.forma.FormBorderStyle = FormBorderStyle.None;
        }
        
        public void layoutControale()
        {
            Button invader= new Button();
            layoutInvader(invader);
            this.forma.Controls.Add(invader);

            Button turn= new Button();
            layoutTurn(turn);
            this.forma.Controls.Add(turn);

            Button zid= new Button();
            layoutZid(zid);
            this.forma.Controls.Add(zid);

            Button stop= new Button();
            layoutStop(stop);
            this.forma.Controls.Add(stop);

            Button stergere = new Button();
            layoutStergere(stergere);
            this.forma.Controls.Add(stergere);

            Button trimitere= new Button();
            layoutTrimitere(trimitere);
            this.forma.Controls.Add(trimitere);

            Button iesire = new Button();
            layoutIesire(iesire);
            this.forma.Controls.Add(iesire);

            Label titlul = new Label();
            layoutTitlul(titlul);
            this.forma.Controls.Add(titlul);
        }

        public void images(int x,int a)
        {
            PictureBox p1 = new PictureBox();
            PictureBox p2 = new PictureBox();
            p1.Name = "p1";
            p2.Name = "p2";
            p1.Location = new Point(50,x);
            p2.Location = new Point(400,x);
            p1.Size = new Size(50,50);
            p2.Size = new Size(50,50);
            string path="";
            if (a == 1) path = Application.StartupPath + @"\invaderPNG.png";
            if (a == 2) path = Application.StartupPath + @"\towerPNG.png";
            if (a == 3) path = Application.StartupPath + @"\wallPNG.png";
            if (a == 4) path = Application.StartupPath + @"\finishPNG.png";
            if (a == 5) path = Application.StartupPath + @"\stergerePNG.png";
            Image im = Image.FromFile(path);
            p1.BackColor = Color.Transparent;
            p2.BackColor = Color.Transparent;
            p1.SizeMode = PictureBoxSizeMode.StretchImage;
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            p1.Image = im;
            p2.Image = im;
            this.forma.Controls.Add(p1);
            this.forma.Controls.Add(p2);
        }

        public void stergereImages()
        {
            PictureBox p1 = null;
            PictureBox p2 = null;
            foreach(Control c in this.forma.Controls)
                if (c.Name == "p1")
                    p1 = c as PictureBox;
                else if (c.Name == "p2") 
                    p2 = c as PictureBox;
            this.forma.Controls.Remove(p1);
            this.forma.Controls.Remove(p2);
        }

        public void layoutIesire(Button iesire)
        {
            iesire.Location = new Point(this.forma.Width - 30, 0);
            iesire.Size = new Size(30, 30);
            iesire.Text = "X";
            iesire.Font = new Font("Calibri", 12, FontStyle.Bold);
            iesire.Click += new EventHandler(iesire_Click);
        }

        public void iesire_Click(object sender, EventArgs e)
        {
            this.forma.Close();
            Application.Exit();
        }



        public void layoutTitlul(Label titlul)
        {
            titlul.Location = new Point(50, 0);
            titlul.Size = new Size(this.forma.Width - 100, 200);
            titlul.Font = new Font("Calibri", 25, FontStyle.Bold | FontStyle.Italic);
            titlul.TextAlign = ContentAlignment.MiddleCenter;
            titlul.BackColor = Color.Transparent;
            titlul.Text = "Alegeti o Plasabila";
        }

        public void layoutInvader(Button invader)
        {
            invader.Location = new Point(this.forma.Width / 2 - 100, 210);
            invader.Size = new Size(200, 50);
            invader.Font = new Font("Calibri", 15, FontStyle.Bold | FontStyle.Italic);
            invader.Text = "Invader";
            invader.Click += new EventHandler(invader_Click);
        }

        public void layoutTurn(Button turn)
        {
            turn.Location = new Point(this.forma.Width / 2 - 100, 270);
            turn.Size = new Size(200, 50);
            turn.Text = "Turn";
            turn.Font = new Font("Calibri", 15, FontStyle.Bold | FontStyle.Italic);
            turn.Click += new EventHandler(turn_Click);
        }

        public void layoutZid(Button zid)
        {
            zid.Location = new Point(this.forma.Width / 2 - 100, 330);
            zid.Size = new Size(200, 50);
            zid.Text = "Zid";
            zid.Font = new Font("Calibri", 15, FontStyle.Bold | FontStyle.Italic);
            zid.Click += new EventHandler(zid_Click);
        }

        public void layoutStop(Button stop)
        {
            stop.Location = new Point(this.forma.Width / 2 - 100, 390);
            stop.Size = new Size(200, 50);
            stop.Text = "Final";
            stop.Font = new Font("Calibri", 15, FontStyle.Bold | FontStyle.Italic);
            stop.Click += new EventHandler(stop_Click);
        }

        public void layoutStergere(Button stergere)
        {
            stergere.Location = new Point(this.forma.Width/2-100, 450);
            stergere.Size = new Size(200, 50);
            stergere.Font = new Font("Calibri", 15, FontStyle.Bold | FontStyle.Italic);
            stergere.Text = "Stergere";
            stergere.Click += new EventHandler(stergere_Click);
        }

        public void layoutTrimitere(Button trimitere)
        {
            trimitere.Location = new Point(this.forma.Width / 2 - 100, 600);
            trimitere.Size = new Size(200, 50);
            trimitere.Font = new Font("Calibri", 15, FontStyle.Bold | FontStyle.Italic);
            trimitere.Text = "Trimitere";
            trimitere.Click += new EventHandler(trimitere_Click);
        }

        public void invader_Click(object sender, EventArgs e)
        {
            stergereImages();
            images(210,1);
            pozitie = 2;
        }

        public void turn_Click(object sender, EventArgs e)
        {
            stergereImages();
            images(270,2);
            pozitie = 3;
        }

        public void zid_Click(object sender, EventArgs e)
        {
            stergereImages();
            images(330,3);
            pozitie = 1;
        }

        public void stop_Click(object sender, EventArgs e)
        {
            stergereImages();
            images(390,4);
            pozitie = 4;
        }

        public void stergere_Click(object sender, EventArgs e)
        {
            stergereImages();
            images(450,5);
            pozitie = 0;
        }

        public void trimitere_Click(object sender, EventArgs e)
        {
            this.forma.Controls.Clear();
            c.start();
        }

        public int Pozitie
        {
            get => pozitie;
            set => pozitie = value;
        }
    }
}
