using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dinamic
{
    public class Carte
    {
        private string titlul;
        private string autor;
        private int pret;
        private int status;
        private string client;

        public Carte(string titlul,string autor,int pret,int status,string client)
        {
            this.titlul = titlul;
            this.autor = autor;
            this.pret = pret;
            this.status = status;
            this.client = client;
        }

        public string Titlul
        {
            get => this.titlul;
            set => this.titlul = value;
        }

        public string Autor
        {
            get => this.autor;
            set => this.autor = value;
        }

        public int Pret
        {
            get => this.pret;
            set => this.pret = value;
        }

        public int Status
        {
            get => this.status;
            set => this.status = value;
        }

        public string Client
        {
            get => this.client;
            set => this.client = value;
        }

        public string save()
        {
            return this.titlul + "," + this.autor + "," + this.pret + "," + this.status + "," + this.client;
        }
    }
}
