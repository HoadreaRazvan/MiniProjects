using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banca
{
    public class ControlView
    {
        private Panel prop;
        private Panel operatii;
        private Panel meniu;
        private ListView afisareP;
        private Button afisare;
        private Button adaugare;
        private Button stergere;
        private Button modificare;
        private Button inchiriere;
        private Button returnare;
        private Button filtrare;
        private Button iesi;
        private Button trimitere;
        private Button revenire;
        private Label bancaL;
        private Label monedaL;
        private Label ibanL;
        private Label pinL;
        private Label clientL;
        private Label bancaLC;
        private TextBox bancaT;
        private TextBox monedaT;
        private TextBox ibanT;
        private TextBox pinT;
        private TextBox clientT;
        private TextBox bancaTC;
        private TextBox statusT;
        private Label unde;
        private Label info;
        private Label statusL;
        public int fX;
        public int fY;
        public int ok;
        public int mb = 0;//Aici nu stiu cum sa fac sa nu imi mai spameze cu acel messagebox

        public ControlView() { }

        public ControlView(Panel prop, Panel operatii, Panel meniu, ListView afisareP, Button afisare, Button adaugare, Button stergere, Button modificare, Button inchiriere, Button returnare, Button filtrare, Button iesi, Button trimitere, Label bancaL, Label monedaL, Label ibanL, Label pinL, Label clientL, Label bancaLC, TextBox bancaT, TextBox monedaT, TextBox ibanT, TextBox pinT, TextBox clientT, TextBox bancaTC, int fX, int fY, Label unde, Label info, Label statusL, TextBox statusT, Button revenire)
        {
            this.revenire = revenire;
            this.statusL = statusL;
            this.statusT = statusT;
            this.unde = unde;
            this.info = info;
            this.prop = prop;
            this.operatii = operatii;
            this.meniu = meniu;
            this.afisareP = afisareP;
            this.afisare = afisare;
            this.adaugare = adaugare;
            this.stergere = stergere;
            this.modificare = modificare;
            this.inchiriere = inchiriere;
            this.returnare = returnare;
            this.filtrare = filtrare;
            this.iesi = iesi;
            this.trimitere = trimitere;
            this.bancaL = bancaL;
            this.monedaL = monedaL;
            this.ibanL = ibanL;
            this.pinL = pinL;
            this.clientL = clientL;
            this.bancaLC = bancaLC;
            this.bancaT = bancaT;
            this.monedaT = monedaT;
            this.ibanT = ibanT;
            this.pinT = pinT;
            this.clientT = clientT;
            this.bancaTC = bancaTC;
            this.fX = fX;
            this.fY = fY;
        }

        public void clear()
        {
            this.meniu.Controls.Clear();
            this.operatii.Controls.Clear();
            this.bancaT.Text = "";
            this.monedaT.Text = "";
            this.ibanT.Text = "";
            this.pinT.Text = "";
            this.bancaTC.Text = "";
            this.clientT.Text = "";
            this.ok = 0;
        }

        public void clearT()
        {
            this.bancaT.Text = "";
            this.monedaT.Text = "";
            this.ibanT.Text = "";
            this.pinT.Text = "";
            this.clientT.Text = "";
            this.bancaTC.Text = "";
        }

        public void principal()
        {
            BtnPanel();
            BtnPropr();
        }

        public void BtnPanel()
        {
            this.prop.Location = new Point(12, 12);
            this.prop.Size = new Size(this.fX / 4, this.fY / 2 + this.fY / 6);
            this.operatii.Location = new Point(12, this.fY / 2 + this.fY / 6 + 24);
            this.operatii.Size = new Size(this.fX / 4, this.fY - this.fY / 2 - this.fY / 6 - 75);
            this.meniu.Location = new Point(this.fX / 4 + 24, 12);
            this.meniu.Size = new Size(this.fX - this.fX / 4 - 51, this.fY - 63);
        }

        public void BtnPropr()
        {
            this.afisare.Text = "Afisare";
            this.adaugare.Text = "Adaugare";
            this.stergere.Text = "Stergere";
            this.modificare.Text = "Modificare";
            this.inchiriere.Text = "Inchiriere";
            this.returnare.Text = "Returnare";
            this.filtrare.Text = "Filtrare";
            this.afisare.Font = new Font("Sylfaen", 12, FontStyle.Bold);
            this.adaugare.Font = new Font("Sylfaen", 12, FontStyle.Bold);
            this.stergere.Font = new Font("Sylfaen", 12, FontStyle.Bold);
            this.modificare.Font = new Font("Sylfaen", 12, FontStyle.Bold);
            this.inchiriere.Font = new Font("Sylfaen", 12, FontStyle.Bold);
            this.returnare.Font = new Font("Sylfaen", 12, FontStyle.Bold);
            this.filtrare.Font = new Font("Sylfaen", 12, FontStyle.Bold);
            this.afisare.Location = new Point(0, 0);
            this.adaugare.Location = new Point(0, (this.fY / 2 + this.fY / 6) / 7);
            this.stergere.Location = new Point(0, ((this.fY / 2 + this.fY / 6) / 7) * 2);
            this.modificare.Location = new Point(0, ((this.fY / 2 + this.fY / 6) / 7) * 3);
            this.inchiriere.Location = new Point(0, ((this.fY / 2 + this.fY / 6) / 7) * 4);
            this.returnare.Location = new Point(0, ((this.fY / 2 + this.fY / 6) / 7) * 5);
            this.filtrare.Location = new Point(0, ((this.fY / 2 + this.fY / 6) / 7) * 6);
            this.afisare.Size = new Size(this.fX / 4, (this.fY / 2 + this.fY / 6) / 7);
            this.adaugare.Size = new Size(this.fX / 4, (this.fY / 2 + this.fY / 6) / 7);
            this.stergere.Size = new Size(this.fX / 4, (this.fY / 2 + this.fY / 6) / 7);
            this.modificare.Size = new Size(this.fX / 4, (this.fY / 2 + this.fY / 6) / 7);
            this.inchiriere.Size = new Size(this.fX / 4, (this.fY / 2 + this.fY / 6) / 7);
            this.returnare.Size = new Size(this.fX / 4, (this.fY / 2 + this.fY / 6) / 7);
            this.filtrare.Size = new Size(this.fX / 4, (this.fY / 2 + this.fY / 6) / 7);
            this.afisare.Click += new EventHandler(afisare_Click);
            this.adaugare.Click += new EventHandler(adaugare_Click);
            this.stergere.Click += new EventHandler(stergere_Click);
            this.modificare.Click += new EventHandler(modificare_Click);
            this.inchiriere.Click += new EventHandler(inchiriere_Click);
            this.returnare.Click += new EventHandler(returnare_Click);
            this.filtrare.Click += new EventHandler(filtrare_Click);
            this.prop.Controls.Add(afisare);
            this.prop.Controls.Add(adaugare);
            this.prop.Controls.Add(stergere);
            this.prop.Controls.Add(modificare);
            this.prop.Controls.Add(inchiriere);
            this.prop.Controls.Add(returnare);
            this.prop.Controls.Add(filtrare);
        }

        public void afisare_Click(object sender, EventArgs e)
        {
            clear();
            tabel();
            BtnIesi();
        }

        public void adaugare_Click(object sender, EventArgs e)
        {
            clear();
            this.ok = 1;
            BtnIesi();
            BtnTrimitere();
            OpBancaa();
            OpMoneda();
            OpIban();
            OpPin();
            OpUndeInfo("ADAUGARE", "Introduceti urmatoarele caracteristici!");
        }

        public void stergere_Click(object sender, EventArgs e)
        {
            clear();
            this.ok = 2;
            BtnIesi();
            BtnTrimitere();
            OpBancaa();
            OpUndeInfo("STERGERE", "Introduceti urmatoarele caracteristici!");
        }

        public void modificare_Click(object sender, EventArgs e)
        {
            clear();
            this.ok = 3;
            BtnIesi();
            BtnTrimitere();
            OpBancaa();
            OpBancaaC();
            OpMoneda();
            OpIban();
            OpPin();
            OpUndeInfo("MODIFICARE", "Introduceti urmatoarele caracteristici!");
        }

        public void inchiriere_Click(object sender, EventArgs e)
        {
            clear();
            this.ok = 4;
            BtnIesi();
            BtnTrimitere();
            OpUndeInfo("INCHIRIERE", "Introduceti urmatoarele caracteristici!");
            OpBancaa();
            OpClient();
        }

        public void returnare_Click(object sender, EventArgs e)
        {
            clear();
            this.ok = 5;
            BtnIesi();
            BtnTrimitere();
            OpUndeInfo("RETURNARE", "Introduceti urmatoarele caracteristici!");
            OpBancaa();
            OpClient();
        }

        public void filtrare_Click(object sender, EventArgs e)
        {
            clear();
            this.ok = 6;
            BtnIesi();
            BtnTrimitere();
            OpUndeInfo("FILTRARE", "Filtrati dupa urmatoarele caracteristici!\nDaca nu doriti sa filtrati lasati necompletata casuta respectiva!");
            OpBancaa();
            OpMoneda();
            OpIban();
            OpPin();
            OpStatus();
            OpClientN();
        }

        public void BtnIesi()
        {
            this.iesi.Text = "Iesire";
            this.iesi.Font = new Font("Sylfaen", 12, FontStyle.Bold);
            this.iesi.Location = new Point(0, this.operatii.Height / 2);
            this.iesi.Size = new Size(this.operatii.Width, this.operatii.Height / 2);
            this.iesi.Click += new EventHandler(iesi_Click);
            this.operatii.Controls.Add(iesi);
        }

        public void iesi_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void BtnTrimitere()
        {
            this.trimitere.Text = "Trimitere";
            this.trimitere.Font = new Font("Sylfaen", 12, FontStyle.Bold);
            this.trimitere.Location = new Point(0, 0);
            this.trimitere.Size = new Size(this.operatii.Width, this.operatii.Height / 2);
            if (ok == 1)
                this.trimitere.Click += new EventHandler(trimitereA_Click);
            if (ok == 2)
                this.trimitere.Click += new EventHandler(trimitereS_Click);
            if (ok == 3)
                this.trimitere.Click += new EventHandler(trimitereM_Click);
            if (ok == 4)
                this.trimitere.Click += new EventHandler(trimitereI_Click);
            if (ok == 5)
                this.trimitere.Click += new EventHandler(trimitereR_Click);
            if (ok == 6)
                this.trimitere.Click += new EventHandler(trimitereF_Click);
            this.operatii.Controls.Add(trimitere);
        }

        public void trimitereA_Click(object sender, EventArgs e)
        {
            if (bancaT.Text != "" && monedaT.Text != "" && ibanT.Text != "" && pinT.Text != "")
            {
                ControlBanca c = new ControlBanca();
                c.adaugare(bancaT.Text.ToString(), monedaT.Text.ToString(), int.Parse(ibanT.Text.ToString()), int.Parse(pinT.Text.ToString()));
                MessageBox.Show("ADAUGARE INFO: Adaugat cu succes!");
                clearT();
            }
            else
                if (this.mb == 1)
                MessageBox.Show("ADAUGARE INFO: Nu lasati spatii libere!");
        }

        public void trimitereS_Click(object sender, EventArgs e)
        {
            ControlBanca c = new ControlBanca();
            if (bancaT.Text != "" && c.pozBanca(bancaT.Text.ToString()) != -1)
            {
                c.stergere(bancaT.Text.ToString());
                MessageBox.Show("STERGERE INFO: Sters cu succes!");
                clearT();
            }
            else
                if (this.mb == 1)
                MessageBox.Show("STERGERE INFO: Aceasta banca nu exista!");
        }

        public void trimitereM_Click(object sender, EventArgs e)
        {
            ControlBanca c = new ControlBanca();
            if (c.pozBanca(bancaTC.Text.ToString()) != -1)
            {
                c.modificare(bancaT.Text.ToString(), monedaT.Text.ToString(), ibanT.Text.ToString(), pinT.Text.ToString(), bancaTC.Text.ToString());
                MessageBox.Show("MODIFICARE INFO: Modificat cu succes!");
                clearT();
            }
            else
                if (this.mb == 1)
                MessageBox.Show("MODIFICARE INFO: Aceasta banca nu exista!");
        }

        public void trimitereI_Click(object sender, EventArgs e)
        {
            ControlBanca c = new ControlBanca();
            if (c.verfStatus(this.bancaT.Text.ToString()) == false && this.clientT.Text != "")
            {
                c.inchiriere(this.bancaT.Text.ToString(), this.clientT.Text.ToString());
                MessageBox.Show("INCHIRIERE INFO: Inchiriata cu succes!");
                clearT();
            }
            else
                if (this.mb == 1)
                MessageBox.Show("INCHIRIERE INFO: Aceasta banca nu poate fi inchiriata!");
        }

        public void trimitereR_Click(object sender, EventArgs e)
        {
            ControlBanca c = new ControlBanca();
            if (c.verfRetur(this.bancaT.Text.ToString(), this.clientT.Text.ToString()))
            {
                c.returnare(this.bancaT.Text.ToString(), this.clientT.Text.ToString());
                MessageBox.Show("RETURNARE INFO: Returnata cu succes!");
                clearT();
            }
            else
                if (this.mb == 1)
                MessageBox.Show("RETURNARE INFO: Aceasta banca nu poate fi returnata!");

        }

        public void BtnRevenire()
        {
            this.revenire.Text = "Revenire";
            this.revenire.Font = new Font("Sylfaen", 12, FontStyle.Bold);
            this.revenire.Location = new Point(0, 0);
            this.revenire.Size = new Size(this.operatii.Width, this.operatii.Height / 2);
            BtnIesi();
            this.revenire.Click += new EventHandler(revenire_Click);
            this.operatii.Controls.Add(revenire);
        }

        public void revenire_Click(object sender, EventArgs e)
        {
            clear();
            BtnIesi();
            this.ok = 6;
            BtnTrimitere();
            OpUndeInfo("FILTRARE", "Filtrati dupa urmatoarele caracteristici!\nDaca nu doriti sa filtrati lasati necompletata casuta respectiva!");
            OpBancaa();
            OpMoneda();
            OpIban();
            OpPin();
            OpStatus();
            OpClientN();
        }

        public void trimitereF_Click(object sender, EventArgs e)
        {
            this.afisareP.BackColor = Color.Gray;
            this.afisareP.View = View.Details;
            this.afisareP.GridLines = true;
            this.afisareP.Location = new Point(0, 0);
            this.afisareP.Size = new Size(this.meniu.Width, this.meniu.Height);
            ControlBanca c = new ControlBanca();
            c.tabelAfisare(afisareP, c.filtrBancaa(c.filtrMoneda(c.filtrIban(c.filtrPin(c.filtrStatus(c.filtrClient(c.Banci, this.clientT.Text.ToString()), this.statusT.Text.ToString()), this.pinT.Text.ToString()), this.ibanT.Text.ToString()), this.monedaT.Text.ToString()), this.bancaT.Text.ToString()));
            if (ok == 6)
            {
                clear();
                this.meniu.Controls.Add(afisareP);
            }
            BtnRevenire();
        }

        public void OpBancaa()
        {
            this.bancaL.Text = "Banca";
            if (this.ok == 3)
                this.bancaL.Text = "Noua Banca";
            this.bancaL.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.bancaL.AutoSize = false;
            this.bancaL.TextAlign = ContentAlignment.MiddleRight;
            this.bancaL.Location = new Point(this.meniu.Width / 2 - this.meniu.Width / 4 - 50, this.meniu.Height / 2 - 70);
            this.bancaL.Size = new Size(150, 30);
            this.meniu.Controls.Add(bancaL);
            this.bancaT.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.bancaT.Location = new Point(this.meniu.Width / 2 - 10, this.meniu.Height / 2 - 70);
            this.bancaT.Size = new Size(160, 30);
            this.meniu.Controls.Add(bancaT);
        }

        public void OpMoneda()
        {
            this.monedaL.Text = "Moneda";
            if (this.ok == 3)
                this.monedaL.Text = "Noua Moneda";
            this.monedaL.AutoSize = false;
            this.monedaL.TextAlign = ContentAlignment.MiddleRight;
            this.monedaL.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.monedaL.Location = new Point(this.meniu.Width / 2 - this.meniu.Width / 4 - 50, this.meniu.Height / 2 - 20);
            this.monedaL.Size = new Size(150, 30);
            this.meniu.Controls.Add(monedaL);
            this.monedaT.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.monedaT.Location = new Point(this.meniu.Width / 2 - 10, this.meniu.Height / 2 - 20);
            this.monedaT.Size = new Size(160, 30);
            this.meniu.Controls.Add(monedaT);
        }

        public void OpIban()
        {
            this.ibanL.Text = "IBAN-ul";
            if (this.ok == 3)
                this.ibanL.Text = "Noul IBAN";
            this.ibanL.AutoSize = false;
            this.ibanL.TextAlign = ContentAlignment.MiddleRight;
            this.ibanL.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.ibanL.Location = new Point(this.meniu.Width / 2 - this.meniu.Width / 4 - 50, this.meniu.Height / 2 + 30);
            this.ibanL.Size = new Size(150, 30);
            this.meniu.Controls.Add(ibanL);
            this.ibanT.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.ibanT.Location = new Point(this.meniu.Width / 2 - 10, this.meniu.Height / 2 + 30);
            this.ibanT.Size = new Size(160, 30);
            this.meniu.Controls.Add(ibanT);
        }

        public void OpPin()
        {
            this.pinL.Text = "Pin-ul";
            if (this.ok == 3)
                this.pinL.Text = "Noul Pin";
            if (this.ok == 6)
                this.pinL.Text = "Pin";
            this.pinL.AutoSize = false;
            this.pinL.TextAlign = ContentAlignment.MiddleRight;
            this.pinL.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.pinL.Location = new Point(this.meniu.Width / 2 - this.meniu.Width / 4 - 50, this.meniu.Height / 2 + 80);
            this.pinL.Size = new Size(150, 30);
            this.meniu.Controls.Add(pinL);
            this.pinT.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.pinT.Location = new Point(this.meniu.Width / 2 - 10, this.meniu.Height / 2 + 80);
            this.pinT.Size = new Size(160, 30);
            this.meniu.Controls.Add(pinT);
        }

        public void OpBancaaC()
        {
            this.bancaLC.AutoSize = false;
            this.bancaLC.TextAlign = ContentAlignment.MiddleRight;
            this.bancaLC.Text = "Banca cautata";
            this.bancaLC.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.bancaLC.Location = new Point(this.meniu.Width / 2 - this.meniu.Width / 4 - 50, this.meniu.Height / 2 - 120);
            this.bancaLC.Size = new Size(150, 30);
            this.meniu.Controls.Add(bancaLC);
            this.bancaTC.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.bancaTC.Location = new Point(this.meniu.Width / 2 - 10, this.meniu.Height / 2 - 120);
            this.bancaTC.Size = new Size(160, 30);
            this.meniu.Controls.Add(bancaTC);
        }

        public void OpClient()
        {
            this.clientL.Text = "Numele dvs";
            this.clientL.AutoSize = false;
            this.clientL.TextAlign = ContentAlignment.MiddleRight;
            this.clientL.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.clientL.Location = new Point(this.meniu.Width / 2 - this.meniu.Width / 4 - 50, this.meniu.Height / 2 - 20);
            this.clientL.Size = new Size(150, 30);
            this.meniu.Controls.Add(clientL);
            this.clientT.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.clientT.Location = new Point(this.meniu.Width / 2 - 10, this.meniu.Height / 2 - 20);
            this.clientT.Size = new Size(160, 30);
            this.meniu.Controls.Add(clientT);
        }

        public void OpUndeInfo(string undeT, string infoT)
        {

            this.unde.Text = undeT;
            this.unde.Font = new Font("Sylfaen", 16, FontStyle.Bold);
            this.unde.AutoSize = false;
            this.unde.TextAlign = ContentAlignment.MiddleCenter;
            this.unde.Location = new Point(0, 12);
            this.unde.Size = new Size(this.meniu.Width, 30);
            this.meniu.Controls.Add(unde);
            this.info.Text = infoT;
            this.info.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.info.AutoSize = false;
            this.info.TextAlign = ContentAlignment.TopCenter;
            this.info.Location = new Point(0, 52);
            this.info.Size = new Size(this.meniu.Width, 60);
            this.meniu.Controls.Add(info);

        }

        public void OpClientN()
        {
            this.clientL.Text = "Client";
            this.clientL.AutoSize = false;
            this.clientL.TextAlign = ContentAlignment.MiddleRight;
            this.clientL.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.clientL.Location = new Point(this.meniu.Width / 2 - this.meniu.Width / 4 - 50, this.meniu.Height / 2 + 180);
            this.clientL.Size = new Size(150, 30);
            this.meniu.Controls.Add(clientL);
            this.clientT.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.clientT.Location = new Point(this.meniu.Width / 2 - 10, this.meniu.Height / 2 + 180);
            this.clientT.Size = new Size(160, 30);
            this.meniu.Controls.Add(clientT);
        }

        public void OpStatus()
        {
            this.statusL.Text = "Status (da/nu)";
            this.statusL.AutoSize = false;
            this.statusL.TextAlign = ContentAlignment.MiddleRight;
            this.statusL.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.statusL.Location = new Point(this.meniu.Width / 2 - this.meniu.Width / 4 - 50, this.meniu.Height / 2 + 130);
            this.statusL.Size = new Size(150, 30);
            this.meniu.Controls.Add(statusL);
            this.statusT.Font = new Font("Sylfaen", 14, FontStyle.Bold);
            this.statusT.Location = new Point(this.meniu.Width / 2 - 10, this.meniu.Height / 2 + 130);
            this.statusT.Size = new Size(160, 30);
            this.meniu.Controls.Add(statusT);
        }

        public void tabel()
        {
            this.afisareP.BackColor = Color.Gray;
            this.afisareP.View = View.Details;
            this.afisareP.GridLines = true;
            this.afisareP.Location = new Point(0, 0);
            this.afisareP.Size = new Size(this.meniu.Width, this.meniu.Height);
            ControlBanca c = new ControlBanca();
            c.afisareTabel(this.afisareP);
            this.meniu.Controls.Add(afisareP);
        }
    }
}
