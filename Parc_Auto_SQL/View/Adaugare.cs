using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using App;


namespace View
{
    public class Adaugare:Panel
    {
        private MasinaRepository control;

        public Adaugare()
        {
            this.control = new MasinaRepository();

            layouts();

            Button b = new Button();
            b.Text = "Adaugare";
            b.Location = new Point(0, 200);
            b.Size = new Size(100, 100);
            b.Click += new EventHandler(b_Click);
            this.Controls.Add(b);
        }
        public void b_Click(object sender, EventArgs e)
        {
            TextBox marca = null;
            TextBox model= null;
            TextBox pret= null;
            TextBox km= null;
            foreach(Control control in this.Controls)
            {
                if (control.Name == "marcaT")
                    marca = control as TextBox;
                if (control.Name == "modelT")
                    model = control as TextBox;
                if (control.Name == "pretT")
                    pret = control as TextBox;
                if (control.Name == "kmT")
                    km = control as TextBox;
            }
            control.add(new Masina(marca.Text, model.Text, int.Parse(km.Text), int.Parse(pret.Text)));
            MessageBox.Show("Adaugat cu succes!");
        }


        public void layouts()
        {
            this.Size = new Size(700, 700);

            Label marca = new Label();
            marca.Text = "Introduceti marca";
            marca.AutoSize = true;
            marca.Location = new Point(0,0);
            this.Controls.Add(marca);

            Label model = new Label();
            model.Text = "Introduceti modelul";
            model.AutoSize = true;
            model.Location = new Point(0,50);
            this.Controls.Add(model);

            Label pret = new Label();
            pret.Text = "Introduceti pretul";
            pret.Location = new Point(0,100);
            pret.AutoSize = true;
            this.Controls.Add(pret);

            Label km = new Label();
            km.Text = "Introduceti km";
            km.Location = new Point(0,150);
            km.AutoSize = true;
            this.Controls.Add(km);



            TextBox marcaT= new TextBox();
            marcaT.Name = "marcaT";
            marcaT.Location = new Point(200,0);
            this.Controls.Add(marcaT);

            TextBox modelT= new TextBox();
            modelT.Name = "modelT";
            modelT.Location = new Point(200,50);
            this.Controls.Add(modelT);

            TextBox pretT = new TextBox();
            pretT.Name = "pretT";
            pretT.Location = new Point(200,100);
            this.Controls.Add(pretT);

            TextBox kmT = new TextBox();
            kmT.Name = "kmT";
            kmT.Location = new Point(200,150);
            this.Controls.Add(kmT);

        }

    }
}
