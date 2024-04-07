using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Curse_TIR
{
    public class ControlStergere
    {
        private Panel main;
        private Panel footer;
        private ControlCursa control;

        public ControlStergere(Panel main, Panel footer, ControlCursa control)
        {
            this.control = control;
            this.main = main;
            this.footer = footer;
        }

        public void start()
        {
            this.main.Controls.Clear();
            this.footer.Controls.Clear();
            layoutStergere();
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

        public void layoutStergere()
        {
            Label info = new Label();
            OpInfo(info, "STERGERE");
            this.main.Controls.Add(info);

            Button iesire = new Button();
            BtnIesire(iesire);
            this.footer.Controls.Add(iesire);

            Button trimitereS = new Button();
            BtnTrimitereS(trimitereS);
            this.footer.Controls.Add(trimitereS);

            TextBox deLaT = new TextBox();
            deLaT.Name = "deLaT";
            Label deLaL = new Label();
            OpDeLa(deLaT, deLaL);
            this.main.Controls.Add(deLaL);
            this.main.Controls.Add(deLaT);
        }

        public void BtnTrimitereS(Button trimitereS)
        {
            trimitereS.Text = "Stergeti";
            trimitereS.Font = new Font("Calibri", 14, FontStyle.Bold);
            trimitereS.Location = new Point(0, 0);
            trimitereS.Size = new Size(this.footer.Width / 2, this.footer.Height / 2);
            trimitereS.Click += new EventHandler(trimitereS_Click);
        }

        public void trimitereS_Click(object sender, EventArgs e)
        {
            TextBox deLa = null;
            foreach (Control c in this.main.Controls)
                if (c.Name == "deLaT") deLa = c as TextBox;
            sterge(deLa);
        }

        public void sterge(TextBox deLa)
        {
            if (deLa.Text != "" && control.pozCursa(deLa.Text) != -1)
            {
                control.stergere(deLa.Text);
                MessageBox.Show("Sters cu succes!");
                deLa.Text = "";
            }
            else
                MessageBox.Show("Nu se poate sterge!");
        }
    }
}
