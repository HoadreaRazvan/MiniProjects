using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Front_end
{
    public class Adaugare :Panel
    {
        private MasinaRepository control;


        public Adaugare()
        {
            this.control = new MasinaRepository();

            layoutAdaugare();
        }

        public void layoutAdaugare()
        {
            Label info = new Label();
            OpInfo(info, "ADAUGARE");
            this.Controls.Add(info);

            Button iesire = new Button();
            BtnIesire(iesire);
            this.Controls.Add(iesire);

            Button trimitereA = new Button();
            BtnTrimitereA(trimitereA);
            this.Controls.Add(trimitereA);

            TextBox marcaT = new TextBox();
            marcaT.Name = "marcaT";
            Label marcaL = new Label();
            OpMarca(marcaT, marcaL);
            this.Controls.Add(marcaL);
            this.Controls.Add(marcaT);

            TextBox modelT = new TextBox();
            modelT.Name = "modelT";
            Label modelL = new Label();
            OpModel(modelT, modelL);
            this.Controls.Add(modelL);
            this.Controls.Add(modelT);

            TextBox kmT = new TextBox();
            kmT.Name = "kmT";
            Label kmL = new Label();
            OpKm(kmT, kmL);
            this.Controls.Add(kmL);
            this.Controls.Add(kmT);

            TextBox pretT = new TextBox();
            pretT.Name = "pretT";
            Label pretL = new Label();
            OpPret(pretT, pretL);
            this.Controls.Add(pretL);
            this.Controls.Add(pretT);
        }

        public void OpInfo(Label info, string text)
        {
            info.Text = text;
            info.Font = new Font("Calibri", 18, FontStyle.Bold);
            info.Location = new Point(this.Width / 2 - 75, 0);
            info.Size = new Size(150, 30);
            info.TextAlign = ContentAlignment.MiddleRight;
        }

        public void BtnTrimitereA(Button trimitereA)
        {
            trimitereA.Text = "Adaugati";
            trimitereA.Font = new Font("Calibri", 14, FontStyle.Bold);
            trimitereA.Location = new Point(0, 0);
            trimitereA.Size = new Size(this.Width, this.Height / 2);
            trimitereA.Click += new EventHandler(trimitereA_Click);
        }

        public void trimitereA_Click(object sender, EventArgs e)
        {
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
            adauga(marca, model, pret, pret);
        }

        public void adauga(TextBox marca, TextBox model, TextBox pret, TextBox pret)
        {
            if (marca.Text != "" && model.Text != "" && pret.Text != "" && pret.Text != "")
            {
                control.adaugare(marca.Text, model.Text, int.Parse(pret.Text), int.Parse(pret.Text));
                MessageBox.Show("Adaugat cu succes!");
                marca.Text = "";
                model.Text = "";
                pret.Text = "";
                pret.Text = "";
            }
            else
                MessageBox.Show("Nu se poate adauga!");
        }

        public void BtnIesire(Button iesire)
        {
            iesire.Text = "Iesire";
            iesire.Font = new Font("Calibri", 14, FontStyle.Bold);
            iesire.Location = new Point(0, this.Height / 2);
            iesire.Size = new Size(this.Width, this.Height / 2);
            iesire.Click += new EventHandler(iesire_Click);
        }

        public void iesire_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void OpMarca(TextBox marcaT, Label marcaL)
        {
            marcaL.Text = "Marca";
            marcaL.Font = new Font("Calibri", 14, FontStyle.Bold);
            marcaL.Location = new Point(this.Width / 2 - 160, 80);
            marcaL.Size = new Size(150, 30);
            marcaL.TextAlign = ContentAlignment.MiddleRight;

            marcaT.Font = new Font("Calibri", 14, FontStyle.Bold);
            marcaT.Location = new Point(this.Width / 2 + 10, 80);
            marcaT.Size = new Size(150, 30);
        }

        public void OpModel(TextBox modelT, Label modelL)
        {
            modelL.Text = "Modelul";
            modelL.Font = new Font("Calibri", 14, FontStyle.Bold);
            modelL.Location = new Point(this.Width / 2 - 160, 120);
            modelL.Size = new Size(150, 30);
            modelL.TextAlign = ContentAlignment.MiddleRight;

            modelT.Font = new Font("Calibri", 14, FontStyle.Bold);
            modelT.Location = new Point(this.Width / 2 + 10, 120);
            modelT.Size = new Size(150, 30);
        }

        public void OpKm(TextBox kmT, Label kmL)
        {
            kmL.Text = "Kilometri";
            kmL.Font = new Font("Calibri", 14, FontStyle.Bold);
            kmL.Location = new Point(this.Width / 2 - 160, 160);
            kmL.Size = new Size(150, 30);
            kmL.TextAlign = ContentAlignment.MiddleRight;

            kmT.Font = new Font("Calibri", 14, FontStyle.Bold);
            kmT.Location = new Point(this.Width / 2 + 10, 160);
            kmT.Size = new Size(150, 30);
        }

        public void OpPret(TextBox pretT, Label pretL)
        {
            pretL.Text = "Pretul";
            pretL.Font = new Font("Calibri", 14, FontStyle.Bold);
            pretL.Location = new Point(this.Width / 2 - 160, 200);
            pretL.Size = new Size(150, 30);
            pretL.TextAlign = ContentAlignment.MiddleRight;

            pretT.Font = new Font("Calibri", 14, FontStyle.Bold);
            pretT.Location = new Point(this.Width / 2 + 10, 200);
            pretT.Size = new Size(150, 30);
        }
    }
}
