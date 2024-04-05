using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Album
{
    public partial class Album : Form
    {
        public Album()
        {
            InitializeComponent();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show show = new Show();
            show.Show(); ;

        }

        private void inchiriereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInchiriere inc = new FrmInchiriere();
            
            inc.Show();
        }

        private void returnareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReturnare r = new FrmReturnare();
            r.Show();
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdaugare fa = new FrmAdaugare();
            fa.Show();
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
