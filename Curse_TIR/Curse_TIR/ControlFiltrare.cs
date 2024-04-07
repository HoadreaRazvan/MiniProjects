using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Curse_TIR
{
    public class ControlFiltrare
    {
        private Panel main;
        private Panel footer;
        private ControlCursa control;

        public ControlFiltrare(Panel main, Panel footer, ControlCursa control)
        {
            this.control = control;
            this.main = main;
            this.footer = footer;
        }

        public void start()
        {
            this.main.Controls.Clear();
            this.footer.Controls.Clear();
            layoutFiltrare();
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
            info.Location = new Point(this.main.Width / 2 - 100, 0);
            info.Size = new Size(200, 30);
            info.TextAlign = ContentAlignment.MiddleRight;
        }

        public void layoutFiltrare()
        {
            Label info = new Label();
            OpInfo(info, "FILTRARE");
            this.main.Controls.Add(info);

            Button iesire = new Button();
            BtnIesire(iesire);
            this.footer.Controls.Add(iesire);

            Button trimiteref = new Button();
            BtnTrimitereF(trimiteref);
            this.footer.Controls.Add(trimiteref);

            TextBox deLaT = new TextBox();
            deLaT.Name = "deLaT";
            Label deLaL = new Label();
            OpDeLaF(deLaT, deLaL);
            this.main.Controls.Add(deLaL);
            this.main.Controls.Add(deLaT);

            TextBox panaLaT = new TextBox();
            panaLaT.Name = "panaLaT";
            Label panaLaL = new Label();
            OpPanaLaF(panaLaT, panaLaL);
            this.main.Controls.Add(panaLaL);
            this.main.Controls.Add(panaLaT);

            TextBox kmT = new TextBox();
            kmT.Name = "oreT";
            Label kmL = new Label();
            OpKmF(kmT, kmL);
            this.main.Controls.Add(kmL);
            this.main.Controls.Add(kmT);

            TextBox pretT = new TextBox();
            pretT.Name = "pretT";
            Label pretL = new Label();
            OpPretF(pretT, pretL);
            this.main.Controls.Add(pretL);
            this.main.Controls.Add(pretT);

            TextBox stT = new TextBox();
            stT.Name = "stT";
            Label stL = new Label();
            OpStF(stT, stL);
            this.main.Controls.Add(stL);
            this.main.Controls.Add(stT);

            TextBox soferT = new TextBox();
            soferT.Name = "soferT";
            Label soferL = new Label();
            OpSoferF(soferT, soferL);
            this.main.Controls.Add(soferL);
            this.main.Controls.Add(soferT);
        }

        public void BtnTrimitereF(Button trimitereM)
        {
            trimitereM.Text = "Filtrati";
            trimitereM.Font = new Font("Calibri", 14, FontStyle.Bold);
            trimitereM.Location = new Point(0, 0);
            trimitereM.Size = new Size(this.footer.Width / 2, this.footer.Height / 2);
            trimitereM.Click += new EventHandler(trimitereF_Click);
        }

        public void trimitereF_Click(object sender, EventArgs e)
        {
            TextBox deLa = null;
            TextBox panaLa = null;
            TextBox ore = null;
            TextBox pret = null;
            TextBox st = null;
            TextBox sofer = null;
            foreach (Control c in this.main.Controls)
                if (c.Name == "deLaT") deLa = c as TextBox;
                else
                    if (c.Name == "panaLaT") panaLa = c as TextBox;
                else
                        if (c.Name == "oreT") ore = c as TextBox;
                else
                            if (c.Name == "pretT") pret = c as TextBox;
                else
                                if (c.Name == "stT") st = c as TextBox;
                else
                                    if (c.Name == "soferT") sofer = c as TextBox;
            filt(deLa, panaLa, ore, pret, st, sofer);
        }

        public void tabelAfisare(ListView tabel, List<Cursa> nou)
        {
            tabel.GridLines = true;
            tabel.View = View.Details;
            tabel.BackColor = Color.Gray;
            tabel.Size = new Size(this.main.Width, this.main.Height);
            tabel.Clear();
            tabel.Columns.Add("", 1, HorizontalAlignment.Center);
            tabel.Columns.Add("De La", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Pana La", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Kilometri", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Pretul", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Status", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Nume Sofer", tabel.Width / 6 - 3, HorizontalAlignment.Center);
            foreach (Cursa cursa in nou)
            {
                ListViewItem linie = new ListViewItem();
                linie.SubItems.Add(cursa.DeLa);
                linie.SubItems.Add(cursa.PanaLa);
                linie.SubItems.Add(cursa.Km.ToString());
                linie.SubItems.Add(cursa.Pret.ToString());
                linie.SubItems.Add(cursa.Status == 1 ? "Da" : "Nu");
                linie.SubItems.Add(cursa.Sofer);
                tabel.Items.Add(linie);
            }
        }

        public void filt(TextBox deLa, TextBox panaLa, TextBox ore, TextBox pret, TextBox st, TextBox sofer)
        {
            this.main.Controls.Clear();
            this.footer.Controls.Clear();
            ListView tabel = new ListView();
            tabelAfisare(tabel, control.filtrDeLa(control.filtrPanaLa(control.filtrKm(control.filtrPret(control.filtrStatus(control.filtrSofer(control.Curse, sofer.Text), st.Text), pret.Text), ore.Text), panaLa.Text), deLa.Text));
            this.main.Controls.Add(tabel);

            Button iesire = new Button();
            BtnIesire(iesire);
            this.footer.Controls.Add(iesire);

            Button refl = new Button();
            BtnRef(refl);
            this.footer.Controls.Add(refl);
        }

        public void BtnRef(Button trimitereM)
        {
            trimitereM.Text = "Reintoarcere";
            trimitereM.Font = new Font("Calibri", 14, FontStyle.Bold);
            trimitereM.Location = new Point(0, 0);
            trimitereM.Size = new Size(this.footer.Width / 2, this.footer.Height / 2);
            trimitereM.Click += new EventHandler(refl_Click);
        }

        public void refl_Click(object sender, EventArgs e)
        {
            this.main.Controls.Clear();
            this.footer.Controls.Clear();
            layoutFiltrare();
        }

        public void OpDeLaF(TextBox deLaT, Label deLaL)
        {
            deLaL.Text = "Plecare";
            deLaL.Font = new Font("Calibri", 14, FontStyle.Bold);
            deLaL.Location = new Point(this.main.Width / 2 - 160, 60);
            deLaL.Size = new Size(150, 30);
            deLaL.TextAlign = ContentAlignment.MiddleRight;

            deLaT.Font = new Font("Calibri", 14, FontStyle.Bold);
            deLaT.Location = new Point(this.main.Width / 2 + 10, 60);
            deLaT.Size = new Size(150, 30);
        }

        public void OpPanaLaF(TextBox panaLaT, Label panaLaL)
        {
            panaLaL.Text = "Destinatie";
            panaLaL.Font = new Font("Calibri", 14, FontStyle.Bold);
            panaLaL.Location = new Point(this.main.Width / 2 - 160, 100);
            panaLaL.Size = new Size(150, 30);
            panaLaL.TextAlign = ContentAlignment.MiddleRight;

            panaLaT.Font = new Font("Calibri", 14, FontStyle.Bold);
            panaLaT.Location = new Point(this.main.Width / 2 + 10, 100);
            panaLaT.Size = new Size(150, 30);
        }

        public void OpKmF(TextBox kmT, Label kmL)
        {
            kmL.Text = "Kilometri (>=val)";
            kmL.Font = new Font("Calibri", 14, FontStyle.Bold);
            kmL.Location = new Point(this.main.Width / 2 - 230, 140);
            kmL.Size = new Size(220, 30);
            kmL.TextAlign = ContentAlignment.MiddleRight;

            kmT.Font = new Font("Calibri", 14, FontStyle.Bold);
            kmT.Location = new Point(this.main.Width / 2 + 10, 140);
            kmT.Size = new Size(150, 30);
        }

        public void OpPretF(TextBox pretT, Label pretL)
        {
            pretL.Text = "Pretul (>=val)";
            pretL.Font = new Font("Calibri", 14, FontStyle.Bold);
            pretL.Location = new Point(this.main.Width / 2 - 160, 180);
            pretL.Size = new Size(150, 30);
            pretL.TextAlign = ContentAlignment.MiddleRight;

            pretT.Font = new Font("Calibri", 14, FontStyle.Bold);
            pretT.Location = new Point(this.main.Width / 2 + 10, 180);
            pretT.Size = new Size(150, 30);
        }

        public void OpStF(TextBox stT, Label stL)
        {
            stL.Text = "Statusul (da/nu)";
            stL.Font = new Font("Calibri", 14, FontStyle.Bold);
            stL.Location = new Point(this.main.Width / 2 - 160, 220);
            stL.Size = new Size(150, 30);
            stL.TextAlign = ContentAlignment.MiddleRight;

            stT.Font = new Font("Calibri", 14, FontStyle.Bold);
            stT.Location = new Point(this.main.Width / 2 + 10, 220);
            stT.Size = new Size(150, 30);
        }

        public void OpSoferF(TextBox deLaT, Label deLaL)
        {
            deLaL.Text = "Soferul";
            deLaL.Font = new Font("Calibri", 14, FontStyle.Bold);
            deLaL.Location = new Point(this.main.Width / 2 - 160, 260);
            deLaL.Size = new Size(150, 30);
            deLaL.TextAlign = ContentAlignment.MiddleRight;

            deLaT.Font = new Font("Calibri", 14, FontStyle.Bold);
            deLaT.Location = new Point(this.main.Width / 2 + 10, 260);
            deLaT.Size = new Size(150, 30);
        }
    }
}
