using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Banca
{
    public class ControlBanca
    {
        private List<Banca> banci;

        public List<Banca> Banci
        {
            get => this.banci;
            set => this.banci = value;
        }

        public ControlBanca()
        {
            this.banci = new List<Banca>();
            load();
        }

        public void load()
        {
            string path = Application.StartupPath + @"/banca.txt";
            StreamReader fisier = new StreamReader(path);
            string linie = fisier.ReadLine();
            while (!linie.Equals("stop"))
            {
                string[] prop = linie.Split(',');
                string banca = prop[0];
                string moneda = prop[1];
                int iban = int.Parse(prop[2]);
                int pin = int.Parse(prop[3]);
                int status = int.Parse(prop[4]);
                string client = prop[5];
                this.banci.Add(new Banca(banca, moneda, iban, pin, status, client));
                linie = fisier.ReadLine();
            }
            fisier.Close();
        }

        public void save()
        {
            string path = Application.StartupPath + @"/banca.txt";
            StreamWriter fisier = new StreamWriter(path);
            foreach (Banca banca in this.banci)
                fisier.WriteLine(banca.save());
            fisier.WriteLine("stop");
            fisier.Close();
        }

        public void adaugare(string banca, string moneda, int iban, int pin)
        {
            this.banci.Add(new Banca(banca, moneda, iban, pin, 0, "Disponibil"));
            save();
        }

        public int pozBanca(string bancaa)
        {
            int k = 0;
            foreach (Banca banca in this.banci)
            {
                if (banca.Bancaa.ToLower() == bancaa.ToLower())
                    return k;
                k++;
            }
            return -1;
        }

        public void stergere(string banca)
        {
            this.banci.RemoveAt(pozBanca(banca));
            save();
        }

        public void modificare(string bancaa, string moneda, string iban, string pin, string numeC)
        {
            foreach (Banca banca in this.banci)
                if (banca.Bancaa.ToLower() == numeC.ToLower())
                {
                    if (bancaa.ToLower() != "")
                        banca.Bancaa = bancaa;
                    if (moneda.ToLower() != "")
                        banca.Moneda = moneda;
                    if (iban.ToString().ToLower() != "")
                        banca.Iban = int.Parse(iban);
                    if (pin.ToString().ToLower() != "")
                        banca.Pin = int.Parse(pin);
                }
            save();
        }

        public bool verfStatus(string bancaa)
        {
            foreach (Banca banca in this.banci)
                if (banca.Bancaa.ToLower() == bancaa.ToLower())
                    return banca.Status == 1 ? true : false;
            return false;
        }

        public void inchiriere(string bancaa, string client)
        {
            foreach (Banca banca in this.banci)
                if (banca.Bancaa.ToLower() == bancaa.ToLower())
                {
                    banca.Status = 1;
                    banca.Client = client;
                }
            save();
        }

        public void returnare(string bancaa, string client)
        {
            foreach (Banca banca in this.banci)
                if (banca.Bancaa.ToLower() == bancaa.ToLower())
                {
                    banca.Status = 0;
                    banca.Client = "Disponibil";
                }
            save();
        }

        public bool verfRetur(string bancaa, string client)
        {
            foreach (Banca banca in this.banci)
                if (banca.Bancaa.ToLower() == bancaa.ToLower() && banca.Client.ToLower() == client.ToLower() && banca.Status == 1)
                    return true;
            return false;
        }

        public void afisareTabel(ListView tabel)
        {
            tabel.Clear();
            tabel.Columns.Add("Banca", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Moneda", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("IBAN", tabel.Width / 6 - 4 + 1 / 2, HorizontalAlignment.Center);
            tabel.Columns.Add("Pinul", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Status", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Nume Client", tabel.Width / 6, HorizontalAlignment.Center);
            foreach (Banca banca in this.banci)
            {
                ListViewItem linie = new ListViewItem();
                linie.Text = banca.Bancaa;
                linie.SubItems.Add(banca.Moneda);
                linie.SubItems.Add(banca.Iban.ToString());
                linie.SubItems.Add(banca.Pin.ToString());
                linie.SubItems.Add(banca.Status == 1 ? "Da" : "Nu");
                linie.SubItems.Add(banca.Client);
                tabel.Items.Add(linie);
            }
        }

        public void tabelAfisare(ListView tabel, List<Banca> nou)
        {
            tabel.Clear();
            tabel.Columns.Add("Banca", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Moneda", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("IBAN", tabel.Width / 6 - 4 + 1 / 2, HorizontalAlignment.Center);
            tabel.Columns.Add("Pinul", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Status", tabel.Width / 6, HorizontalAlignment.Center);
            tabel.Columns.Add("Nume Client", tabel.Width / 6, HorizontalAlignment.Center);
            foreach (Banca banca in nou)
            {
                ListViewItem linie = new ListViewItem();
                linie.Text = banca.Bancaa;
                linie.SubItems.Add(banca.Moneda);
                linie.SubItems.Add(banca.Iban.ToString());
                linie.SubItems.Add(banca.Pin.ToString());
                linie.SubItems.Add(banca.Status == 1 ? "Da" : "Nu");
                linie.SubItems.Add(banca.Client);
                tabel.Items.Add(linie);
            }
        }

        public List<Banca> filtrBancaa(List<Banca> lista, string bancaa)
        {
            if (bancaa != "")
            {
                List<Banca> nou = new List<Banca>();
                foreach (Banca banca in lista)
                    if (banca.Bancaa.ToLower() == bancaa.ToLower())
                        nou.Add(new Banca(banca.Bancaa, banca.Moneda, banca.Pin, banca.Iban, banca.Status, banca.Client));
                return nou;
            }
            return lista;
        }

        public List<Banca> filtrMoneda(List<Banca> lista, string moneda)
        {
            if (moneda != "")
            {
                List<Banca> nou = new List<Banca>();
                foreach (Banca banca in lista)
                    if (banca.Moneda.ToLower() == moneda.ToLower())
                        nou.Add(new Banca(banca.Bancaa, banca.Moneda, banca.Pin, banca.Iban, banca.Status, banca.Client));
                return nou;
            }
            return lista;
        }



        public List<Banca> filtrIban(List<Banca> lista, string start)
        {
            if (start != "")
            {
                List<Banca> nou = new List<Banca>();
                foreach (Banca banca in lista)
                    if (banca.Iban >= int.Parse(start))
                        nou.Add(new Banca(banca.Bancaa, banca.Moneda, banca.Pin, banca.Iban, banca.Status, banca.Client));
                return nou;
            }
            return lista;
        }

        public List<Banca> filtrPin(List<Banca> lista, string start)
        {
            if (start != "")
            {
                List<Banca> nou = new List<Banca>();
                foreach (Banca banca in lista)
                    if (banca.Pin >= int.Parse(start))
                        nou.Add(new Banca(banca.Bancaa, banca.Moneda, banca.Pin, banca.Iban, banca.Status, banca.Client));
                return nou;
            }
            return lista;
        }

        public List<Banca> filtrStatus(List<Banca> lista, string status)
        {
            if (status != "")
            {
                List<Banca> nou = new List<Banca>();
                foreach (Banca banca in lista)
                {
                    int st = status.ToLower() == "da" ? 1 : 0;
                    if (banca.Status == st)
                        nou.Add(new Banca(banca.Bancaa, banca.Moneda, banca.Pin, banca.Iban, banca.Status, banca.Client));
                }
                return nou;
            }
            return lista;
        }

        public List<Banca> filtrClient(List<Banca> lista, string client)
        {
            if (client != "")
            {
                List<Banca> nou = new List<Banca>();
                foreach (Banca banca in lista)
                    if (banca.Client.ToLower() == client.ToLower())
                        nou.Add(new Banca(banca.Bancaa, banca.Moneda, banca.Pin, banca.Iban, banca.Status, banca.Client));
                return nou;
            }
            return lista;
        }
    }
}
