using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Curse_TIR
{
    public class ControlCursa
    {
        private List<Cursa> curse;

        public List<Cursa> Curse
        {
            get => this.curse;
            set => this.curse = value;
        }

        public ControlCursa()
        {
            this.curse = new List<Cursa>();
            load();
        }


        //Load Save

        public void load()
        {
            StreamReader fisier = new StreamReader(Application.StartupPath + @"/cursa.txt");
            string linie = fisier.ReadLine();
            while (!linie.Equals("stop"))
            {
                string[] prop = linie.Split(',');
                this.curse.Add(new Cursa(prop[0], prop[1], int.Parse(prop[2]), int.Parse(prop[3]), int.Parse(prop[4]), prop[5]));
                linie = fisier.ReadLine();
            }
            fisier.Close();
        }

        public void save()
        {
            StreamWriter fisier = new StreamWriter(Application.StartupPath + @"/cursa.txt");
            foreach (Cursa cursa in this.curse)
                fisier.WriteLine(cursa.save());
            fisier.WriteLine("stop");
            fisier.Close();
        }


        //CRUD

        public void adaugare(string deLa, string panaLa, int km, int pret)
        {
            this.curse.Add(new Cursa(deLa, panaLa, km, pret, 0, "Liber"));
            save();
        }

        public void stergere(string deLa)
        {
            this.curse.RemoveAt(pozCursa(deLa));
            save();
        }

        public void modificare(string deLa, string panaLa, string km, string pret, string numeC)
        {
            foreach (Cursa cursa in this.curse)
                if (cursa.DeLa.ToLower() == numeC.ToLower())
                {
                    if (deLa.ToLower() != "")
                        cursa.DeLa = deLa;
                    if (panaLa.ToLower() != "")
                        cursa.PanaLa = panaLa;
                    if (km.ToString().ToLower() != "")
                        cursa.Km = int.Parse(km);
                    if (pret.ToString().ToLower() != "")
                        cursa.Pret = int.Parse(pret);
                }
            save();
        }


        //TRANZACTII

        public void inchiriere(string deLa, string sofer)
        {
            foreach (Cursa cursa in this.curse)
                if (cursa.DeLa.ToLower() == deLa.ToLower())
                {
                    cursa.Status = 1;
                    cursa.Sofer = sofer;
                }
            save();
        }

        public void returnare(string deLa, string sofer)
        {
            foreach (Cursa cursa in this.curse)
                if (cursa.DeLa.ToLower() == deLa.ToLower())
                {
                    cursa.Status = 0;
                    cursa.Sofer = "Liber";
                }
            save();
        }


        //Functii

        public int pozCursa(string deLa)
        {
            int k = 0;
            foreach (Cursa cursa in this.curse)
            {
                if (cursa.DeLa.ToLower() == deLa.ToLower())
                    return k;
                k++;
            }
            return -1;
        }

        public bool verfStatus(string deLa)
        {
            foreach (Cursa cursa in this.curse)
                if (cursa.DeLa.ToLower() == deLa.ToLower())
                    return cursa.Status == 1 ? true : false;
            return false;
        }

        public bool verfRetur(string deLa, string sofer)
        {
            foreach (Cursa cursa in this.curse)
                if (cursa.DeLa.ToLower() == deLa.ToLower() && cursa.Sofer.ToLower() == sofer.ToLower() && cursa.Status == 1)
                    return true;
            return false;
        }


        //FILTRE

        public List<Cursa> filtrDeLa(List<Cursa> lista, string deLa)
        {
            if (deLa != "")
            {
                List<Cursa> nou = new List<Cursa>();
                foreach (Cursa cursa in lista)
                    if (cursa.DeLa.ToLower() == deLa.ToLower())
                        nou.Add(new Cursa(cursa.DeLa, cursa.PanaLa, cursa.Pret, cursa.Km, cursa.Status, cursa.Sofer));
                return nou;
            }
            return lista;
        }

        public List<Cursa> filtrPanaLa(List<Cursa> lista, string panaLa)
        {
            if (panaLa != "")
            {
                List<Cursa> nou = new List<Cursa>();
                foreach (Cursa cursa in lista)
                    if (cursa.PanaLa.ToLower() == panaLa.ToLower())
                        nou.Add(new Cursa(cursa.DeLa, cursa.PanaLa, cursa.Pret, cursa.Km, cursa.Status, cursa.Sofer));
                return nou;
            }
            return lista;
        }

        public List<Cursa> filtrKm(List<Cursa> lista, string start)
        {
            if (start != "")
            {
                List<Cursa> nou = new List<Cursa>();
                foreach (Cursa cursa in lista)
                    if (cursa.Km >= int.Parse(start))
                        nou.Add(new Cursa(cursa.DeLa, cursa.PanaLa, cursa.Pret, cursa.Km, cursa.Status, cursa.Sofer));
                return nou;
            }
            return lista;
        }

        public List<Cursa> filtrPret(List<Cursa> lista, string start)
        {
            if (start != "")
            {
                List<Cursa> nou = new List<Cursa>();
                foreach (Cursa cursa in lista)
                    if (cursa.Pret >= int.Parse(start))
                        nou.Add(new Cursa(cursa.DeLa, cursa.PanaLa, cursa.Pret, cursa.Km, cursa.Status, cursa.Sofer));
                return nou;
            }
            return lista;
        }

        public List<Cursa> filtrStatus(List<Cursa> lista, string status)
        {
            if (status != "")
            {
                List<Cursa> nou = new List<Cursa>();
                foreach (Cursa cursa in lista)
                {
                    int st = status.ToLower() == "da" ? 1 : 0;
                    if (cursa.Status == st)
                        nou.Add(new Cursa(cursa.DeLa, cursa.PanaLa, cursa.Pret, cursa.Km, cursa.Status, cursa.Sofer));
                }
                return nou;
            }
            return lista;
        }

        public List<Cursa> filtrSofer(List<Cursa> lista, string sofer)
        {
            if (sofer != "")
            {
                List<Cursa> nou = new List<Cursa>();
                foreach (Cursa cursa in lista)
                    if (cursa.Sofer.ToLower() == sofer.ToLower())
                        nou.Add(new Cursa(cursa.DeLa, cursa.PanaLa, cursa.Pret, cursa.Km, cursa.Status, cursa.Sofer));
                return nou;
            }
            return lista;
        }
    }
}
