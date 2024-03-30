using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvadersVSTowers
{
    public partial class FrmMeniu : Form
    {
        public FrmMeniu()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmMeniu_Load);
        }

        private void FrmMeniu_Load(object sender, EventArgs e)
        {
            ControlViewInfo c = new ControlViewInfo(this);
            c.start();
        }
    }
}

