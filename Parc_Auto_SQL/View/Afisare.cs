using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using App;

namespace View
{
    public class Afisare: Panel
    {
        private MasinaRepository control;

        public Afisare()
        {
            this.control = new MasinaRepository();
            layouts();
        }
        
        public void layouts()
        {
            this.Size = new Size(700, 700);
            tabel(new ListView(), this.control.getAll());
        }

        public void tabel(ListView tabel, List<Masina> lista)
        {
            tabel.GridLines = true;
            tabel.View = System.Windows.Forms.View.Details;
            tabel.BackColor = Color.Gray;
            tabel.Size = new Size(this.Width, this.Height);
            tabel.Clear();
            tabel.Columns.Add("", 1, HorizontalAlignment.Center);
            tabel.Columns.Add("Id", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Marca", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Model", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Pret", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Km", tabel.Width / 6, HorizontalAlignment.Center);
            foreach (Masina masina in lista)
            {
                ListViewItem linie = new ListViewItem();
                linie.SubItems.Add(masina.Id.ToString());
                linie.SubItems.Add(masina.Marca);
                linie.SubItems.Add(masina.Model);
                linie.SubItems.Add(masina.Pret.ToString());
                linie.SubItems.Add(masina.Km.ToString());
                tabel.Items.Add(linie);
            }
            this.Controls.Add(tabel);
        }


    }
}
