namespace Manicure
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnShow = new System.Windows.Forms.Label();
            this.BtnSingUp = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Panel();
            this.P1 = new System.Windows.Forms.Panel();
            this.LblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnShow);
            this.panel1.Controls.Add(this.BtnSingUp);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.TxtPass);
            this.panel1.Controls.Add(this.TxtUsername);
            this.panel1.Controls.Add(this.LblPass);
            this.panel1.Controls.Add(this.P2);
            this.panel1.Controls.Add(this.P1);
            this.panel1.Controls.Add(this.LblUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 253);
            this.panel1.TabIndex = 1;
            // 
            // BtnShow
            // 
            this.BtnShow.AutoSize = true;
            this.BtnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShow.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShow.Location = new System.Drawing.Point(215, 127);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(37, 18);
            this.BtnShow.TabIndex = 11;
            this.BtnShow.Text = "Hide";
            this.BtnShow.Visible = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnSingUp
            // 
            this.BtnSingUp.AutoSize = true;
            this.BtnSingUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSingUp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSingUp.Location = new System.Drawing.Point(45, 152);
            this.BtnSingUp.Name = "BtnSingUp";
            this.BtnSingUp.Size = new System.Drawing.Size(198, 18);
            this.BtnSingUp.TabIndex = 9;
            this.BtnSingUp.Text = "Don\'t have an account? Sign up";
            this.BtnSingUp.Click += new System.EventHandler(this.BtnSingUp_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.AutoSize = true;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(32, 196);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(43, 26);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(194, 196);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(58, 26);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.SystemColors.Control;
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(37, 127);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(215, 19);
            this.TxtPass.TabIndex = 6;
            this.TxtPass.TextChanged += new System.EventHandler(this.TxtPass_TextChanged);
            // 
            // TxtUsername
            // 
            this.TxtUsername.AutoCompleteCustomSource.AddRange(new string[] {
            "ex: razcan"});
            this.TxtUsername.BackColor = System.Drawing.SystemColors.Control;
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(37, 50);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(215, 19);
            this.TxtUsername.TabIndex = 5;
            this.TxtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.BackColor = System.Drawing.Color.Transparent;
            this.LblPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblPass.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPass.Location = new System.Drawing.Point(44, 99);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(77, 21);
            this.LblPass.TabIndex = 4;
            this.LblPass.Text = "Password";
            this.LblPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.SystemColors.ControlText;
            this.P2.Location = new System.Drawing.Point(37, 148);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(215, 1);
            this.P2.TabIndex = 3;
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.SystemColors.ControlText;
            this.P1.Location = new System.Drawing.Point(37, 71);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(215, 1);
            this.P1.TabIndex = 2;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.BackColor = System.Drawing.Color.Transparent;
            this.LblUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblUsername.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblUsername.Location = new System.Drawing.Point(44, 22);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(81, 21);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Username";
            this.LblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 30);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.BackColor = System.Drawing.Color.Transparent;
            this.LblError.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblError.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(55, 179);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(35, 15);
            this.LblError.TabIndex = 12;
            this.LblError.Text = "Error";
            this.LblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblError.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Panel P2;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label BtnLogin;
        private System.Windows.Forms.Label BtnSingUp;
        private System.Windows.Forms.Label BtnExit;
        private System.Windows.Forms.Label BtnShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblError;
    }
}