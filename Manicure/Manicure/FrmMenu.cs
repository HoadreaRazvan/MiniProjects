using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manicure
{
    public partial class FrmMenu : Form
    {
        public string AccName
        {
            get
            {
                return this.LblAccName.Text;
            }
            set
            {
                this.LblAccName.Text = value;
            }
        }

        public List<Account> userAcc;

        public FrmMenu()
        {
            InitializeComponent();
            LblHome.BackColor = Color.Red;
            LblLibrary.BackColor = Color.FromArgb(64, 64, 64);
            LblNotes.BackColor = Color.FromArgb(64, 64, 64);
            LblImages.BackColor = Color.FromArgb(64, 64, 64);
            LblHistory.BackColor = Color.FromArgb(64, 64, 64);
            AccountControl ac = new AccountControl();
            //userAcc = ac.getMenuAcc();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            LblHome.BackColor = Color.Red;
            LblLibrary.BackColor = Color.FromArgb(64, 64, 64);
            LblNotes.BackColor = Color.FromArgb(64, 64, 64);
            LblImages.BackColor = Color.FromArgb(64, 64, 64);
            LblHistory.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnLibrary_Click(object sender, EventArgs e)
        {
            LblHome.BackColor = Color.FromArgb(64, 64, 64);
            LblLibrary.BackColor =Color.Red;
            LblNotes.BackColor = Color.FromArgb(64, 64, 64);
            LblImages.BackColor = Color.FromArgb(64, 64, 64);
            LblHistory.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnNotes_Click(object sender, EventArgs e)
        {
            LblHome.BackColor = Color.FromArgb(64, 64, 64); 
            LblLibrary.BackColor = Color.FromArgb(64, 64, 64);
            LblNotes.BackColor = Color.Red;
            LblImages.BackColor = Color.FromArgb(64, 64, 64);
            LblHistory.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnImages_Click(object sender, EventArgs e)
        {
            LblHome.BackColor = Color.FromArgb(64, 64, 64); ;
            LblLibrary.BackColor = Color.FromArgb(64, 64, 64);
            LblNotes.BackColor = Color.FromArgb(64, 64, 64);
            LblImages.BackColor = Color.Red;
            LblHistory.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            LblHome.BackColor = Color.FromArgb(64, 64, 64);
            LblLibrary.BackColor = Color.FromArgb(64, 64, 64);
            LblNotes.BackColor = Color.FromArgb(64, 64, 64);
            LblImages.BackColor = Color.FromArgb(64, 64, 64);
            LblHistory.BackColor = Color.Red;                                    
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
           
        }


    }
}
