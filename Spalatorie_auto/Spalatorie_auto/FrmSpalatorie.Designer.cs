namespace Spalatorie_auto
{
    partial class FrmSpalatorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpalatorie));
            this.gbSercivii = new System.Windows.Forms.GroupBox();
            this.chMotor = new System.Windows.Forms.CheckBox();
            this.chExterior = new System.Windows.Forms.CheckBox();
            this.chInterior = new System.Windows.Forms.CheckBox();
            this.chAmbele = new System.Windows.Forms.CheckBox();
            this.chAutoturism = new System.Windows.Forms.CheckBox();
            this.lblServicii = new System.Windows.Forms.Label();
            this.lblAutovehicul = new System.Windows.Forms.Label();
            this.gbAutovehicul = new System.Windows.Forms.GroupBox();
            this.chMica35t = new System.Windows.Forms.CheckBox();
            this.chMare35t = new System.Windows.Forms.CheckBox();
            this.chSUV = new System.Windows.Forms.CheckBox();
            this.txtBaccis = new System.Windows.Forms.TextBox();
            this.lblPreturi = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAfisare = new System.Windows.Forms.Label();
            this.txtAchitare = new System.Windows.Forms.TextBox();
            this.lblAchitare = new System.Windows.Forms.Label();
            this.lblRest = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbRest = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gbSercivii.SuspendLayout();
            this.gbAutovehicul.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSercivii
            // 
            this.gbSercivii.Controls.Add(this.chMotor);
            this.gbSercivii.Controls.Add(this.chExterior);
            this.gbSercivii.Controls.Add(this.chInterior);
            this.gbSercivii.Controls.Add(this.chAmbele);
            this.gbSercivii.Location = new System.Drawing.Point(220, 101);
            this.gbSercivii.Name = "gbSercivii";
            this.gbSercivii.Size = new System.Drawing.Size(190, 196);
            this.gbSercivii.TabIndex = 0;
            this.gbSercivii.TabStop = false;
            // 
            // chMotor
            // 
            this.chMotor.AutoSize = true;
            this.chMotor.Location = new System.Drawing.Point(17, 131);
            this.chMotor.Name = "chMotor";
            this.chMotor.Size = new System.Drawing.Size(53, 17);
            this.chMotor.TabIndex = 3;
            this.chMotor.Text = "Motor";
            this.chMotor.UseVisualStyleBackColor = true;
            // 
            // chExterior
            // 
            this.chExterior.AutoSize = true;
            this.chExterior.Location = new System.Drawing.Point(17, 94);
            this.chExterior.Name = "chExterior";
            this.chExterior.Size = new System.Drawing.Size(61, 17);
            this.chExterior.TabIndex = 2;
            this.chExterior.Text = "Exterior";
            this.chExterior.UseVisualStyleBackColor = true;
            this.chExterior.CheckedChanged += new System.EventHandler(this.chExterior_CheckedChanged);
            // 
            // chInterior
            // 
            this.chInterior.AutoSize = true;
            this.chInterior.Location = new System.Drawing.Point(17, 60);
            this.chInterior.Name = "chInterior";
            this.chInterior.Size = new System.Drawing.Size(58, 17);
            this.chInterior.TabIndex = 1;
            this.chInterior.Text = "Interior";
            this.chInterior.UseVisualStyleBackColor = true;
            this.chInterior.CheckedChanged += new System.EventHandler(this.chInterior_CheckedChanged);
            // 
            // chAmbele
            // 
            this.chAmbele.AutoSize = true;
            this.chAmbele.Location = new System.Drawing.Point(17, 28);
            this.chAmbele.Name = "chAmbele";
            this.chAmbele.Size = new System.Drawing.Size(99, 17);
            this.chAmbele.TabIndex = 0;
            this.chAmbele.Text = "Interior+Exterior";
            this.chAmbele.UseVisualStyleBackColor = true;
            this.chAmbele.CheckedChanged += new System.EventHandler(this.chAmbele_CheckedChanged);
            // 
            // chAutoturism
            // 
            this.chAutoturism.AutoSize = true;
            this.chAutoturism.Location = new System.Drawing.Point(6, 28);
            this.chAutoturism.Name = "chAutoturism";
            this.chAutoturism.Size = new System.Drawing.Size(75, 17);
            this.chAutoturism.TabIndex = 0;
            this.chAutoturism.Text = "Autoturism";
            this.chAutoturism.UseVisualStyleBackColor = true;
            this.chAutoturism.CheckedChanged += new System.EventHandler(this.chAutoturism_CheckedChanged);
            // 
            // lblServicii
            // 
            this.lblServicii.AutoSize = true;
            this.lblServicii.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicii.Location = new System.Drawing.Point(274, 57);
            this.lblServicii.Name = "lblServicii";
            this.lblServicii.Size = new System.Drawing.Size(87, 28);
            this.lblServicii.TabIndex = 1;
            this.lblServicii.Text = "Servicii";
            // 
            // lblAutovehicul
            // 
            this.lblAutovehicul.AutoSize = true;
            this.lblAutovehicul.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutovehicul.Location = new System.Drawing.Point(42, 57);
            this.lblAutovehicul.Name = "lblAutovehicul";
            this.lblAutovehicul.Size = new System.Drawing.Size(140, 28);
            this.lblAutovehicul.TabIndex = 3;
            this.lblAutovehicul.Text = "Autovehicul";
            // 
            // gbAutovehicul
            // 
            this.gbAutovehicul.Controls.Add(this.chMica35t);
            this.gbAutovehicul.Controls.Add(this.chMare35t);
            this.gbAutovehicul.Controls.Add(this.chAutoturism);
            this.gbAutovehicul.Controls.Add(this.chSUV);
            this.gbAutovehicul.Location = new System.Drawing.Point(41, 101);
            this.gbAutovehicul.Name = "gbAutovehicul";
            this.gbAutovehicul.Size = new System.Drawing.Size(155, 196);
            this.gbAutovehicul.TabIndex = 4;
            this.gbAutovehicul.TabStop = false;
            // 
            // chMica35t
            // 
            this.chMica35t.AutoSize = true;
            this.chMica35t.Location = new System.Drawing.Point(6, 131);
            this.chMica35t.Name = "chMica35t";
            this.chMica35t.Size = new System.Drawing.Size(114, 17);
            this.chMica35t.TabIndex = 7;
            this.chMica35t.Text = "Autoutilitara > 3,5 t";
            this.chMica35t.UseVisualStyleBackColor = true;
            this.chMica35t.CheckedChanged += new System.EventHandler(this.chMica35t_CheckedChanged);
            // 
            // chMare35t
            // 
            this.chMare35t.AutoSize = true;
            this.chMare35t.Location = new System.Drawing.Point(6, 94);
            this.chMare35t.Name = "chMare35t";
            this.chMare35t.Size = new System.Drawing.Size(114, 17);
            this.chMare35t.TabIndex = 6;
            this.chMare35t.Text = "Autoutilitara < 3,5 t";
            this.chMare35t.UseVisualStyleBackColor = true;
            this.chMare35t.CheckedChanged += new System.EventHandler(this.chMare35t_CheckedChanged);
            // 
            // chSUV
            // 
            this.chSUV.AutoSize = true;
            this.chSUV.Location = new System.Drawing.Point(6, 60);
            this.chSUV.Name = "chSUV";
            this.chSUV.Size = new System.Drawing.Size(48, 17);
            this.chSUV.TabIndex = 5;
            this.chSUV.Text = "SUV";
            this.chSUV.UseVisualStyleBackColor = true;
            this.chSUV.CheckedChanged += new System.EventHandler(this.chSUV_CheckedChanged);
            // 
            // txtBaccis
            // 
            this.txtBaccis.Location = new System.Drawing.Point(468, 386);
            this.txtBaccis.Name = "txtBaccis";
            this.txtBaccis.Size = new System.Drawing.Size(64, 20);
            this.txtBaccis.TabIndex = 5;
            // 
            // lblPreturi
            // 
            this.lblPreturi.AutoSize = true;
            this.lblPreturi.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreturi.Location = new System.Drawing.Point(412, 347);
            this.lblPreturi.Name = "lblPreturi";
            this.lblPreturi.Size = new System.Drawing.Size(183, 26);
            this.lblPreturi.TabIndex = 6;
            this.lblPreturi.Text = "Introduceti Baccis";
            this.lblPreturi.Click += new System.EventHandler(this.lblPreturi_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(541, 145);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(147, 43);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculeaza";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAfisare
            // 
            this.lblAfisare.AutoSize = true;
            this.lblAfisare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAfisare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfisare.Location = new System.Drawing.Point(12, 357);
            this.lblAfisare.Name = "lblAfisare";
            this.lblAfisare.Size = new System.Drawing.Size(139, 24);
            this.lblAfisare.TabIndex = 8;
            this.lblAfisare.Text = "Pretul este de";
            this.lblAfisare.Visible = false;
            // 
            // txtAchitare
            // 
            this.txtAchitare.Location = new System.Drawing.Point(295, 386);
            this.txtAchitare.Name = "txtAchitare";
            this.txtAchitare.Size = new System.Drawing.Size(75, 20);
            this.txtAchitare.TabIndex = 9;
            // 
            // lblAchitare
            // 
            this.lblAchitare.AutoSize = true;
            this.lblAchitare.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchitare.Location = new System.Drawing.Point(290, 347);
            this.lblAchitare.Name = "lblAchitare";
            this.lblAchitare.Size = new System.Drawing.Size(92, 26);
            this.lblAchitare.TabIndex = 10;
            this.lblAchitare.Text = "Achitare";
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRest.Location = new System.Drawing.Point(675, 347);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(53, 26);
            this.lblRest.TabIndex = 11;
            this.lblRest.Text = "Rest";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(541, 217);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 40);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbRest
            // 
            this.tbRest.Location = new System.Drawing.Point(657, 386);
            this.tbRest.Name = "tbRest";
            this.tbRest.Size = new System.Drawing.Size(100, 20);
            this.tbRest.TabIndex = 13;
            // 
            // FrmSpalatorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbRest);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblRest);
            this.Controls.Add(this.lblAchitare);
            this.Controls.Add(this.txtAchitare);
            this.Controls.Add(this.lblAfisare);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPreturi);
            this.Controls.Add(this.txtBaccis);
            this.Controls.Add(this.gbAutovehicul);
            this.Controls.Add(this.lblAutovehicul);
            this.Controls.Add(this.lblServicii);
            this.Controls.Add(this.gbSercivii);
            this.Name = "FrmSpalatorie";
            this.Text = "SpalatoriaHoadrea";
            this.Load += new System.EventHandler(this.FrmSpalatorie_Load);
            this.gbSercivii.ResumeLayout(false);
            this.gbSercivii.PerformLayout();
            this.gbAutovehicul.ResumeLayout(false);
            this.gbAutovehicul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSercivii;
        private System.Windows.Forms.CheckBox chMotor;
        private System.Windows.Forms.CheckBox chExterior;
        private System.Windows.Forms.CheckBox chInterior;
        private System.Windows.Forms.CheckBox chAmbele;
        private System.Windows.Forms.CheckBox chAutoturism;
        private System.Windows.Forms.Label lblServicii;
        private System.Windows.Forms.Label lblAutovehicul;
        private System.Windows.Forms.GroupBox gbAutovehicul;
        private System.Windows.Forms.CheckBox chMica35t;
        private System.Windows.Forms.CheckBox chMare35t;
        private System.Windows.Forms.CheckBox chSUV;
        private System.Windows.Forms.TextBox txtBaccis;
        private System.Windows.Forms.Label lblPreturi;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAfisare;
        private System.Windows.Forms.TextBox txtAchitare;
        private System.Windows.Forms.Label lblAchitare;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbRest;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}