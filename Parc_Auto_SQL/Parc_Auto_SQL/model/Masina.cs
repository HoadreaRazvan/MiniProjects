using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public class Masina : IComparable
    {
        private int id, km, pret;
        string marca, model;

        public Masina() { }
        public Masina(int id,string marca,string model,int km,int pret)
        {
            this.id = id;
            this.marca = marca;
            this.model = model;
            this.km = km;
            this.pret = pret;
        }
        public Masina(string marca, string model, int km, int pret)
        {
            this.marca = marca;
            this.model = model;
            this.km = km;
            this.pret = pret;
        }


        public override string ToString() => this.id + "," + this.marca + "," + this.model + "," + this.km + "," + this.pret;
        public override bool Equals(object obj) => (obj as Masina).Marca.Equals(this.marca) && (obj as Masina).model.Equals(this.model);
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public int Km
        {
            get => this.km;
            set => this.km = value;
        }
        public int Pret
        {
            get => this.pret;
            set => this.pret = value;
        }
        public string Model
        {
            get => this.model;
            set => this.model = value;
        }
        public string Marca
        {
            get => this.marca;
            set => this.marca = value;
        }
    }
}
