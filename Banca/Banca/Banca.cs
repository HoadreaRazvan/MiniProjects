using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    public class Banca
    {
        private string banca;
        private string moneda;
        private int iban;
        private int pin;
        private int status;
        private string client;

        public Banca(string banca, string moneda, int iban, int pin, int status, string client)
        {
            this.banca = banca;
            this.moneda = moneda;
            this.iban = iban;
            this.pin = pin;
            this.status = status;
            this.client = client;
        }

        public string Bancaa
        {
            get => this.banca;
            set => this.banca = value;
        }

        public string Moneda
        {
            get => this.moneda;
            set => this.moneda = value;
        }

        public int Iban
        {
            get => this.iban;
            set => this.iban = value;
        }

        public int Pin
        {
            get => this.pin;
            set => this.pin = value;
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
            return this.banca + "," + this.moneda + "," + this.iban + "," + this.pin + "," + this.status + "," + this.client;
        }
    }
}
