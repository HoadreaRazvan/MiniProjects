using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InvadersVSTowers
{
    public class ControlViewInfo
    {
        private Form forma;
        
        public ControlViewInfo(Form forma)
        {
            this.forma = forma;
        }

        public void start()
        {
            layoutForma();
            layoutComponente();
        }

        public void layoutForma()
        {
            this.forma.MinimumSize = new Size(800, 400);
            this.forma.MaximumSize = new Size(800, 400);
            this.forma.Location = new Point(250, 150);
            this.forma.FormBorderStyle = FormBorderStyle.None;
        }

        public void layoutComponente()
        {
            Button start = new Button();
            layoutStart(start);
            this.forma.Controls.Add(start);

            Button iesire = new Button();
            layoutIesire(iesire);
            this.forma.Controls.Add(iesire);

            Label titlul = new Label();
            layoutTitlul(titlul);
            this.forma.Controls.Add(titlul);

            Label info = new Label();
            layoutInfo(info);
            this.forma.Controls.Add(info);

            Label sign = new Label();
            layoutSign(sign);
            this.forma.Controls.Add(sign);
        }

        public void layoutSign(Label sign)
        {
            sign.Location = new Point(this.forma.Width - 200, this.forma.Height - 40);
            sign.Size = new Size(200,50);
            sign.Font = new Font("Calibri", 12, FontStyle.Bold | FontStyle.Italic);
            sign.TextAlign = ContentAlignment.MiddleCenter;
            sign.BackColor = Color.Transparent;
            sign.Text = "Alpha 1.0   HoadreaRB SandE";
        }

        public void layoutStart(Button start)
        {
            start.Location = new Point(this.forma.Width / 2 - 75, this.forma.Height - 70);
            start.Size = new Size(150, 50);
            start.Text = "Start";
            start.Font = new Font("Calibri", 12, FontStyle.Bold);
            start.Click += new EventHandler(start_Click);
        }

        public void start_Click(object sender, EventArgs e)
        {
            this.forma.Controls.Clear();
            ControlView c = new ControlView(this.forma);
            c.start();
        }

        public void layoutIesire(Button iesire)
        {
            iesire.Location = new Point(this.forma.Width -30, 0);
            iesire.Size = new Size(30, 30);
            iesire.Text = "X";
            iesire.Font = new Font("Calibri", 12, FontStyle.Bold);
            iesire.Click += new EventHandler(iesire_Click);
        }

        public void iesire_Click(object sender, EventArgs e)
        {
            this.forma.Close();
        }

        public void layoutTitlul(Label titlul)
        {
            titlul.Location = new Point(50, 0);
            titlul.Size = new Size(this.forma.Width - 100, 100);
            titlul.Font = new Font("Calibri", 30, FontStyle.Bold | FontStyle.Italic);
            titlul.TextAlign = ContentAlignment.MiddleCenter;
            titlul.BackColor = Color.Transparent;
            titlul.Text = "Invaders VS Towers";
        }

        public void layoutInfo(Label info)
        {
            info.Location = new Point(0, 100);
            info.Size = new Size(this.forma.Width, this.forma.Height-150);
            info.Font = new Font("Calibri", 15, FontStyle.Bold | FontStyle.Italic);
            info.TextAlign = ContentAlignment.TopCenter;
            info.BackColor = Color.Transparent;
            info.Text = "Informatii:\nLa inceput trebuie sa iti creezi harta plasand invaderi, turnurile, zidurile si punctul de final\nApasand tasta 'Escape' te poti intoarce inapoi la meniul de configurare sau la meniul de alegere a plasabilelor\nDupa ce ati terminat configurarea apasati butonul 'Trimitere' ,alegeti un Invader prin apasarea acestuia si cu tastele 'W' , 'A' , 'S' si 'D' ii controlati directia\nScopul jocului este de a ajunge la final fara a fi distrus de turnurile inamice\nMult Succes!";
        }
    }
}
