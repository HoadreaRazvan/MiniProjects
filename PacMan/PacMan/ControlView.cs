using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace PacMan
{
    public class ControlView
    {
        private Form forma;
        private Panel harta, control;
        private Map map;
        private PictureBox[,] pictures;
        private int p1, p2, alienP, score;

        public ControlView(Form forma)
        {
            this.forma = forma;
            this.harta = new Panel();
            this.control = new Panel();
            this.map = new Map(12, 10);
            this.pictures = new PictureBox[100, 100];
            this.p1 = 8;
            this.p2 = 6;
            this.alienP = 1;
            this.score = 0;
        }

        public void start()
        {
            layoutForma();
            layoutPanel();
            layoutHarta();
            zidInterior();
            playerPosition(6, 8);
            layoutCoins();
            layoutFinish();
            layoutControale();
            layoutMark();
        }

        public void layoutForma()
        {
            this.forma.MaximumSize = new Size(1200, 660);
            this.forma.MinimumSize = new Size(1200, 660);
            this.forma.Location = new Point(80, 40);
            this.forma.FormBorderStyle = FormBorderStyle.None;
            this.forma.BackColor = Color.Black;
            this.harta.BackColor = Color.White;
            this.control.BackColor = Color.White;
        }

        public void layoutPanel()
        {
            string path = Application.StartupPath + @"\1.png";
            Image im = Image.FromFile(path);
            this.control.BackgroundImageLayout = ImageLayout.Tile;
            this.control.BackgroundImage = im;
            this.harta.Location = new Point(10, 10);
            this.harta.Size = new Size(800, 640);
            this.control.Location = new Point(820, 10);
            this.control.Size = new Size(370, 640);
            this.forma.Controls.Add(harta);
            this.forma.Controls.Add(control);
        }

        public void layoutHarta()
        {
            for (int j = 0; j < 12; j++)
                for (int i = 0; i < 10; i++)
                {
                    pictures[j, i] = new PictureBox();
                    pictures[j, i].Cursor = Cursors.No;
                    pictures[j, i].Size = new Size(80, 80);
                    pictures[j, i].Location = new Point(i * 80, j * 80);
                    pictures[j, i].SizeMode = PictureBoxSizeMode.StretchImage;
                    if (j == 0 || j == this.harta.Height / 80 - 1 || i == 0 || i == this.harta.Width / 80 - 1)
                    {

                        string path = Application.StartupPath + @"\1.png";
                        Image im = Image.FromFile(path);
                        pictures[j, i].Image = im;
                        this.map.setValue(j, i, 1);
                        this.harta.Controls.Add(pictures[j, i]);
                    }
                    else
                    {
                        string path = Application.StartupPath + @"\0.png";
                        Image im = Image.FromFile(path);
                        pictures[j, i].Image = im;
                        this.map.setValue(j, i, 0);
                        this.harta.Controls.Add(pictures[j, i]);
                    }
                }
        }

        public void layoutMark()
        {
            Label mark = new Label();
            mark.Location = new Point(this.control.Width / 2 - 100, this.control.Height - 25);
            mark.Size = new Size(200, 25);
            mark.TextAlign = ContentAlignment.TopCenter;
            mark.BackColor = Color.Transparent;
            mark.Font = new Font("Calibri", 15, FontStyle.Bold | FontStyle.Italic);
            mark.Text = "By HoadreaRB SandE";
            this.control.Controls.Add(mark);
        }

        public void layoutCoins()
        {
            int[] coins = new int[] { 22, 23, 24, 56, 27 };
            for (int i = 0; i < 5; i++)
            {
                string path = Application.StartupPath + @"\5.png";
                Image im = Image.FromFile(path);
                pictures[coins[i] / 10, coins[i] % 10].Image = im;
                map.setValue(coins[i] / 10, coins[i] % 10, 5);
            }
        }

        public void layoutFinish()
        {
            string path = Application.StartupPath + @"\4.png";
            Image im = Image.FromFile(path);
            pictures[6, 6].Image = im;
            this.map.setValue(6, 6, 4);
            this.harta.Controls.Add(pictures[6, 6]);
        }

        public void playerPosition(int d1, int d2)
        {
            string path = Application.StartupPath + @"\0.png";
            Image im1 = Image.FromFile(path);
            pictures[this.p1, this.p2].Image = im1;
            map.setValue(this.p1, this.p2, 0);
            string path1 = Application.StartupPath + @"\2.png";
            Image im = Image.FromFile(path1);
            pictures[d1, d2].Image = im;
            map.setValue(d1, d2, 2);
            this.p1 = d1;
            this.p2 = d2;
        }

        public void alienPosition()
        {
            if (this.alienP == 9) this.alienP = 1;
            int a = 0, b = 0, c = 0, d = 0;
            if (this.alienP == 1) { a = 1; b = 6; c = 2; d = 6; }
            if (this.alienP == 2) { a = 2; b = 6; c = 3; d = 6; }
            if (this.alienP == 3) { a = 3; b = 6; c = 3; d = 7; }
            if (this.alienP == 4) { a = 3; b = 7; c = 3; d = 8; }
            if (this.alienP == 5) { a = 3; b = 8; c = 2; d = 8; }
            if (this.alienP == 6) { a = 2; b = 8; c = 1; d = 8; }
            if (this.alienP == 7) { a = 1; b = 8; c = 1; d = 7; }
            if (this.alienP == 8) { a = 1; b = 7; c = 1; d = 6; }
            string path = Application.StartupPath + @"\0.png";
            Image im = Image.FromFile(path);
            pictures[a, b].Image = im;
            map.setValue(a, b, 0);
            string path1 = Application.StartupPath + @"\3.png";
            Image im1 = Image.FromFile(path1);
            pictures[c, d].Image = im1;
            map.setValue(c, d, 3);
            if (!map.verfPlayer())
                info(3);
            this.alienP++;
        }

        public void zidInterior()
        {
            int[] zid = new int[] { 64, 54, 33, 34, 35, 25, 46, 32, 42, 52, 57, 67 };
            for (int i = 0; i < 12; i++)
            {
                string path = Application.StartupPath + @"\1.png";
                Image im = Image.FromFile(path);
                pictures[zid[i] / 10, zid[i] % 10].Image = im;
                map.setValue(zid[i] / 10, zid[i] % 10, 1);
            }
        }


        public void layoutControale()
        {
            Label sc = new Label();
            layoutScor(sc);
            this.control.Controls.Add(sc);
            ScorPlus();

            PictureBox w = new PictureBox();
            layoutW(w);
            this.control.Controls.Add(w);

            PictureBox a = new PictureBox();
            layoutA(a);
            this.control.Controls.Add(a);

            PictureBox s = new PictureBox();
            layoutS(s);
            this.control.Controls.Add(s);

            PictureBox d = new PictureBox();
            layoutD(d);
            this.control.Controls.Add(d);

            PictureBox exit = new PictureBox();
            PictureBox reset = new PictureBox();
            exitLayout(70, 70, this.control.Width - 80, 10, exit);
            resetLayout(70, 70, this.control.Width - 80, 90, reset);
            this.control.Controls.Add(reset);
            this.control.Controls.Add(exit);
        }

        public void exitLayout(int a, int b, int c, int d, PictureBox exit)
        {
            exit.Size = new Size(a, b);
            exit.Cursor = Cursors.Hand;
            exit.Location = new Point(c, d);
            exit.SizeMode = PictureBoxSizeMode.StretchImage;
            exit.BackColor = Color.Transparent;
            string path = Application.StartupPath + @"\exit.png";
            Image im1 = Image.FromFile(path);
            exit.Image = im1;
            exit.Click += new EventHandler(exit_Click);
        }

        public void exit_Click(object sender, EventArgs e)
        {
            this.forma.Close();
        }

        public void resetLayout(int a, int b, int c, int d, PictureBox reset)
        {
            reset.Size = new Size(a, b);
            reset.Cursor = Cursors.Hand;
            reset.Location = new Point(c, d);
            reset.SizeMode = PictureBoxSizeMode.StretchImage;
            reset.BackColor = Color.Transparent;
            string path = Application.StartupPath + @"\reset.png";
            Image im1 = Image.FromFile(path);
            reset.Image = im1;
            reset.Click += new EventHandler(reset_Click);
        }

        public void reset_Click(object sender, EventArgs e)
        {
            this.forma.Controls.Clear();
            this.harta = new Panel();
            this.control = new Panel();
            this.map = new Map(12, 10);
            this.pictures = new PictureBox[100, 100];
            this.p1 = 8;
            this.p2 = 6;
            this.alienP = 1;
            this.score = 0;
            start();
        }

        public void layoutScor(Label sc)
        {
            sc.Font = new Font("Calibri", 35, FontStyle.Bold);
            sc.TextAlign = ContentAlignment.MiddleCenter;
            sc.Text = "Scorul: " + this.score.ToString();
            sc.BackColor = Color.Transparent;
            sc.Location = new Point(10, 10);
            sc.Size = new Size(this.control.Width - 100, 150);
            sc.Name = "l";
        }

        public void ScorPlus()
        {
            Label l = null;
            foreach (Control control in this.control.Controls)
                if (control.Name == "l") l = control as Label;
            l.Text = "Scorul: " + this.score++.ToString();
        }

        public void info(int a)
        {
            this.forma.Controls.Clear();
            string path = Application.StartupPath + @"\meniu.png";
            Image im1 = Image.FromFile(path);
            this.forma.BackgroundImage = im1;
            Label info = new Label();
            info.BackColor = Color.Transparent;
            info.Font = new Font("Calibri", 40, FontStyle.Bold);
            if (a != 1)
                info.Text = " Game Over";
            else
                info.Text = "  Felicitari!\nAi ajuns la sfarsit cu scorul " + (this.score - 1).ToString() + " !";
            info.Location = new Point(0, 160);
            info.Size = new Size(this.forma.Width, 140);
            info.TextAlign = ContentAlignment.TopCenter;
            this.forma.Controls.Add(info);
            PictureBox exit = new PictureBox();
            PictureBox reset = new PictureBox();
            exitLayout(70, 70, this.forma.Width / 2 - 90, 300, exit);
            resetLayout(70, 70, this.forma.Width / 2 + 20, 300, reset);
            this.forma.Controls.Add(reset);
            this.forma.Controls.Add(exit);
        }


        public void layoutW(PictureBox w)
        {
            w.Size = new Size(100, 100);
            w.Location = new Point(this.control.Width / 2 - 45, 350);
            w.SizeMode = PictureBoxSizeMode.StretchImage;
            w.Cursor = Cursors.Hand;
            string path = Application.StartupPath + @"\s.png";
            Image im = Image.FromFile(path);
            w.Image = im;
            w.BackColor = Color.Transparent;
            w.Click += new EventHandler(w_Click);
        }

        public void w_Click(object sender, EventArgs e)
        {
            if (map.isOk(this.p1 - 1, this.p2) == 0)
                playerPosition(this.p1 - 1, this.p2);
            else
            if (map.isOk(this.p1 - 1, this.p2) == 5)
            {
                ScorPlus();
                playerPosition(this.p1 - 1, this.p2);
            }
            else
            if (map.isOk(this.p1 - 1, this.p2) == 4)
            {
                playerPosition(this.p1 - 1, this.p2);
                info(1);
            }
            else
            if (map.isOk(this.p1 - 1, this.p2) == 3) info(2);
            alienPosition();
        }

        public void layoutA(PictureBox a)
        {
            a.Size = new Size(100, 100);
            a.Location = new Point(this.control.Width / 2 - 170, 480);
            a.SizeMode = PictureBoxSizeMode.StretchImage;
            a.Cursor = Cursors.Hand;
            string path = Application.StartupPath + @"\l.png";
            Image im = Image.FromFile(path);
            a.Image = im;
            a.BackColor = Color.Transparent;
            a.Click += new EventHandler(a_Click);
        }

        public void a_Click(object sender, EventArgs e)
        {
            if (map.isOk(this.p1, this.p2 - 1) == 0)
                playerPosition(this.p1, this.p2 - 1);
            else
            if (map.isOk(this.p1, this.p2 - 1) == 5)
            {
                ScorPlus();
                playerPosition(this.p1, this.p2 - 1);
            }
            else
            if (map.isOk(this.p1, this.p2 - 1) == 4)
            {
                playerPosition(this.p1, this.p2 - 1);
                info(1);
            }
            else
            if (map.isOk(this.p1, this.p2 - 1) == 3) info(2);
            alienPosition();
        }

        public void layoutS(PictureBox s)
        {
            s.Size = new Size(100, 100);
            s.Location = new Point(this.control.Width / 2 - 45, 480);
            s.SizeMode = PictureBoxSizeMode.StretchImage;
            s.Cursor = Cursors.Hand;
            string path = Application.StartupPath + @"\j.png";
            Image im = Image.FromFile(path);
            s.Image = im;
            s.BackColor = Color.Transparent;
            s.Click += new EventHandler(s_Click);
        }

        public void s_Click(object sender, EventArgs e)
        {
            if (map.isOk(this.p1 + 1, this.p2) == 0)
                playerPosition(this.p1 + 1, this.p2);
            else
            if (map.isOk(this.p1 + 1, this.p2) == 5)
            {
                ScorPlus();
                playerPosition(this.p1 + 1, this.p2);
            }
            else
            if (map.isOk(this.p1 + 1, this.p2) == 4)
            {
                playerPosition(this.p1 + 1, this.p2);
                info(1);
            }
            else
            if (map.isOk(this.p1 + 1, this.p2) == 3) info(2);
            alienPosition();
        }

        public void layoutD(PictureBox d)
        {
            d.Size = new Size(100, 100);
            d.Location = new Point(this.control.Width / 2 + 80, 480);
            d.SizeMode = PictureBoxSizeMode.StretchImage;
            d.Cursor = Cursors.Hand;
            string path = Application.StartupPath + @"\r.png";
            Image im = Image.FromFile(path);
            d.Image = im;
            d.BackColor = Color.Transparent;
            d.Click += new EventHandler(d_Click);
        }

        public void d_Click(object sender, EventArgs e)
        {
            if (map.isOk(this.p1, this.p2 + 1) == 0)
                playerPosition(this.p1, this.p2 + 1);
            else
            if (map.isOk(this.p1, this.p2 + 1) == 5)
            {
                ScorPlus();
                playerPosition(this.p1, this.p2 + 1);
            }
            else
            if (map.isOk(this.p1, this.p2 + 1) == 4)
            {
                playerPosition(this.p1, this.p2 + 1);
                info(1);
            }
            else
            if (map.isOk(this.p1, this.p2 + 1) == 3) info(2);
            alienPosition();
        }
    }
}
