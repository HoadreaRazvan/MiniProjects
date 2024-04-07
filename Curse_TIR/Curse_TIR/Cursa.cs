using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curse_TIR
{
    public class Cursa
    {
        private string deLa;
        private string panaLa;
        private int km;
        private int pret;
        private int status;
        private string sofer;

        public Cursa(string deLa, string panaLa, int km, int pret, int status, string sofer)
        {
            this.deLa = deLa;
            this.panaLa = panaLa;
            this.km = km;
            this.pret = pret;
            this.status = status;
            this.sofer = sofer;
        }

        public string save() => this.deLa + "," + this.panaLa + "," + this.km + "," + this.pret + "," + this.status + "," + this.sofer;

        public string DeLa
        {
            get => this.deLa;
            set => this.deLa = value;
        }

        public string PanaLa
        {
            get => this.panaLa;
            set => this.panaLa = value;
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

        public int Status
        {
            get => this.status;
            set => this.status = value;
        }

        public string Sofer
        {
            get => this.sofer;
            set => this.sofer = value;
        }
    }
}
