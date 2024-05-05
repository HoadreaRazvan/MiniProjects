using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using App;


namespace View
{
    public class Modificare :Panel
    {
        private MasinaRepository control;

        public Modificare()
        {
            this.control = new MasinaRepository();

            layouts();

            Button b = new Button();
            b.Text = "Modificare";
            b.Location = new Point(0, 250);
            b.Size = new Size(100, 100);
            b.Click += new EventHandler(b_Click);
            this.Controls.Add(b);
        }
        public void b_Click(object sender, EventArgs e)
        {
            TextBox id = null;
            TextBox marca = null;
            TextBox model = null;
            TextBox pret = null;
            TextBox km = null;
            foreach (Control control in this.Controls)
            {
                if (control.Name == "idT")
                    id = control as TextBox;
                if (control.Name == "marcaT")
                    marca = control as TextBox;
                if (control.Name == "modelT")
                    model = control as TextBox;
                if (control.Name == "pretT")
                    pret = control as TextBox;
                if (control.Name == "kmT")
                    km = control as TextBox;
            }
            if (marca.Text != "")
                this.control.updateMarcaById(int.Parse(id.Text), marca.Text);

            if (model.Text != "")
                this.control.updateModelById(int.Parse(id.Text), model.Text);

            if (pret.Text != "")
                this.control.updatePretById(int.Parse(id.Text), int.Parse(pret.Text));

            if (km.Text != "")
                this.control.updateKmById(int.Parse(id.Text), int.Parse(km.Text));

            MessageBox.Show("Modificat cu succes!");
        }


        public void layouts()
        {
            this.Size = new Size(700, 700);

            Label id = new Label();
            id.Text = "Introduceti ID-ul masinii pe care doriti sa o modificati";
            id.AutoSize = true;
            id.Location = new Point(0, 0);
            this.Controls.Add(id);

            Label marca = new Label();
            marca.Text = "Introduceti noua MARCA (lasati necompletata daca nu doriti sa modificati)";
            marca.AutoSize = true;
            marca.Location = new Point(0, 50);
            this.Controls.Add(marca);

            Label model = new Label();
            model.Text = "Introduceti noul MODEL (lasati necompletata daca nu doriti sa modificati)";
            model.AutoSize = true;
            model.Location = new Point(0, 100);
            this.Controls.Add(model);

            Label pret = new Label();
            pret.Text = "Introduceti noul PRET (lasati necompletata daca nu doriti sa modificati)";
            pret.Location = new Point(0, 150);
            pret.AutoSize = true;
            this.Controls.Add(pret);

            Label km = new Label();
            km.Text = "Introduceti noul numar de KM (lasati necompletata daca nu doriti sa modificati)";
            km.Location = new Point(0, 200);
            km.AutoSize = true;
            this.Controls.Add(km);


            TextBox idT = new TextBox();
            idT.Name = "idT";
            idT.Size = new Size(200, 10);
            idT.Location = new Point(20, 20);
            this.Controls.Add(idT);

            TextBox marcaT = new TextBox();
            marcaT.Name = "marcaT";
            marcaT.Size = new Size(200, 10);
            marcaT.Location = new Point(20, 70);
            this.Controls.Add(marcaT);

            TextBox modelT = new TextBox();
            modelT.Name = "modelT";
            modelT.Size = new Size(200, 10);
            modelT.Location = new Point(20, 120);
            this.Controls.Add(modelT);

            TextBox pretT = new TextBox();
            pretT.Name = "pretT";
            pretT.Size = new Size(200, 10);
            pretT.Location = new Point(20, 170);
            this.Controls.Add(pretT);

            TextBox kmT = new TextBox();
            kmT.Name = "kmT";
            kmT.Location = new Point(20, 220);
            kmT.Size = new Size(200, 10);
            this.Controls.Add(kmT);

        }
    }
}
