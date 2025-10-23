namespace ComputerVision
{
    partial class MainForm
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
            this.panelSource = new System.Windows.Forms.Panel();
            this.panelDestination = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar_Constrast = new System.Windows.Forms.TrackBar();
            this.trackBar_Luminozitate = new System.Windows.Forms.TrackBar();
            this.Btn_Negativare = new System.Windows.Forms.Button();
            this.buttonGrayscale = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TrackBar_Rotatie = new System.Windows.Forms.TrackBar();
            this.BtnEgalizare = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Constrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Luminozitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Rotatie)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSource
            // 
            this.panelSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSource.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelSource.Location = new System.Drawing.Point(12, 12);
            this.panelSource.Name = "panelSource";
            this.panelSource.Size = new System.Drawing.Size(320, 240);
            this.panelSource.TabIndex = 0;
            // 
            // panelDestination
            // 
            this.panelDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDestination.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDestination.Location = new System.Drawing.Point(348, 12);
            this.panelDestination.Name = "panelDestination";
            this.panelDestination.Size = new System.Drawing.Size(320, 240);
            this.panelDestination.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 439);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TrackBar_Rotatie);
            this.panel1.Controls.Add(this.BtnEgalizare);
            this.panel1.Controls.Add(this.trackBar_Constrast);
            this.panel1.Controls.Add(this.trackBar_Luminozitate);
            this.panel1.Controls.Add(this.Btn_Negativare);
            this.panel1.Controls.Add(this.buttonGrayscale);
            this.panel1.Location = new System.Drawing.Point(348, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 190);
            this.panel1.TabIndex = 3;
            // 
            // trackBar_Constrast
            // 
            this.trackBar_Constrast.Location = new System.Drawing.Point(7, 38);
            this.trackBar_Constrast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar_Constrast.Maximum = 120;
            this.trackBar_Constrast.Minimum = -120;
            this.trackBar_Constrast.Name = "trackBar_Constrast";
            this.trackBar_Constrast.Size = new System.Drawing.Size(309, 45);
            this.trackBar_Constrast.TabIndex = 17;
            this.trackBar_Constrast.Scroll += new System.EventHandler(this.trackBar_Constrast_Scroll);
            // 
            // trackBar_Luminozitate
            // 
            this.trackBar_Luminozitate.Location = new System.Drawing.Point(7, 7);
            this.trackBar_Luminozitate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar_Luminozitate.Maximum = 255;
            this.trackBar_Luminozitate.Minimum = -255;
            this.trackBar_Luminozitate.Name = "trackBar_Luminozitate";
            this.trackBar_Luminozitate.Size = new System.Drawing.Size(309, 45);
            this.trackBar_Luminozitate.TabIndex = 16;
            this.trackBar_Luminozitate.Scroll += new System.EventHandler(this.trackBar_Luminozitate_Scroll);
            // 
            // Btn_Negativare
            // 
            this.Btn_Negativare.Location = new System.Drawing.Point(87, 155);
            this.Btn_Negativare.Name = "Btn_Negativare";
            this.Btn_Negativare.Size = new System.Drawing.Size(75, 23);
            this.Btn_Negativare.TabIndex = 14;
            this.Btn_Negativare.Text = "Negativare";
            this.Btn_Negativare.UseVisualStyleBackColor = true;
            this.Btn_Negativare.Click += new System.EventHandler(this.Btn_Negativare_Click);
            // 
            // buttonGrayscale
            // 
            this.buttonGrayscale.Location = new System.Drawing.Point(7, 155);
            this.buttonGrayscale.Name = "buttonGrayscale";
            this.buttonGrayscale.Size = new System.Drawing.Size(75, 23);
            this.buttonGrayscale.TabIndex = 13;
            this.buttonGrayscale.Text = "Grayscale";
            this.buttonGrayscale.UseVisualStyleBackColor = true;
            this.buttonGrayscale.Click += new System.EventHandler(this.buttonGrayscale_Click);
            // 
            // TrackBar_Rotatie
            // 
            this.TrackBar_Rotatie.Location = new System.Drawing.Point(5, 72);
            this.TrackBar_Rotatie.Margin = new System.Windows.Forms.Padding(2);
            this.TrackBar_Rotatie.Maximum = 360;
            this.TrackBar_Rotatie.Name = "TrackBar_Rotatie";
            this.TrackBar_Rotatie.Size = new System.Drawing.Size(309, 45);
            this.TrackBar_Rotatie.TabIndex = 21;
            this.TrackBar_Rotatie.Scroll += new System.EventHandler(this.TrackBar_Rotatie_Scroll);
            // 
            // BtnEgalizare
            // 
            this.BtnEgalizare.Location = new System.Drawing.Point(168, 155);
            this.BtnEgalizare.Name = "BtnEgalizare";
            this.BtnEgalizare.Size = new System.Drawing.Size(75, 23);
            this.BtnEgalizare.TabIndex = 20;
            this.BtnEgalizare.Text = "Egalizare";
            this.BtnEgalizare.UseVisualStyleBackColor = true;
            this.BtnEgalizare.Click += new System.EventHandler(this.BtnEgalizare_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.panelDestination);
            this.Controls.Add(this.panelSource);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Constrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Luminozitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Rotatie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSource;
        private System.Windows.Forms.Panel panelDestination;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGrayscale;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button Btn_Negativare;
        private System.Windows.Forms.TrackBar trackBar_Luminozitate;
        private System.Windows.Forms.TrackBar trackBar_Constrast;
        private System.Windows.Forms.TrackBar TrackBar_Rotatie;
        private System.Windows.Forms.Button BtnEgalizare;
    }
}

