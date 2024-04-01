using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Biblioteca_Dinamic
{
    public class ControlCarte
    {
        private List<Carte> carti;

        public List<Carte> Carti
        {
            get => this.carti;
            set => this.carti = value;    
        }


        public ControlCarte()
        {
            carti = new List<Carte>();
            load();
        }

        public void load()
        {
            string path = Application.StartupPath + @"/carti.txt";
            StreamReader fisier = new StreamReader(path);
            string linie = fisier.ReadLine();
            while(!linie.Equals("stop"))
            {
                string[] p = linie.Split(',');
                string titlul = p[0];
                string autor = p[1];
                int pret = int.Parse(p[2]);
                int status = int.Parse(p[3]);
                string client = p[4];
                carti.Add(new Carte(titlul,autor,pret,status,client));
                linie = fisier.ReadLine();
            }
            fisier.Close();
        }

        public void save()
        {
            string path = Application.StartupPath + @"/carti.txt";
            StreamWriter fisier = new StreamWriter(path);
            foreach(Carte carte in carti)
                fisier.WriteLine(carte.save());
            fisier.WriteLine("stop");
            fisier.Close();
        }

        public void adaugare(string titlul,string autor,int pret)
        {
            carti.Add(new Carte(titlul, autor, pret, 0, "Disponibil"));
            save();
        }

        public int pozCarte(string titlul)
        {
            int k = 0;
            foreach (Carte carte in carti)            
                if (carte.Titlul.ToLower().Equals(titlul.ToLower())==true && k++!=-1)
                    return k;         
            return -1;

        }

        public void stergere(string titlul)
        {           
            carti.RemoveAt(pozCarte(titlul)-1);
            save();
        }

        public void modificare(string titlul,string autor,string pret,string dupaCe)
        {
            for(int i=0;i<carti.Count;i++)
            {
                if(i==pozCarte(dupaCe)-1)
                {
                    if (titlul != "")
                        carti[i].Titlul = titlul;
                    if (autor != "")
                        carti[i].Autor = autor;
                    if (pret != "")
                        carti[i].Pret = int.Parse(pret);
                }
            }         
            save();
        }

    }
}
