using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace InvadersVSTowers
{
    public class ControlViewJoc
    {
        private Form formaR, forma;
        private Panel header,aside,main;
        private int[] vec = new int[100];
        private int ct = 0;
        private int coordX, coordY;
        private int[,] map ;
        static public myPictureBox[,] harta = new myPictureBox[100, 100];

        public ControlViewJoc(Form forma)
        {
            this.formaR = forma;
            this.forma = new Form();
            this.header= new Panel();
            this.aside= new Panel();
            this.main= new Panel();
            this.map = new int[100, 100];
            this.forma.KeyPress += new KeyPressEventHandler(revenire_KeyPress);
        }

        public void stop()
        {
            this.forma.Close();
        }

        public void fisier()
        {
            string path = Application.StartupPath + @"\Harta.txt";
            StreamWriter fisier = new StreamWriter(path);
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 10; j++)
                    fisier.WriteLine(ControlViewInitiere.map.Map[i,j]);
            fisier.Close();
        }

        public void citire()
        {
            string path = Application.StartupPath + @"\Harta.txt";
            StreamReader fisier = new StreamReader(path);
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 10; j++)
                    this.map[i,j] = int.Parse(fisier.ReadLine());
            fisier.Close();
        }

        public void afisare()
        {
            string text = "";
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                    text += map[i, j];
                text += "\n";
            }
            MessageBox.Show(text);
        }

        private void revenire_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Escape){
                this.forma.Controls.Clear();
                ControlViewInitiere c = new ControlViewInitiere(this.forma);
                c.start();
            }
            string path = Application.StartupPath + @"\invaderPNG.png";
            Image im = Image.FromFile(path);
            if(coordX - 1 >= 0 && e.KeyChar == 119 && map[coordX,coordY]==2 && (map[coordX-1, coordY] == 0 || map[coordX - 1, coordY] == 33)){
                map[coordX, coordY] = 0;
                map[coordX - 1, coordY] = 2;
                harta[coordY, coordX].BackColor = Color.White;
                harta[coordY, coordX].Image = null;        
                harta[coordY, coordX-1].Image=im;
                harta[coordY, coordX - 1].SizeMode = PictureBoxSizeMode.StretchImage;
                coordX--;
            }
            if (coordY - 1 >= 0 && e.KeyChar == 97 && map[coordX, coordY] == 2 && (map[coordX, coordY-1] == 0 || map[coordX , coordY-1] == 33)){
                map[coordX, coordY] = 0;
                map[coordX , coordY-1] = 2;
                harta[coordY, coordX].BackColor = Color.White;
                harta[coordY, coordX].Image = null;
                harta[coordY-1, coordX ].Image = im;
                harta[coordY - 1, coordX].SizeMode = PictureBoxSizeMode.StretchImage;
                coordY--;
            }
            if (coordX + 1 <= 6 && e.KeyChar == 115 && map[coordX, coordY] == 2 && (map[coordX+1, coordY] == 0 || map[coordX + 1, coordY] == 33)){
                map[coordX, coordY] = 0;
                map[coordX + 1, coordY] = 2;
                harta[coordY, coordX].BackColor = Color.White;
                harta[coordY, coordX].Image = null;
                harta[coordY, coordX + 1].Image = im;
                harta[coordY, coordX+1].SizeMode = PictureBoxSizeMode.StretchImage;
                coordX++;
            }
            if (coordY + 1 < 10 && e.KeyChar == 100 && map[coordX, coordY] == 2 && (map[coordX, coordY+1] == 0 || map[coordX , coordY+1] == 33)){
                map[coordX, coordY] = 0;
                map[coordX , coordY+1] = 2;
                harta[coordY, coordX].BackColor = Color.White;
                harta[coordY, coordX].Image = null;
                harta[coordY+1, coordX ].Image = im;
                harta[coordY + 1, coordX].SizeMode = PictureBoxSizeMode.StretchImage;
                coordY++;
            }
            //if (verfTurn() == false)
                //turnuri();
        }

        public bool verfTurn()
        {
            for (int i = 0; i < ct; i++)
            {
                //MessageBox.Show( (vec[i] / 10 - 1.).ToString() +" " + vec[i] % 10) || (this.coordX == vec[i] / 10 + 1 && this.coordY == vec[i] % 10) || (this.coordX == vec[i] / 10 && this.coordY == vec[i] % 10 - 1) || (this.coordX == vec[i] / 10 && this.coordY == vec[i] % 10 + 1)));
                if ((this.coordX == vec[i] / 10 - 1 && this.coordY == vec[i] % 10) || (this.coordX == vec[i] / 10 + 1 && this.coordY == vec[i] % 10) || (this.coordX == vec[i] / 10 && this.coordY == vec[i] % 10 - 1) || (this.coordX == vec[i] / 10 && this.coordY == vec[i] % 10 + 1))
                    return true;
            }
            return false;
        }

        public void start()
        {
            this.forma.Show();
            fisier();
            citire();
            layoutForma();
            layoutPanel();
            layoutHarta();
            turnuri();
            layoutControale();
        }

        public void layoutControale()
        {
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

        public void layoutInfo(Label info)
        {
            info.Location = new Point(0, 30);
            info.Size = new Size(this.aside.Width, this.aside.Height - 150);
            info.Font = new Font("Calibri", 15, FontStyle.Bold | FontStyle.Italic);
            info.TextAlign = ContentAlignment.MiddleCenter;
            info.BackColor = Color.Transparent;
            info.Text = "Apasa pe Invader-ul dorit\nFoloseste 'W' , 'A' , 'S' , 'D' pentru a-i controla directia\nApasa 'Escape' pentru a te reintoarte in meniul de alegere al plasabilelor";
        }

        public void layoutForma()
        {
            this.forma.MinimumSize = new Size(1300, 717);
            this.forma.MaximumSize = new Size(1300, 717);
            this.forma.Location = new Point(35, 35);
            this.forma.FormBorderStyle = FormBorderStyle.None;
        }

        public void turnuri()
        {
            for (int i = 0; i < ct; i++)
            {
                harta[vec[i] / 10 - 1, vec[i] % 10].BackColor = Color.Cyan;
                harta[vec[i] / 10 + 1, vec[i] % 10].BackColor = Color.Cyan;
                harta[vec[i] / 10, vec[i] % 10 - 1].BackColor = Color.Cyan;
                harta[vec[i] / 10, vec[i] % 10 + 1].BackColor = Color.Cyan;
            }
        }

        public void layoutPanel()
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

    public void layoutHarta()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    harta[i, j] = new myPictureBox();
                    harta[i, j].Location = new Point(i * 100, j * 100);
                    harta[i, j].Size = new Size(100, 100);
                    harta[i, j].Click += new EventHandler(selectie_Click);
                    harta[i, j].X = j;
                    harta[i, j].Y = i;
                        string path = "";
                    if (map[j, i] == 0)
                        harta[i, j].BackColor = Color.White;
                    if (map[j, i] == 1)
                    {
                        path = Application.StartupPath + @"\wallPNG.png";
                        Image im = Image.FromFile(path);
                        harta[i, j].Image = im;
                        harta[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (map[j, i] == 2)
                    {
                        path = Application.StartupPath + @"\invaderPNG.png";
                        Image im = Image.FromFile(path);
                        harta[i, j].Image = im;
                        harta[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (map[j, i] == 3)
                    {
                        path = Application.StartupPath + @"\towerPNG.png";
                        Image im = Image.FromFile(path);
                        harta[i, j].Image = im;
                        harta[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                        vec[ct++] = i * 10 + j;
                    }
                    if (map[j, i] == 4)
                    {
                        path = Application.StartupPath + @"\finishPNG.png";
                        Image im = Image.FromFile(path);
                        harta[i, j].Image = im;
                        harta[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    this.main.Controls.Add(harta[i, j]);
                }
            }
        }
        public void selectie_Click(object sender, EventArgs e)
        {
            myPictureBox picture = sender as myPictureBox;
            if (map[picture.X, picture.Y] == 2)
            {
                this.coordX = picture.X;
                this.coordY = picture.Y;
            }
        }


    }
}
