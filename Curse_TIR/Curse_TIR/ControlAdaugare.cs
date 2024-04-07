using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Curse_TIR
{
    public class ControlAdaugare
    {
        private Panel main;
        private Panel footer;
        private ControlCursa control;

        public ControlAdaugare(Panel main, Panel footer, ControlCursa control)
        {
            this.control = control;
            this.main = main;
            this.footer = footer;
        }

        public void start()
        {
            this.main.Controls.Clear();
            this.footer.Controls.Clear();
            layoutAdaugare();
        }

        public void layoutAdaugare()
        {
            Label info = new Label();
            OpInfo(info, "ADAUGARE");
            this.main.Controls.Add(info);

            Button iesire = new Button();
            BtnIesire(iesire);
            this.footer.Controls.Add(iesire);

            Button trimitereA = new Button();
            BtnTrimitereA(trimitereA);
            this.footer.Controls.Add(trimitereA);

            TextBox deLaT = new TextBox();
            deLaT.Name = "deLaT";
            Label deLaL = new Label();
            OpDeLa(deLaT, deLaL);
            this.main.Controls.Add(deLaL);
            this.main.Controls.Add(deLaT);

            TextBox panaLaT = new TextBox();
            panaLaT.Name = "panaLaT";
            Label panaLaL = new Label();
            OpPanaLa(panaLaT, panaLaL);
            this.main.Controls.Add(panaLaL);
            this.main.Controls.Add(panaLaT);

            TextBox kmT = new TextBox();
            kmT.Name = "kmT";
            Label kmL = new Label();
            OpKm(kmT, kmL);
            this.main.Controls.Add(kmL);
            this.main.Controls.Add(kmT);

            TextBox pretT = new TextBox();
            pretT.Name = "pretT";
            Label pretL = new Label();
            OpPret(pretT, pretL);
            this.main.Controls.Add(pretL);
            this.main.Controls.Add(pretT);
        }

        public void OpInfo(Label info, string text)
        {
            info.Text = text;
            info.Font = new Font("Calibri", 18, FontStyle.Bold);
            info.Location = new Point(this.main.Width / 2 - 75, 0);
            info.Size = new Size(150, 30);
            info.TextAlign = ContentAlignment.MiddleRight;
        }

        public void BtnTrimitereA(Button trimitereA)
        {
            trimitereA.Text = "Adaugati";
            trimitereA.Font = new Font("Calibri", 14, FontStyle.Bold);
            trimitereA.Location = new Point(0, 0);
            trimitereA.Size = new Size(this.footer.Width / 2, this.footer.Height / 2);
            trimitereA.Click += new EventHandler(trimitereA_Click);
        }

        public void trimitereA_Click(object sender, EventArgs e)
        {
            TextBox deLa = null;
            TextBox panaLa = null;
            TextBox ore = null;
            TextBox pret = null;
            foreach (Control c in this.main.Controls)
                if (c.Name == "deLaT") deLa = c as TextBox;
                else
                    if (c.Name == "panaLaT") panaLa = c as TextBox;
                else
                        if (c.Name == "kmT") ore = c as TextBox;
                else
                            if (c.Name == "pretT") pret = c as TextBox;
            adauga(deLa, panaLa, ore, pret);
        }

        public void adauga(TextBox deLa, TextBox panaLa, TextBox ore, TextBox pret)
        {
            if (deLa.Text != "" && panaLa.Text != "" && ore.Text != "" && pret.Text != "")
            {
                control.adaugare(deLa.Text, panaLa.Text, int.Parse(ore.Text), int.Parse(pret.Text));
                MessageBox.Show("Adaugat cu succes!");
                deLa.Text = "";
                panaLa.Text = "";
                ore.Text = "";
                pret.Text = "";
            }
            else
                MessageBox.Show("Nu se poate adauga!");
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

        public void OpDeLa(TextBox deLaT, Label deLaL)
        {
            deLaL.Text = "Cursa incepe la";
            deLaL.Font = new Font("Calibri", 14, FontStyle.Bold);
            deLaL.Location = new Point(this.main.Width / 2 - 160, 80);
            deLaL.Size = new Size(150, 30);
            deLaL.TextAlign = ContentAlignment.MiddleRight;

            deLaT.Font = new Font("Calibri", 14, FontStyle.Bold);
            deLaT.Location = new Point(this.main.Width / 2 + 10, 80);
            deLaT.Size = new Size(150, 30);
        }

        public void OpPanaLa(TextBox panaLaT, Label panaLaL)
        {
            panaLaL.Text = "Cursa se termina la";
            panaLaL.Font = new Font("Calibri", 14, FontStyle.Bold);
            panaLaL.Location = new Point(this.main.Width / 2 - 220, 120);
            panaLaL.Size = new Size(210, 30);
            panaLaL.TextAlign = ContentAlignment.MiddleRight;

            panaLaT.Font = new Font("Calibri", 14, FontStyle.Bold);
            panaLaT.Location = new Point(this.main.Width / 2 + 10, 120);
            panaLaT.Size = new Size(150, 30);
        }

        public void OpKm(TextBox kmT, Label kmL)
        {
            kmL.Text = "Kilometri";
            kmL.Font = new Font("Calibri", 14, FontStyle.Bold);
            kmL.Location = new Point(this.main.Width / 2 - 160, 160);
            kmL.Size = new Size(150, 30);
            kmL.TextAlign = ContentAlignment.MiddleRight;

            kmT.Font = new Font("Calibri", 14, FontStyle.Bold);
            kmT.Location = new Point(this.main.Width / 2 + 10, 160);
            kmT.Size = new Size(150, 30);
        }

        public void OpPret(TextBox pretT, Label pretL)
        {
            pretL.Text = "Pretul";
            pretL.Font = new Font("Calibri", 14, FontStyle.Bold);
            pretL.Location = new Point(this.main.Width / 2 - 160, 200);
            pretL.Size = new Size(150, 30);
            pretL.TextAlign = ContentAlignment.MiddleRight;

            pretT.Font = new Font("Calibri", 14, FontStyle.Bold);
            pretT.Location = new Point(this.main.Width / 2 + 10, 200);
            pretT.Size = new Size(150, 30);
        }
    }
}
