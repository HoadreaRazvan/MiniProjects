namespace Album
{
    partial class FrmReturnare
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnTrimitere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarca.Location = new System.Drawing.Point(23, 22);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(78, 28);
            this.LblMarca.TabIndex = 0;
            this.LblMarca.Text = "Marca";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarca.Location = new System.Drawing.Point(28, 67);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(100, 26);
            this.TxtMarca.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(12, 150);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(102, 40);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnTrimitere
            // 
            this.BtnTrimitere.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrimitere.Location = new System.Drawing.Point(192, 147);
            this.BtnTrimitere.Name = "BtnTrimitere";
            this.BtnTrimitere.Size = new System.Drawing.Size(101, 43);
            this.BtnTrimitere.TabIndex = 3;
            this.BtnTrimitere.Text = "Trinite";
            this.BtnTrimitere.UseVisualStyleBackColor = true;
            this.BtnTrimitere.Click += new System.EventHandler(this.BtnTrimitere_Click);
            // 
            // FrmReturnare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 202);
            this.Controls.Add(this.BtnTrimitere);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.LblMarca);
            this.Name = "FrmReturnare";
            this.Text = "FrmReturnare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnTrimitere;
    }
}