using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Controls;

namespace Front_end
{
    public class Afisare :Panel
    {
        private MasinaRepository control;
        public Afisare()
        {
            this.control = new MasinaRepository();
            layouts();
        }

        public void layouts()
        {
            this.Size = new Size(450, 350);
            ListView tabel = new ListView();
            tabelAfisare(tabel, control.getAll());
            this.Controls.Add(tabel);
        }

        public void tabelAfisare(ListView tabel, List<Masina> nou)
        {
            tabel.GridLines = true;
            tabel.View = View.Details;
            tabel.BackColor = Color.Gray;
            tabel.Size = new Size(this.Width, this.Height);
            tabel.Clear();
            tabel.Columns.Add("", 1, HorizontalAlignment.Center);
            tabel.Columns.Add("Marca", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Model", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Kilometri", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Pretul", tabel.Width / 6, HorizontalAlignment.Center);
            foreach (Masina masina in nou)
            {
                ListViewItem linie = new ListViewItem();
                linie.SubItems.Add(masina.Marca);
                linie.SubItems.Add(masina.Model);
                linie.SubItems.Add(masina.Km.ToString());
                linie.SubItems.Add(masina.Pret.ToString());
                tabel.Items.Add(linie);
            }
        }

    }
}
