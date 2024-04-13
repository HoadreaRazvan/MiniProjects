using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchiriere_Masina_2
{
    public class Masina
    {
        public string marca;
        public int ani;
        public int km;
        public string combustibil;
        public string pret;
        public bool inchiriata;
        public string nume;

        public Masina(string marca,int ani,int km,string combustibil,string pret,int status,string nume)
        {
            this.marca = marca;
            this.ani = ani;
            this.km = km;
            this.combustibil = combustibil;
            this.pret = pret;
            this.inchiriata = status == 1 ? true : false;
            this.nume = nume;
        }

        public string descMasina()
        {
            string text = "";
            text = this.marca;
            text += "," + this.ani;
            text += "," + this.km;
            text += "," + this.combustibil;
            text += "," + this.pret;
            int status1 = this.inchiriata == true ? 1 : 0;
            text += "," + status1;
            text += "," + this.nume;
            return text;
        }
       
    }
}
