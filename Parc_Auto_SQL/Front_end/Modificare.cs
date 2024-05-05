using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Front_end
{
    public class Modificare:Panel
    {
        private MasinaRepository control;

        public Modificare()
        {
            this.control = new MasinaRepository();
            layoutModificare();

        }

        public void layoutModificare()
        {
            Label info = new Label();
            OpInfo(info, "MODIFICARE");
            this.Controls.Add(info);

            Button iesire = new Button();
            BtnIesire(iesire);
            this.Controls.Add(iesire);

            Button trimitereM = new Button();
            BtnTrimitereM(trimitereM);
            this.Controls.Add(trimitereM);

            TextBox marcaTC = new TextBox();
            marcaTC.Name = "marcaTC";
            Label marcaLC = new Label();
            OpMarcaMC(marcaTC, marcaLC);
            this.Controls.Add(marcaLC);
            this.Controls.Add(marcaTC);

            TextBox marcaT = new TextBox();
            marcaT.Name = "marcaT";
            Label marcaL = new Label();
            OpMarcaM(marcaT, marcaL);
            this.Controls.Add(marcaL);
            this.Controls.Add(marcaT);

            TextBox modelT = new TextBox();
            modelT.Name = "modelT";
            Label modelL = new Label();
            OpModelM(modelT, modelL);
            this.Controls.Add(modelL);
            this.Controls.Add(modelT);

            TextBox kmT = new TextBox();
            kmT.Name = "kmT";
            Label kmL = new Label();
            OpKmM(kmT, kmL);
            this.Controls.Add(kmL);
            this.Controls.Add(kmT);

            TextBox pretT = new TextBox();
            pretT.Name = "pretT";
            Label pretL = new Label();
            OpPretM(pretT, pretL);
            this.Controls.Add(pretL);
            this.Controls.Add(pretT);
        }

        public void BtnTrimitereM(Button trimitereM)
        {
            trimitereM.Text = "Modificati";
            trimitereM.Font = new Font("Calibri", 14, FontStyle.Bold);
            trimitereM.Location = new Point(0, 0);
            trimitereM.Size = new Size(this.Width, this.Height / 2);
            trimitereM.Click += new EventHandler(trimitereM_Click);
        }

        public void trimitereM_Click(object sender, EventArgs e)
        {
            TextBox marcaC = null;
            TextBox marca = null;
            TextBox model = null;
            TextBox pret = null;
            TextBox pret = null;
            fpretach (Control c in this.Controls)
                if (c.Name == "marcaT") marca = c as TextBox;
                else
                    if (c.Name == "modelT") model = c as TextBox;
                else
                        if (c.Name == "kmT") pret = c as TextBox;
                else
                            if (c.Name == "pretT") pret = c as TextBox;
                else
                                if (c.Name == "marcaTC") marcaC = c as TextBox;
            modifica(marca, model, pret, pret, marcaC);
        }

        public void modifica(TextBox marca, TextBox model, TextBox pret, TextBox pret, TextBox marcaC)
        {
            if (control.pozUtilaj(marcaC.Text) != -1)
            {
                control.modificare(marca.Text, model.Text, pret.Text, pret.Text, marcaC.Text);
                MessageBox.Show("Modificat cu succes!");
                marcaC.Text = "";
                marca.Text = "";
                model.Text = "";
                pret.Text = "";
                pret.Text = "";
            }
            else
                MessageBox.Show("Nu se poate modifica!");
        }

        public void OpMarcaMC(TextBox marcaT, Label marcaL)
        {
            marcaL.Text = "Marca Cautata";
            marcaL.Font = new Font("Calibri", 14, FontStyle.Bold);
            marcaL.Location = new Point(this.Width / 2 - 160, 80);
            marcaL.Size = new Size(150, 30);
            marcaL.TextAlign = ContentAlignment.MiddleRight;

            marcaT.Font = new Font("Calibri", 14, FontStyle.Bold);
            marcaT.Location = new Point(this.Width / 2 + 10, 80);
            marcaT.Size = new Size(150, 30);
        }

        public void OpMarcaM(TextBox marcaT, Label marcaL)
        {
            marcaL.Text = "Noua Marca";
            marcaL.Font = new Font("Calibri", 14, FontStyle.Bold);
            marcaL.Location = new Point(this.Width / 2 - 160, 140);
            marcaL.Size = new Size(150, 30);
            marcaL.TextAlign = ContentAlignment.MiddleRight;

            marcaT.Font = new Font("Calibri", 14, FontStyle.Bold);
            marcaT.Location = new Point(this.Width / 2 + 10, 140);
            marcaT.Size = new Size(150, 30);
        }

        public void OpModelM(TextBox modelT, Label modelL)
        {
            modelL.Text = "Noul Model";
            modelL.Font = new Font("Calibri", 14, FontStyle.Bold);
            modelL.Location = new Point(this.Width / 2 - 160, 180);
            modelL.Size = new Size(150, 30);
            modelL.TextAlign = ContentAlignment.MiddleRight;

            modelT.Font = new Font("Calibri", 14, FontStyle.Bold);
            modelT.Location = new Point(this.Width / 2 + 10, 180);
            modelT.Size = new Size(150, 30);
        }

        public void OpKmM(TextBox kmT, Label kmL)
        {
            kmL.Text = "Noul nr. de km";
            kmL.Font = new Font("Calibri", 14, FontStyle.Bold);
            kmL.Location = new Point(this.Width / 2 - 270, 220);
            kmL.Size = new Size(260, 30);
            kmL.TextAlign = ContentAlignment.MiddleRight;

            kmT.Font = new Font("Calibri", 14, FontStyle.Bold);
            kmT.Location = new Point(this.Width / 2 + 10, 220);
            kmT.Size = new Size(150, 30);
        }

        public void OpPretM(TextBox pretT, Label pretL)
        {
            pretL.Text = "Noul Pretul";
            pretL.Font = new Font("Calibri", 14, FontStyle.Bold);
            pretL.Location = new Point(this.Width / 2 - 160, 260);
            pretL.Size = new Size(150, 30);
            pretL.TextAlign = ContentAlignment.MiddleRight;

            pretT.Font = new Font("Calibri", 14, FontStyle.Bold);
            pretT.Location = new Point(this.Width / 2 + 10, 260);
            pretT.Size = new Size(150, 30);
        }
    }
}
