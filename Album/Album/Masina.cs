using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album
{
    public class Masina
    {
        public string nume;
        public int km;
        public double pret;
        public bool inchiriata = false;
        public String numeClient;

       public  Masina(string nume,int km,double pret, bool inchiriata,String numeClient)
        {
            this.nume = nume;
            this.km = km;
            this.pret = pret;         
            this.inchiriata = inchiriata;
            this.numeClient = numeClient;
        }

        public string desc()
        {
            return "Numele masini: " + this.nume + "\nKilometri: " + this.km + "\nPret: " + this.pret + "\nStatus: " + this.inchiriata + "\nNumele clientului: " + this.numeClient;
        }
        public string toSave()
        {
            return this.nume + "," + this.km + "," + this.pret + "," + (this.inchiriata==true?1:0) + "," + this.numeClient;
        }
    }
}
