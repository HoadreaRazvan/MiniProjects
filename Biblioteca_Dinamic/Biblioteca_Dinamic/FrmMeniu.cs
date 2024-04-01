using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Dinamic
{
    public partial class FrmMeniu : Form
    {
        public FrmMeniu()
        {
            InitializeComponent();
        }

        private void FrmMeniu_Load(object sender, EventArgs e)
        {
            this.MaximumSize = (Size)new Point(900, 550);
            this.MinimumSize = (Size)new Point(900, 550);
            ControlView c = new ControlView(this);
            c.START();
        }
    }
}