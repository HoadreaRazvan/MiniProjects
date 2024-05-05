using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using App;
using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class Home :Form
    {
        private ListView listView1;
        private MasinaRepository control;
        public Home()
        {
            layouts();
            this.control = new MasinaRepository();
        }
        public void layouts()
        {
            this.Size = new Size(500, 500);

            Button b = new Button();
            b.Text = "Afisare";
            b.Location = new Point(0, 0);
            b.Size = new Size(100, 100);
            this.Controls.Add(b);

            Button b1 = new Button();
            b1.Text = "Adaugare";
            b1.Location = new Point(0, 100);
            b1.Size = new Size(100, 100);
            this.Controls.Add(b1);

            Button b2 = new Button();
            b2.Text = "Stergere";
            b2.Location = new Point(0, 200);
            b2.Size = new Size(100, 100);
            this.Controls.Add(b2);

            Button b3 = new Button();
            b3.Text = "Modificare";
            b3.Location = new Point(0, 300);
            b3.Size = new Size(100, 100);
            this.Controls.Add(b3);

            b.Click += new EventHandler(b_Click);
            b1.Click += new EventHandler(b1_Click);
            b2.Click += new EventHandler(b2_Click);
            b3.Click += new EventHandler(b3_Click);
        }
        public void b_Click(object sender, EventArgs e)
        {
            Form f1 = new Form();
            f1.Size = new Size(700, 700);
            f1.Controls.Add(new Afisare());
            f1.Show();
        }
        public void b1_Click(object sender, EventArgs e)
        {
            Form f1 = new Form();
            f1.Size = new Size(700, 700);
            f1.Controls.Add(new Adaugare());
            f1.Show();
        }
        public void b2_Click(object sender, EventArgs e)
        {
            Form f1 = new Form();
            f1.Size = new Size(700, 700);
            f1.Controls.Add(new Stergere());
            f1.Show();
        }
        public void b3_Click(object sender, EventArgs e)
        {
            Form f1 = new Form();
            f1.Size = new Size(700, 700);
            f1.Controls.Add(new Modificare());
            f1.Show();
        }





        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(114, 123);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(633, 313);
            this.Controls.Add(this.listView1);
            this.Name = "Home";
            this.ResumeLayout(false);

        }
    }
}
