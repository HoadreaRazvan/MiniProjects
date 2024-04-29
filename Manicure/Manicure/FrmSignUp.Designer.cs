namespace Manicure
{
    partial class FrmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Panel();
            this.P1 = new System.Windows.Forms.Panel();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TxtPassC = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnShow = new System.Windows.Forms.Label();
            this.BtnShowC = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblError);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Controls.Add(this.BtnShowC);
            this.panel1.Controls.Add(this.BtnShow);
            this.panel1.Controls.Add(this.TxtPassC);
            this.panel1.Controls.Add(this.TxtPass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.TxtUsername);
            this.panel1.Controls.Add(this.LblPass);
            this.panel1.Controls.Add(this.P2);
            this.panel1.Controls.Add(this.P1);
            this.panel1.Controls.Add(this.LblUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 379);
            this.panel1.TabIndex = 0;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(43, 131);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(215, 19);
            this.TxtEmail.TabIndex = 12;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // TxtUsername
            // 
            this.TxtUsername.AutoCompleteCustomSource.AddRange(new string[] {
            "ex: razcan"});
            this.TxtUsername.BackColor = System.Drawing.SystemColors.Control;
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(43, 54);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(215, 19);
            this.TxtUsername.TabIndex = 11;
            this.TxtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.BackColor = System.Drawing.Color.Transparent;
            this.LblPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblPass.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPass.Location = new System.Drawing.Point(50, 103);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(48, 21);
            this.LblPass.TabIndex = 10;
            this.LblPass.Text = "Email";
            this.LblPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.SystemColors.ControlText;
            this.P2.Location = new System.Drawing.Point(43, 152);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(215, 1);
            this.P2.TabIndex = 9;
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.SystemColors.ControlText;
            this.P1.Location = new System.Drawing.Point(43, 75);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(215, 1);
            this.P1.TabIndex = 8;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.BackColor = System.Drawing.Color.Transparent;
            this.LblUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblUsername.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblUsername.Location = new System.Drawing.Point(50, 26);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(81, 21);
            this.LblUsername.TabIndex = 7;
            this.LblUsername.Text = "Username";
            this.LblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtPassC
            // 
            this.TxtPassC.BackColor = System.Drawing.SystemColors.Control;
            this.TxtPassC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassC.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassC.Location = new System.Drawing.Point(43, 280);
            this.TxtPassC.Name = "TxtPassC";
            this.TxtPassC.Size = new System.Drawing.Size(215, 19);
            this.TxtPassC.TabIndex = 18;
            this.TxtPassC.TextChanged += new System.EventHandler(this.TxtPassC_TextChanged);
            // 
            // TxtPass
            // 
            this.TxtPass.AutoCompleteCustomSource.AddRange(new string[] {
            "ex: razcan"});
            this.TxtPass.BackColor = System.Drawing.SystemColors.Control;
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(43, 203);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(215, 19);
            this.TxtPass.TabIndex = 17;
            this.TxtPass.TextChanged += new System.EventHandler(this.TxtPass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(50, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Confirm Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(43, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 1);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(43, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 1);
            this.panel3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(50, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnShow
            // 
            this.BtnShow.AutoSize = true;
            this.BtnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShow.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShow.Location = new System.Drawing.Point(221, 203);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(37, 18);
            this.BtnShow.TabIndex = 19;
            this.BtnShow.Text = "Hide";
            this.BtnShow.Visible = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnShowC
            // 
            this.BtnShowC.AutoSize = true;
            this.BtnShowC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowC.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowC.Location = new System.Drawing.Point(221, 280);
            this.BtnShowC.Name = "BtnShowC";
            this.BtnShowC.Size = new System.Drawing.Size(37, 18);
            this.BtnShowC.TabIndex = 20;
            this.BtnShowC.Text = "Hide";
            this.BtnShowC.Visible = false;
            this.BtnShowC.Click += new System.EventHandler(this.BtnShowC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.AutoSize = true;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(38, 328);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(43, 26);
            this.BtnExit.TabIndex = 22;
            this.BtnExit.Text = "Exit";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.AutoSize = true;
            this.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(200, 328);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(67, 26);
            this.BtnCreate.TabIndex = 21;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.BackColor = System.Drawing.Color.Transparent;
            this.LblError.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblError.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(40, 0);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(35, 15);
            this.LblError.TabIndex = 13;
            this.LblError.Text = "Error";
            this.LblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblError.Visible = false;
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtPassC;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.Panel P2;
        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label BtnShowC;
        private System.Windows.Forms.Label BtnShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BtnExit;
        private System.Windows.Forms.Label BtnCreate;
        private System.Windows.Forms.Label LblError;
    }
}