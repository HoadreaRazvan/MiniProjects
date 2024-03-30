using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InvadersVSTowers
{
    public class ControlViewInitiere
    {
        private Form forma;
        private Panel header, aside, main;
        private int[] vec = new int[100];
        private int ct = 0;
        static public Harta map = new Harta();
        static public myPictureBox[,] selectie = new myPictureBox[100, 100];

        public ControlViewInitiere(Form forma)
        {
            this.forma = forma;
            this.header = new Panel();
            this.aside = new Panel();
            this.main = new Panel();
            this.forma.KeyPress += new KeyPressEventHandler(Setari_KeyPress);
        }

        private void Setari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.forma.Controls.Clear();
                ControlView c = new ControlView(this.forma);
                c.start();
            }
        }

        public void start()
        {
            layoutForma();
            layoutPanel();
            layoutMain();
            layoutControale();
        }

        public void layoutControale()
        {
            Button trimitere = new Button();
            layoutTrimitere(trimitere);
            this.aside.Controls.Add(trimitere);

            Label info = new Label();
            layoutInfo(info);
            this.aside.Controls.Add(info);

            Label titlul = new Label();
            layoutTitlul(titlul);
            this.header.Controls.Add(titlul);

            Button iesire = new Button();
            layoutIesire(iesire);
            this.aside.Controls.Add(iesire);
        }

        public void layoutTitlul(Label info)
        {
            info.Location = new Point(0, 0);
            info.Size = new Size(this.header.Width, this.header.Height);
            info.Font = new Font("Calibri", 20, FontStyle.Bold | FontStyle.Italic);
            info.TextAlign = ContentAlignment.MiddleCenter;
            info.BackColor = Color.Transparent;
            info.Text = "Invaders VS Towers";
        }

        public void layoutIesire(Button iesire)
        {
            iesire.Location = new Point(this.aside.Width - 30, 0);
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

        public void layoutTrimitere(Button trimitere)
        {
            trimitere.Location = new Point(this.aside.Width / 2 - 100, this.aside.Height - 70);
            trimitere.Size = new Size(200, 50);
            trimitere.Font = new Font("Calibri", 15, FontStyle.Bold | FontStyle.Italic);
            trimitere.Text = "Trimitere";
            trimitere.Click += new EventHandler(trimitere_Click);
        }

        public void layoutInfo(Label info)
        {
            info.Location = new Point(0, 30);
            info.Size = new Size(this.aside.Width, this.aside.Height - 150);
            info.Font = new Font("Calibri", 15, FontStyle.Bold | FontStyle.Italic);
            info.TextAlign = ContentAlignment.MiddleCenter;
            info.BackColor = Color.Transparent;
            info.Text = "Alegeti locul plasabilei alese\nApasati 'Escape' pentru a reveni inapoi la meniul de plasabile\nApasati 'Trimitere pentru a incepe joaca";
        }

        public void trimitere_Click(object sender, EventArgs e)
        {
            this.forma.Controls.Clear();
            this.forma.Hide();
            ControlViewJoc c = new ControlViewJoc(this.forma);
            c.start();
        }

        public void layoutForma()
        {
            this.forma.MinimumSize = new Size(1300, 717);
            this.forma.MaximumSize = new Size(1300, 717);
            this.forma.Location = new Point(35, 35);
            this.forma.FormBorderStyle = FormBorderStyle.None;
        }

        public void layoutPanel()//aaaaaaaaa
        {
            this.header.Location = new Point(this.forma.Height - 20 + 40 * 8 + 20 - 17, 10);
            this.aside.Location = new Point(this.forma.Height - 20 + 40 * 8 + 20 - 17, 170);
            this.main.Location = new Point(10, 10);
            this.header.Size = new Size(this.forma.Width - (this.forma.Height - 20 + 40 * 8 + 30) + 17, 150);
            this.aside.Size = new Size(this.forma.Width - (this.forma.Height - 20 + 40 * 8 + 30) + 17, this.forma.Height - 180);
            this.main.Size = new Size(this.forma.Height - 20 + 40 * 8 - 17, this.forma.Height - 20);
            this.header.BorderStyle = BorderStyle.FixedSingle;
            this.aside.BorderStyle = BorderStyle.FixedSingle;
            this.main.BorderStyle = BorderStyle.FixedSingle;
            this.forma.Controls.Add(header);
            this.forma.Controls.Add(aside);
            this.forma.Controls.Add(main);
        }

        public void layoutMain()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    selectie[i, j] = new myPictureBox();
                    selectie[i, j].Location = new Point(i * 100, j * 100);
                    selectie[i, j].Size = new Size(95, 95);
                    selectie[i, j].Click += new EventHandler(selectie_Click);
                    selectie[i, j].BackColor = Color.Transparent;
                    selectie[i, j].X = j;
                    selectie[i, j].Y = i;
                    if (map.retValue(j, i) == 0)
                        selectie[i, j].BackColor = Color.White;
                    else
                    {
                        string path = "";
                        if (map.retValue(j, i) == 1)
                            path = Application.StartupPath + @"\wallPNG.png";
                        if (map.retValue(j, i) == 2)
                            path = Application.StartupPath + @"\invaderPNG.png";
                        if (map.retValue(j, i) == 3)
                        {
                            path = Application.StartupPath + @"\towerPNG.png";
                            vec[ct++] = i * 10 + j;
                        }
                        if (map.retValue(j, i) == 4)
                            path = Application.StartupPath + @"\finishPNG.png";
                        Image im = Image.FromFile(path);
                        selectie[i, j].Image = im;
                        selectie[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    this.main.Controls.Add(selectie[i, j]);
                }
            }
        }

        public void selectie_Click(object sender, EventArgs e)
        {
            myPictureBox picture = sender as myPictureBox;
            if (ControlView.pozitie == 1 && map.retValue(picture.X, picture.Y) == 0)
            {
                map.setValue(picture.X, picture.Y, 1);
                string path = Application.StartupPath + @"\wallPNG.png";
                Image im = Image.FromFile(path);
                selectie[picture.Y, picture.X].Image = im;
                selectie[picture.Y, picture.X].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (ControlView.pozitie == 2 && map.retValue(picture.X, picture.Y) == 0)
            {
                map.setValue(picture.X, picture.Y, 2);
                string path = Application.StartupPath + @"\invaderPNG.png";
                Image im = Image.FromFile(path);
                selectie[picture.Y, picture.X].Image = im;
                selectie[picture.Y, picture.X].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (picture.X - 1 >= 0 && picture.Y - 1 >= 0 && picture.X + 1 < 7 && picture.Y + 1 < 10 && ControlView.pozitie == 3 && map.retValue(picture.X, picture.Y) == 0)
            {
                map.setValue(picture.X, picture.Y, 3);
                string path = Application.StartupPath + @"\towerPNG.png";
                Image im = Image.FromFile(path);
                selectie[picture.Y, picture.X].Image = im;
                selectie[picture.Y, picture.X].SizeMode = PictureBoxSizeMode.StretchImage;

            }
            if (ControlView.pozitie == 4 && map.retValue(picture.X, picture.Y) == 0)
            {
                map.setValue(picture.X, picture.Y, 4);
                string path = Application.StartupPath + @"\finishPNG.png";
                Image im = Image.FromFile(path);
                selectie[picture.Y, picture.X].Image = im;
                selectie[picture.Y, picture.X].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (ControlView.pozitie == 0)
            {
                map.setValue(picture.X, picture.Y, 0);
                selectie[picture.Y, picture.X].BackColor = Color.White;
                selectie[picture.Y, picture.X].Image = null;
            }
        }
    }
}
