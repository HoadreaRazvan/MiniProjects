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
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        public int ok = 1;
        public int ok1 = 1;

        private void BtnShow_Click(object sender, EventArgs e)
        {
            LblError.Visible = false;
            if (ok == 1)
            {
                BtnShow.Text = "Show";
                TxtPass.PasswordChar = '*';
                ok = 0;
            }
            else
            {
                BtnShow.Text = "Hide";
                TxtPass.PasswordChar = '\0';
                ok = 1;
            }
        }

        private void BtnShowC_Click(object sender, EventArgs e)
        {
            LblError.Visible = false;
            if (ok1 == 1)
            {
                BtnShowC.Text = "Show";
                TxtPassC.PasswordChar = '*';
                ok1 = 0;
            }
            else
            {
                BtnShowC.Text = "Hide";
                TxtPassC.PasswordChar = '\0';
                ok1 = 1;
            }
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            LblError.Visible = false;
            TxtUsername.MaxLength = 24;
            if (TxtUsername.TextLength == 24)
                TxtUsername.ForeColor = Color.Red;
            else
                TxtUsername.ForeColor = Color.Black;
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            LblError.Visible = false;
            TxtEmail.MaxLength = 24;
            if (TxtEmail.TextLength == 24)
                TxtEmail.ForeColor = Color.Red;
            else
                TxtEmail.ForeColor = Color.Black;
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            LblError.Visible = false;
            if (TxtPass.Text == "")
                TxtPassC.Text = "";
            TxtPass.MaxLength = 16;
            if (TxtPass.TextLength == 1)
            {
                BtnShow.Text = "Hide";
                BtnShow.Visible = true;
            }
            else if (TxtPass.TextLength == 0)
            {
                BtnShow.Visible = false;
                ok = 1;
                TxtPass.PasswordChar = '\0';
            }
            if (TxtPass.TextLength == 16)
                TxtPass.ForeColor = Color.Red;
            else
                TxtPass.ForeColor = Color.Black;
        }

        private void TxtPassC_TextChanged(object sender, EventArgs e)
        {
            LblError.Visible = false;
            if (TxtPass.Text == "")
                TxtPassC.Text = "";
            TxtPassC.MaxLength = 16;
            if (TxtPassC.TextLength == 1)
            {
                BtnShowC.Text = "Hide";
                BtnShowC.Visible = true;
            }
            else if (TxtPassC.TextLength == 0)
            {
                BtnShowC.Visible = false;
                ok1 = 1;
                TxtPassC.PasswordChar = '\0';
            }
            if (TxtPassC.TextLength == 16)
                TxtPassC.ForeColor = Color.Red;
            else
                TxtPassC.ForeColor = Color.Black;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            LblError.Visible = false;
            this.Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            LblError.Visible = false;
            AccountControl ac = new AccountControl();
            if (TxtPass.Text == TxtPassC.Text && TxtPass.Text != "" && TxtEmail.Text != "" && TxtUsername.Text != "" && ac.login(TxtUsername,TxtPass)==false)
            {               
                ac.signUp(TxtUsername, TxtPass, TxtEmail);
                FrmMenu fm = new FrmMenu();
                fm.Show();
                
            }
            else
            {
                LblError.Text = "Username, password or email is wrong";
                LblError.Visible = true;
            }
        }
    }
}
