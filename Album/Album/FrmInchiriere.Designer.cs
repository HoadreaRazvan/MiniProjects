namespace Album
{
    partial class FrmInchiriere
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
            this.LblNume = new System.Windows.Forms.Label();
            this.TxtNume = new System.Windows.Forms.TextBox();
            this.TxtNumeClient = new System.Windows.Forms.TextBox();
            this.lblNumeClient = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblTrimite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNume
            // 
            this.LblNume.AutoSize = true;
            this.LblNume.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNume.Location = new System.Drawing.Point(8, 9);
            this.LblNume.Name = "LblNume";
            this.LblNume.Size = new System.Drawing.Size(123, 36);
            this.LblNume.TabIndex = 0;
            this.LblNume.Text = "Numele";
            // 
            // TxtNume
            // 
            this.TxtNume.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNume.Location = new System.Drawing.Point(14, 48);
            this.TxtNume.Name = "TxtNume";
            this.TxtNume.Size = new System.Drawing.Size(117, 33);
            this.TxtNume.TabIndex = 1;
            this.TxtNume.Leave += new System.EventHandler(this.TxtNume_Leave);
            // 
            // TxtNumeClient
            // 
            this.TxtNumeClient.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeClient.Location = new System.Drawing.Point(12, 152);
            this.TxtNumeClient.Name = "TxtNumeClient";
            this.TxtNumeClient.Size = new System.Drawing.Size(186, 33);
            this.TxtNumeClient.TabIndex = 2;
            // 
            // lblNumeClient
            // 
            this.lblNumeClient.AutoSize = true;
            this.lblNumeClient.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeClient.Location = new System.Drawing.Point(8, 98);
            this.lblNumeClient.Name = "lblNumeClient";
            this.lblNumeClient.Size = new System.Drawing.Size(258, 36);
            this.lblNumeClient.TabIndex = 3;
            this.lblNumeClient.Text = "Numele clientului";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(12, 203);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(92, 41);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblTrimite
            // 
            this.LblTrimite.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTrimite.Location = new System.Drawing.Point(120, 203);
            this.LblTrimite.Name = "LblTrimite";
            this.LblTrimite.Size = new System.Drawing.Size(128, 41);
            this.LblTrimite.TabIndex = 5;
            this.LblTrimite.Text = "Trimite";
            this.LblTrimite.UseVisualStyleBackColor = true;
            this.LblTrimite.Click += new System.EventHandler(this.LblTrimite_Click);
            // 
            // FrmInchiriere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 300);
            this.Controls.Add(this.LblTrimite);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.lblNumeClient);
            this.Controls.Add(this.TxtNumeClient);
            this.Controls.Add(this.TxtNume);
            this.Controls.Add(this.LblNume);
            this.Name = "FrmInchiriere";
            this.Text = "Tranzactii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNume;
        private System.Windows.Forms.TextBox TxtNume;
        private System.Windows.Forms.TextBox TxtNumeClient;
        private System.Windows.Forms.Label lblNumeClient;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button LblTrimite;
    }
}