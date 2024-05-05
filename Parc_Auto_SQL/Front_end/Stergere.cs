using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Front_end
{
    public class Stergere:Panel
    {
        private MasinaRepository control;

        public Stergere()
        {
            layoutStergere();
            this.control = new MasinaRepository();

        }

        public void layoutStergere()
        {
            Label info = new Label();
            OpInfo(info, "STERGERE");
            this.Controls.Add(info);

            Button iesire = new Button();
            BtnIesire(iesire);
            this.Controls.Add(iesire);

            Button trimitereS = new Button();
            BtnTrimitereS(trimitereS);
            this.Controls.Add(trimitereS);

            TextBox marcaT = new TextBox();
            marcaT.Name = "marcaT";
            Label marcaL = new Label();
            OpMarca(marcaT, marcaL);
            this.Controls.Add(marcaL);
            this.Controls.Add(marcaT);
        }

        public void BtnTrimitereS(Button trimitereS)
        {
            trimitereS.Text = "Stergeti";
            trimitereS.Font = new Font("Calibri", 14, FontStyle.Bold);
            trimitereS.Location = new Point(0, 0);
            trimitereS.Size = new Size(this.Width, this.Height / 2);
            trimitereS.Click += new EventHandler(trimitereS_Click);
        }

        public void trimitereS_Click(object sender, EventArgs e)
        {
            TextBox marca = null;
            foreach (Control c in this.Controls)
                if (c.Name == "marcaT") marca = c as TextBox;
            sterge(marca);
        }

        public void sterge(TextBox marca)
        {
            if (marca.Text != "" && control.pozUtilaj(marca.Text) != -1)
            {
                control.stergere(marca.Text);
                MessageBox.Show("Sters cu succes!");
                marca.Text = "";
            }
            else
                MessageBox.Show("Nu se poate sterge!");
        }

    }
}
