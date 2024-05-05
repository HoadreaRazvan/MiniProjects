using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using App;


namespace View
{
    public class Stergere :Panel
    {
        private MasinaRepository control;

        public Stergere()
        {
            this.control = new MasinaRepository();

            layouts();
        }

        public void layouts()
        {
            this.Size = new Size(700, 700);

            Label id = new Label();
            id.Text = "Introduceti marca pe care o doriti sa o stergeti";
            id.AutoSize = true;
            id.Location = new Point(0, 0);
            this.Controls.Add(id);


            TextBox idT = new TextBox();
            idT.Name = "idT";
            idT.Location = new Point(0, 50);
            this.Controls.Add(idT);


            Button b = new Button();
            b.Text = "Stergere";
            b.Location = new Point(0, 200);
            b.Size = new Size(100, 100);
            b.Click += new EventHandler(b_Click);
            this.Controls.Add(b);

        }

        public void b_Click(object sender, EventArgs e)
        {
            TextBox id = null;
            foreach (Control control in this.Controls)
            {
                if (control.Name == "idT")
                    id = control as TextBox;
            }
            this.control.deleteById(int.Parse(id.Text));
            MessageBox.Show("Sters cu succes!");
        }
    }
}
