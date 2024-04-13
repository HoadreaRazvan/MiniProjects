using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inchiriere_Masina_2
{
    public class ControlMasina
    {
        public List<Masina> masini;

        public ControlMasina()
        {
            masini = new List<Masina>();
        }

        public void load()
        {
            String path = Application.StartupPath + @"/masina.txt";
            StreamReader fisier = new StreamReader(path);
            string linie = fisier.ReadLine();        
            while(linie.Equals("stop")==false)
            {
                string[] part = linie.Split(',');
                string marca = part[0];
                int ani = int.Parse(part[1]);
                int km = int.Parse(part[2]);
                string combustibil = part[3];
                string pret = part[4];
                int status = int.Parse(part[5]);
                string nume = part[6];
                masini.Add(new Masina(marca, ani, km, combustibil, pret, status, nume));
                linie = fisier.ReadLine();
            }
            fisier.Close();
        }

        public void save()
        {
            String path = Application.StartupPath + @"/masina.txt";
            StreamWriter fisier = new StreamWriter(path);
            foreach(Masina masina in masini)
                fisier.WriteLine(masina.descMasina());
            fisier.WriteLine("stop");
            fisier.Close();
        }

        public void testAfisare()
        {
            foreach(Masina masina in masini)
                Console.WriteLine(masina.descMasina());
        }

        public void afisareTabel(ListView tabel)
        {
            tabel.Clear();
            load();
            tabel.Columns.Add("Marca", 100, HorizontalAlignment.Center);
            tabel.Columns.Add("Ani", 100, HorizontalAlignment.Center);
            tabel.Columns.Add("Kilometraj", 100, HorizontalAlignment.Center);
            tabel.Columns.Add("Combustibil", 100, HorizontalAlignment.Center);
            tabel.Columns.Add("Pret", 100, HorizontalAlignment.Center);
            tabel.Columns.Add("Status", 100, HorizontalAlignment.Center);
            tabel.Columns.Add("Numele Clientului", 100, HorizontalAlignment.Center);
            foreach(Masina masina in masini)
            {
                ListViewItem linie = new ListViewItem();
                linie.Text = masina.marca;
                linie.SubItems.Add(masina.ani.ToString());
                linie.SubItems.Add(masina.km.ToString());
                linie.SubItems.Add(masina.combustibil.ToString());
                linie.SubItems.Add(masina.pret.ToString());
                linie.SubItems.Add(masina.inchiriata.ToString());
                linie.SubItems.Add(masina.nume.ToString());
                tabel.Items.Add(linie);
            }
        }

        public void adaugare(TextBox marca,TextBox ani,TextBox km ,TextBox combustibil ,TextBox pret)
        {
            load();
            masini.Add(new Masina(marca.Text, int.Parse(ani.Text), int.Parse(km.Text), combustibil.Text, pret.Text,0,"null"));
            save();         
        }







    }
}
