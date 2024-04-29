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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public int ok = 1;

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            LblError.Visible = false;
            TxtPass.MaxLength = 16;
            if (TxtPass.TextLength == 1){
                BtnShow.Text = "Hide";
                BtnShow.Visible = true;
            }
            else if (TxtPass.TextLength == 0){
                BtnShow.Visible = false;
                ok = 1;
                TxtPass.PasswordChar = '\0';
            }
            if (TxtPass.TextLength == 16)
                TxtPass.ForeColor = Color.Red;
            else
                TxtPass.ForeColor = Color.Black;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            LblError.Visible = false;
            if (ok == 1){
                BtnShow.Text = "Show";
                TxtPass.PasswordChar = '*';
                ok = 0;
            }
            else{
                BtnShow.Text = "Hide";
                TxtPass.PasswordChar = '\0';
                ok = 1;
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            LblError.Visible = false;
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LblError.Visible = false;
            AccountControl ac = new AccountControl();
            if (ac.login(TxtUsername, TxtPass) == true && TxtPass.Text != "" && TxtUsername.Text != "")
            {
                FrmMenu fm = new FrmMenu();
                fm.Show();
                //if (ac.verfAdmin(TxtUsername, TxtPass) == "1")
                //{
                //    ac.getMenuAcc(TxtUsername, TxtPass, ac.getEmail,"1");                  
                //}
                //else
                //    ac.getMenuAcc(TxtUsername, TxtPass, ac.getEmail, "1");

            }
            else
            {
                LblError.Text = "Username or password is wrong";
                LblError.Visible = true;
            }
        }

        private void BtnSingUp_Click(object sender, EventArgs e)
        {
            LblError.Visible = false;
            FrmSignUp fsu = new FrmSignUp();
            fsu.Show();
        }
    }
}
