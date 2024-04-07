using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Curse_TIR
{
    public class ControlAfisare
    {
        private Panel main;
        private Panel footer;
        private ControlCursa control;

        public ControlAfisare(Panel main,Panel footer,ControlCursa control)
        {
            this.control = control;
            this.main = main;
            this.footer = footer;
        }

        public void start()
        {
            this.main.Controls.Clear();
            this.footer.Controls.Clear();
            layoutAfisare();
        }

        public void layoutAfisare()
        {
            ListView tabel = new ListView();
            tabelAfisare(tabel, control.Curse);
            this.main.Controls.Add(tabel);

            Button iesire = new Button();
            BtnIesireA(iesire);
            this.footer.Controls.Add(iesire);
        }

        public void BtnIesireA(Button iesire)
        {
            iesire.Text = "Iesire";
            iesire.Font = new Font("Calibri", 14, FontStyle.Bold);
            iesire.Location = new Point(this.footer.Width / 2 - this.footer.Width / 4, 0);
            iesire.Size = new Size(this.footer.Width / 2, this.footer.Height / 2);
            iesire.Click += new EventHandler(iesireA_Click);
        }

        public void iesireA_Click(object sender, EventArgs e)
        {
            this.main.Controls.Clear();
            this.footer.Controls.Clear();
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
    }
}
