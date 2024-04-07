using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Curse_TIR
{
    public class ControlInchiriere
    {
        private Panel main;
        private Panel footer;
        private ControlCursa control;

        public ControlInchiriere(Panel main, Panel footer, ControlCursa control)
        {
            this.control = control;
            this.main = main;
            this.footer = footer;
        }

        public void start()
        {
            this.main.Controls.Clear();
            this.footer.Controls.Clear();
            layoutInchiriere();
        }

        public void BtnIesire(Button iesire)
        {
            iesire.Text = "Iesire";
            iesire.Font = new Font("Calibri", 14, FontStyle.Bold);
            iesire.Location = new Point(this.footer.Width / 2, 0);
            iesire.Size = new Size(this.footer.Width / 2, this.footer.Height / 2);
            iesire.Click += new EventHandler(iesire_Click);
        }

        public void iesire_Click(object sender, EventArgs e)
        {
            this.main.Controls.Clear();
            this.footer.Controls.Clear();
        }

        public void OpInfo(Label info, string text)
        {
            info.Text = text;
            info.Font = new Font("Calibri", 18, FontStyle.Bold);
            info.Location = new Point(this.main.Width / 2 - 75, 0);
            info.Size = new Size(150, 30);
            info.TextAlign = ContentAlignment.MiddleRight;
        }

        public void layoutInchiriere()
        {
            Label info = new Label();
            OpInfo(info, "INCEPERE CURSA");
            this.main.Controls.Add(info);

            Button iesire = new Button();
            BtnIesire(iesire);
            this.footer.Controls.Add(iesire);

            Button trimitereI = new Button();
            BtnTrimitereI(trimitereI);
            this.footer.Controls.Add(trimitereI);

            TextBox deLaT = new TextBox();
            deLaT.Name = "deLaT";
            Label deLaL = new Label();
            OpDeLa(deLaT, deLaL);
            this.main.Controls.Add(deLaL);
            this.main.Controls.Add(deLaT);

            TextBox numeT = new TextBox();
            numeT.Name = "numeT";
            Label numeL = new Label();
            OpNume(numeT, numeL);
            this.main.Controls.Add(numeL);
            this.main.Controls.Add(numeT);
        }

        public void OpDeLa(TextBox deLaT, Label deLaL)
        {
            deLaL.Text = "Cursa";
            deLaL.Font = new Font("Calibri", 14, FontStyle.Bold);
            deLaL.Location = new Point(this.main.Width / 2 - 160, 80);
            deLaL.Size = new Size(150, 30);
            deLaL.TextAlign = ContentAlignment.MiddleRight;

            deLaT.Font = new Font("Calibri", 14, FontStyle.Bold);
            deLaT.Location = new Point(this.main.Width / 2 + 10, 80);
            deLaT.Size = new Size(150, 30);
        }

        public void OpNume(TextBox numeT, Label numeL)
        {
            numeL.Text = "Numele dvs.";
            numeL.Font = new Font("Calibri", 14, FontStyle.Bold);
            numeL.Location = new Point(this.main.Width / 2 - 160, 120);
            numeL.Size = new Size(150, 30);
            numeL.TextAlign = ContentAlignment.MiddleRight;

            numeT.Font = new Font("Calibri", 14, FontStyle.Bold);
            numeT.Location = new Point(this.main.Width / 2 + 10, 120);
            numeT.Size = new Size(150, 30);
        }

        public void BtnTrimitereI(Button trimitereM)
        {
            trimitereM.Text = "Incepeti cursa";
            trimitereM.Font = new Font("Calibri", 14, FontStyle.Bold);
            trimitereM.Location = new Point(0, 0);
            trimitereM.Size = new Size(this.footer.Width / 2, this.footer.Height / 2);
            trimitereM.Click += new EventHandler(trimitereBI_Click);
        }

        public void trimitereBI_Click(object sender, EventArgs e)
        {
            TextBox deLa = null;
            TextBox sofer = null;
            foreach (Control c in this.main.Controls)
                if (c.Name == "deLaT") deLa = c as TextBox;
                else
                    if (c.Name == "numeT") sofer = c as TextBox;
            inchiriazaI(deLa, sofer);
        }

        public void inchiriazaI(TextBox deLa, TextBox sofer)
        {
            if (deLa.Text != "" && sofer.Text != "" && control.verfStatus(deLa.Text) == false && control.pozCursa(deLa.Text) != -1)
            {
                control.inchiriere(deLa.Text, sofer.Text);
                MessageBox.Show("Cursa preluata cu succes!");
                deLa.Text = "";
                sofer.Text = "";
            }
            else
                MessageBox.Show("Nu se poate prelua cursa!");
        }

    }
}
