using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Curse_TIR
{
    public class ControlModificare
    {
        private Panel main;
        private Panel footer;
        private ControlCursa control;

        public ControlModificare(Panel main, Panel footer, ControlCursa control)
        {
            this.control = control;
            this.main = main;
            this.footer = footer;
        }

        public void start()
        {
            this.main.Controls.Clear();
            this.footer.Controls.Clear();
            layoutModificare();
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

        public void layoutModificare()
        {
            Label info = new Label();
            OpInfo(info, "MODIFICARE");
            this.main.Controls.Add(info);

            Button iesire = new Button();
            BtnIesire(iesire);
            this.footer.Controls.Add(iesire);

            Button trimitereM = new Button();
            BtnTrimitereM(trimitereM);
            this.footer.Controls.Add(trimitereM);

            TextBox deLaTC = new TextBox();
            deLaTC.Name = "deLaTC";
            Label deLaLC = new Label();
            OpDeLaMC(deLaTC, deLaLC);
            this.main.Controls.Add(deLaLC);
            this.main.Controls.Add(deLaTC);

            TextBox deLaT = new TextBox();
            deLaT.Name = "deLaT";
            Label deLaL = new Label();
            OpDeLaM(deLaT, deLaL);
            this.main.Controls.Add(deLaL);
            this.main.Controls.Add(deLaT);

            TextBox panaLaT = new TextBox();
            panaLaT.Name = "panaLaT";
            Label panaLaL = new Label();
            OpPanaLaM(panaLaT, panaLaL);
            this.main.Controls.Add(panaLaL);
            this.main.Controls.Add(panaLaT);

            TextBox kmT = new TextBox();
            kmT.Name = "kmT";
            Label kmL = new Label();
            OpKmM(kmT, kmL);
            this.main.Controls.Add(kmL);
            this.main.Controls.Add(kmT);

            TextBox pretT = new TextBox();
            pretT.Name = "pretT";
            Label pretL = new Label();
            OpPretM(pretT, pretL);
            this.main.Controls.Add(pretL);
            this.main.Controls.Add(pretT);
        }

        public void BtnTrimitereM(Button trimitereM)
        {
            trimitereM.Text = "Modificati";
            trimitereM.Font = new Font("Calibri", 14, FontStyle.Bold);
            trimitereM.Location = new Point(0, 0);
            trimitereM.Size = new Size(this.footer.Width / 2, this.footer.Height / 2);
            trimitereM.Click += new EventHandler(trimitereM_Click);
        }

        public void trimitereM_Click(object sender, EventArgs e)
        {
            TextBox deLaC = null;
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
                else
                                if (c.Name == "deLaTC") deLaC = c as TextBox;
            modifica(deLa, panaLa, ore, pret, deLaC);
        }

        public void modifica(TextBox deLa, TextBox panaLa, TextBox ore, TextBox pret, TextBox deLaC)
        {
            if (control.pozCursa(deLaC.Text) != -1)
            {
                control.modificare(deLa.Text, panaLa.Text, ore.Text, pret.Text, deLaC.Text);
                MessageBox.Show("Modificat cu succes!");
                deLaC.Text = "";
                deLa.Text = "";
                panaLa.Text = "";
                ore.Text = "";
                pret.Text = "";
            }
            else
                MessageBox.Show("Nu se poate modifica!");
        }

        public void OpDeLaMC(TextBox deLaT, Label deLaL)
        {
            deLaL.Text = "Plecarea Cautata";
            deLaL.Font = new Font("Calibri", 14, FontStyle.Bold);
            deLaL.Location = new Point(this.main.Width / 2 - 160, 80);
            deLaL.Size = new Size(150, 30);
            deLaL.TextAlign = ContentAlignment.MiddleRight;

            deLaT.Font = new Font("Calibri", 14, FontStyle.Bold);
            deLaT.Location = new Point(this.main.Width / 2 + 10, 80);
            deLaT.Size = new Size(150, 30);
        }

        public void OpDeLaM(TextBox deLaT, Label deLaL)
        {
            deLaL.Text = "Noua plecare";
            deLaL.Font = new Font("Calibri", 14, FontStyle.Bold);
            deLaL.Location = new Point(this.main.Width / 2 - 160, 140);
            deLaL.Size = new Size(150, 30);
            deLaL.TextAlign = ContentAlignment.MiddleRight;

            deLaT.Font = new Font("Calibri", 14, FontStyle.Bold);
            deLaT.Location = new Point(this.main.Width / 2 + 10, 140);
            deLaT.Size = new Size(150, 30);
        }

        public void OpPanaLaM(TextBox panaLaT, Label panaLaL)
        {
            panaLaL.Text = "Noua destinatie";
            panaLaL.Font = new Font("Calibri", 14, FontStyle.Bold);
            panaLaL.Location = new Point(this.main.Width / 2 - 160, 180);
            panaLaL.Size = new Size(150, 30);
            panaLaL.TextAlign = ContentAlignment.MiddleRight;

            panaLaT.Font = new Font("Calibri", 14, FontStyle.Bold);
            panaLaT.Location = new Point(this.main.Width / 2 + 10, 180);
            panaLaT.Size = new Size(150, 30);
        }

        public void OpKmM(TextBox kmT, Label kmL)
        {
            kmL.Text = "Noul nr. de km";
            kmL.Font = new Font("Calibri", 14, FontStyle.Bold);
            kmL.Location = new Point(this.main.Width / 2 - 270, 220);
            kmL.Size = new Size(260, 30);
            kmL.TextAlign = ContentAlignment.MiddleRight;

            kmT.Font = new Font("Calibri", 14, FontStyle.Bold);
            kmT.Location = new Point(this.main.Width / 2 + 10, 220);
            kmT.Size = new Size(150, 30);
        }

        public void OpPretM(TextBox pretT, Label pretL)
        {
            pretL.Text = "Noul Pret";
            pretL.Font = new Font("Calibri", 14, FontStyle.Bold);
            pretL.Location = new Point(this.main.Width / 2 - 160, 260);
            pretL.Size = new Size(150, 30);
            pretL.TextAlign = ContentAlignment.MiddleRight;

            pretT.Font = new Font("Calibri", 14, FontStyle.Bold);
            pretT.Location = new Point(this.main.Width / 2 + 10, 260);
            pretT.Size = new Size(150, 30);
        }
    }
}
