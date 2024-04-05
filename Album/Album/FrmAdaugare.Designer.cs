namespace Album
{
    partial class FrmAdaugare
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
            this.LblMarca = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPret = new System.Windows.Forms.TextBox();
            this.TxtKm = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnTrimitere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarca.Location = new System.Drawing.Point(12, 15);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(72, 26);
            this.LblMarca.TabIndex = 0;
            this.LblMarca.Text = "Marca";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarca.Location = new System.Drawing.Point(129, 19);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(100, 22);
            this.TxtMarca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kilometri";
            // 
            // TxtPret
            // 
            this.TxtPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPret.Location = new System.Drawing.Point(129, 106);
            this.TxtPret.Name = "TxtPret";
            this.TxtPret.Size = new System.Drawing.Size(100, 22);
            this.TxtPret.TabIndex = 7;
            // 
            // TxtKm
            // 
            this.TxtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKm.Location = new System.Drawing.Point(129, 63);
            this.TxtKm.Name = "TxtKm";
            this.TxtKm.Size = new System.Drawing.Size(100, 22);
            this.TxtKm.TabIndex = 8;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(17, 179);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 34);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnTrimitere
            // 
            this.BtnTrimitere.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrimitere.Location = new System.Drawing.Point(233, 179);
            this.BtnTrimitere.Name = "BtnTrimitere";
            this.BtnTrimitere.Size = new System.Drawing.Size(90, 34);
            this.BtnTrimitere.TabIndex = 10;
            this.BtnTrimitere.Text = "Trimite";
            this.BtnTrimitere.UseVisualStyleBackColor = true;
            this.BtnTrimitere.Click += new System.EventHandler(this.BtnTrimitere_Click);
            // 
            // FrmAdaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 228);
            this.Controls.Add(this.BtnTrimitere);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxtKm);
            this.Controls.Add(this.TxtPret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.LblMarca);
            this.Name = "FrmAdaugare";
            this.Text = "Adaugare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPret;
        private System.Windows.Forms.TextBox TxtKm;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnTrimitere;
    }
}