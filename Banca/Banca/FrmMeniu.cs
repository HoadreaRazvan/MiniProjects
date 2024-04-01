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
    public partial class FrmMeniu : Form
    {
        public FrmMeniu()
        {
            InitializeComponent();
        }

        private Panel startP = new Panel();
        private Button startB = new Button();
        private Label startL = new Label();
        private int fX;
        private int fY;


        private void start_Click(object sender, EventArgs e)
        {
            Panel prop = new Panel();
            Panel operatii = new Panel();
            Panel meniu = new Panel();

            ListView afisareP = new ListView();

            Button afisare = new Button();
            Button adaugare = new Button();
            Button stergere = new Button();
            Button modificare = new Button();
            Button inchiriere = new Button();
            Button returnare = new Button();
            Button filtrare = new Button();

            Button iesi = new Button();
            Button trimitere = new Button();
            Button revenire = new Button();

            Label bancaL = new Label();
            Label monedaL = new Label();
            Label ibanL = new Label();
            Label pinL = new Label();
            Label clientL = new Label();
            Label bancaLC = new Label();
            Label unde = new Label();
            Label info = new Label();
            Label statusL = new Label();

            TextBox bancaT = new TextBox();
            TextBox monedaT = new TextBox();
            TextBox ibanT = new TextBox();
            TextBox pinT = new TextBox();
            TextBox clientT = new TextBox();
            TextBox bancaTC = new TextBox();
            TextBox statusT = new TextBox();

            this.startP.Controls.Clear();
            this.startP.Location = new Point(fX, fY);
            ControlView c = new ControlView(prop, operatii, meniu, afisareP, afisare, adaugare, stergere, modificare, inchiriere, returnare, filtrare, iesi, trimitere, bancaL, monedaL, ibanL, pinL, clientL, bancaLC, bancaT, monedaT, ibanT, pinT, clientT, bancaTC, fX, fY, unde, info, statusL, statusT, revenire);
            c.principal();
            Controls.Add(prop);
            Controls.Add(meniu);
            Controls.Add(operatii);
        }
        public void BtnStart()
        {
            this.startP.Size = new Size(250, 100);
            this.startP.Location = new Point(this.Width / 2 - this.startP.Width / 2, 100);
            this.startB.Text = "INCEPETI";
            this.startL.Text = "Apasati pe INCEPETI pentru a porni";
            this.startB.Font = new Font("Sylfaen", 12, FontStyle.Bold);
            this.startL.Font = new Font("Sylfaen", 12, FontStyle.Bold);
            this.startB.Size = new Size(startP.Width / 2, 40);
            this.startL.Size = new Size(startP.Width, 40);
            this.startB.Location = new Point((startP.Width - startB.Width) / 2 - 5, 40);
            this.startL.Location = new Point(0, 0);
            this.startB.Click += new EventHandler(start_Click);
            this.Controls.Add(startP);
            this.startP.Controls.Add(startB);
            this.startP.Controls.Add(startL);
        }
        private void FrmMeniu_Load(object sender, EventArgs e)
        {
            this.Width = 700;
            this.Height = 500;
            this.fX = this.Width;
            this.fY = this.Height;
            BtnStart();
        }
    }
}
