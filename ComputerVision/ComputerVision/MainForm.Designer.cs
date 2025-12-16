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
            this.BtnUM = new System.Windows.Forms.Button();
            this.BtnFTS = new System.Windows.Forms.Button();
            this.BtnFM2 = new System.Windows.Forms.Button();
            this.BtnMarkov = new System.Windows.Forms.Button();
            this.TxtOutlier = new System.Windows.Forms.TextBox();
            this.BtnOutlier = new System.Windows.Forms.Button();
            this.BtnFM = new System.Windows.Forms.Button();
            this.TxtFTJ = new System.Windows.Forms.TextBox();
            this.BtnFTJ = new System.Windows.Forms.Button();
            this.TrackBar_Rotatie = new System.Windows.Forms.TrackBar();
            this.BtnEgalizare = new System.Windows.Forms.Button();
            this.trackBar_Constrast = new System.Windows.Forms.TrackBar();
            this.trackBar_Luminozitate = new System.Windows.Forms.TrackBar();
            this.Btn_Negativare = new System.Windows.Forms.Button();
            this.buttonGrayscale = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnKirsch = new System.Windows.Forms.Button();
            this.BtnLaplace = new System.Windows.Forms.Button();
            this.BtnRoberts = new System.Windows.Forms.Button();
            this.BtnPrewitt = new System.Windows.Forms.Button();
            this.BtnFreiChen = new System.Windows.Forms.Button();
            this.BtnGabor = new System.Windows.Forms.Button();
            this.BtnSM = new System.Windows.Forms.Button();
            this.TxtSM = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Rotatie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Constrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Luminozitate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSource
            // 
            this.panelSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSource.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelSource.Location = new System.Drawing.Point(18, 18);
            this.panelSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSource.Name = "panelSource";
            this.panelSource.Size = new System.Drawing.Size(478, 367);
            this.panelSource.TabIndex = 0;
            // 
            // panelDestination
            // 
            this.panelDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDestination.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDestination.Location = new System.Drawing.Point(522, 18);
            this.panelDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDestination.Name = "panelDestination";
            this.panelDestination.Size = new System.Drawing.Size(478, 367);
            this.panelDestination.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(18, 675);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(112, 35);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnUM);
            this.panel1.Controls.Add(this.BtnFTS);
            this.panel1.Controls.Add(this.BtnFM2);
            this.panel1.Controls.Add(this.BtnMarkov);
            this.panel1.Controls.Add(this.TxtOutlier);
            this.panel1.Controls.Add(this.BtnOutlier);
            this.panel1.Controls.Add(this.BtnFM);
            this.panel1.Controls.Add(this.TxtFTJ);
            this.panel1.Controls.Add(this.BtnFTJ);
            this.panel1.Controls.Add(this.TrackBar_Rotatie);
            this.panel1.Controls.Add(this.BtnEgalizare);
            this.panel1.Controls.Add(this.trackBar_Constrast);
            this.panel1.Controls.Add(this.trackBar_Luminozitate);
            this.panel1.Controls.Add(this.Btn_Negativare);
            this.panel1.Controls.Add(this.buttonGrayscale);
            this.panel1.Location = new System.Drawing.Point(522, 417);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 291);
            this.panel1.TabIndex = 3;
            // 
            // BtnUM
            // 
            this.BtnUM.Location = new System.Drawing.Point(366, 172);
            this.BtnUM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnUM.Name = "BtnUM";
            this.BtnUM.Size = new System.Drawing.Size(112, 35);
            this.BtnUM.TabIndex = 30;
            this.BtnUM.Text = "Unsharp Masking";
            this.BtnUM.UseVisualStyleBackColor = true;
            this.BtnUM.Click += new System.EventHandler(this.BtnUM_Click);
            // 
            // BtnFTS
            // 
            this.BtnFTS.Location = new System.Drawing.Point(365, 247);
            this.BtnFTS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFTS.Name = "BtnFTS";
            this.BtnFTS.Size = new System.Drawing.Size(112, 35);
            this.BtnFTS.TabIndex = 29;
            this.BtnFTS.Text = "FTS";
            this.BtnFTS.UseVisualStyleBackColor = true;
            this.BtnFTS.Click += new System.EventHandler(this.BtnFTS_Click);
            // 
            // BtnFM2
            // 
            this.BtnFM2.Location = new System.Drawing.Point(365, 211);
            this.BtnFM2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFM2.Name = "BtnFM2";
            this.BtnFM2.Size = new System.Drawing.Size(112, 35);
            this.BtnFM2.TabIndex = 28;
            this.BtnFM2.Text = "F. Median 2";
            this.BtnFM2.UseVisualStyleBackColor = true;
            this.BtnFM2.Click += new System.EventHandler(this.BtnFM2_Click);
            // 
            // BtnMarkov
            // 
            this.BtnMarkov.Location = new System.Drawing.Point(252, 171);
            this.BtnMarkov.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMarkov.Name = "BtnMarkov";
            this.BtnMarkov.Size = new System.Drawing.Size(112, 35);
            this.BtnMarkov.TabIndex = 27;
            this.BtnMarkov.Text = "Markov";
            this.BtnMarkov.UseVisualStyleBackColor = true;
            this.BtnMarkov.Click += new System.EventHandler(this.BtnMarkov_Click);
            // 
            // TxtOutlier
            // 
            this.TxtOutlier.Location = new System.Drawing.Point(142, 176);
            this.TxtOutlier.Name = "TxtOutlier";
            this.TxtOutlier.Size = new System.Drawing.Size(100, 26);
            this.TxtOutlier.TabIndex = 26;
            // 
            // BtnOutlier
            // 
            this.BtnOutlier.Location = new System.Drawing.Point(10, 171);
            this.BtnOutlier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOutlier.Name = "BtnOutlier";
            this.BtnOutlier.Size = new System.Drawing.Size(112, 35);
            this.BtnOutlier.TabIndex = 25;
            this.BtnOutlier.Text = "Outlier";
            this.BtnOutlier.UseVisualStyleBackColor = true;
            this.BtnOutlier.Click += new System.EventHandler(this.BtnOutlier_Click);
            // 
            // BtnFM
            // 
            this.BtnFM.Location = new System.Drawing.Point(252, 211);
            this.BtnFM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFM.Name = "BtnFM";
            this.BtnFM.Size = new System.Drawing.Size(112, 35);
            this.BtnFM.TabIndex = 24;
            this.BtnFM.Text = "F. Median";
            this.BtnFM.UseVisualStyleBackColor = true;
            this.BtnFM.Click += new System.EventHandler(this.BtnFM_Click);
            // 
            // TxtFTJ
            // 
            this.TxtFTJ.Location = new System.Drawing.Point(142, 215);
            this.TxtFTJ.Name = "TxtFTJ";
            this.TxtFTJ.Size = new System.Drawing.Size(100, 26);
            this.TxtFTJ.TabIndex = 23;
            // 
            // BtnFTJ
            // 
            this.BtnFTJ.Location = new System.Drawing.Point(10, 211);
            this.BtnFTJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFTJ.Name = "BtnFTJ";
            this.BtnFTJ.Size = new System.Drawing.Size(112, 35);
            this.BtnFTJ.TabIndex = 22;
            this.BtnFTJ.Text = "FTJ";
            this.BtnFTJ.UseVisualStyleBackColor = true;
            this.BtnFTJ.Click += new System.EventHandler(this.BtnFTJ_Click);
            // 
            // TrackBar_Rotatie
            // 
            this.TrackBar_Rotatie.Location = new System.Drawing.Point(8, 111);
            this.TrackBar_Rotatie.Maximum = 360;
            this.TrackBar_Rotatie.Name = "TrackBar_Rotatie";
            this.TrackBar_Rotatie.Size = new System.Drawing.Size(464, 69);
            this.TrackBar_Rotatie.TabIndex = 21;
            this.TrackBar_Rotatie.Scroll += new System.EventHandler(this.TrackBar_Rotatie_Scroll);
            // 
            // BtnEgalizare
            // 
            this.BtnEgalizare.Location = new System.Drawing.Point(252, 247);
            this.BtnEgalizare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEgalizare.Name = "BtnEgalizare";
            this.BtnEgalizare.Size = new System.Drawing.Size(112, 35);
            this.BtnEgalizare.TabIndex = 20;
            this.BtnEgalizare.Text = "Egalizare";
            this.BtnEgalizare.UseVisualStyleBackColor = true;
            this.BtnEgalizare.Click += new System.EventHandler(this.BtnEgalizare_Click);
            // 
            // trackBar_Constrast
            // 
            this.trackBar_Constrast.Location = new System.Drawing.Point(10, 58);
            this.trackBar_Constrast.Maximum = 120;
            this.trackBar_Constrast.Minimum = -120;
            this.trackBar_Constrast.Name = "trackBar_Constrast";
            this.trackBar_Constrast.Size = new System.Drawing.Size(464, 69);
            this.trackBar_Constrast.TabIndex = 17;
            this.trackBar_Constrast.Scroll += new System.EventHandler(this.trackBar_Constrast_Scroll);
            // 
            // trackBar_Luminozitate
            // 
            this.trackBar_Luminozitate.Location = new System.Drawing.Point(10, 11);
            this.trackBar_Luminozitate.Maximum = 255;
            this.trackBar_Luminozitate.Minimum = -255;
            this.trackBar_Luminozitate.Name = "trackBar_Luminozitate";
            this.trackBar_Luminozitate.Size = new System.Drawing.Size(464, 69);
            this.trackBar_Luminozitate.TabIndex = 16;
            this.trackBar_Luminozitate.Scroll += new System.EventHandler(this.trackBar_Luminozitate_Scroll);
            // 
            // Btn_Negativare
            // 
            this.Btn_Negativare.Location = new System.Drawing.Point(130, 247);
            this.Btn_Negativare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Negativare.Name = "Btn_Negativare";
            this.Btn_Negativare.Size = new System.Drawing.Size(112, 35);
            this.Btn_Negativare.TabIndex = 14;
            this.Btn_Negativare.Text = "Negativare";
            this.Btn_Negativare.UseVisualStyleBackColor = true;
            this.Btn_Negativare.Click += new System.EventHandler(this.Btn_Negativare_Click);
            // 
            // buttonGrayscale
            // 
            this.buttonGrayscale.Location = new System.Drawing.Point(10, 247);
            this.buttonGrayscale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGrayscale.Name = "buttonGrayscale";
            this.buttonGrayscale.Size = new System.Drawing.Size(112, 35);
            this.buttonGrayscale.TabIndex = 13;
            this.buttonGrayscale.Text = "Grayscale";
            this.buttonGrayscale.UseVisualStyleBackColor = true;
            this.buttonGrayscale.Click += new System.EventHandler(this.buttonGrayscale_Click);
            // 
            // BtnKirsch
            // 
            this.BtnKirsch.Location = new System.Drawing.Point(402, 665);
            this.BtnKirsch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnKirsch.Name = "BtnKirsch";
            this.BtnKirsch.Size = new System.Drawing.Size(112, 35);
            this.BtnKirsch.TabIndex = 31;
            this.BtnKirsch.Text = "Kirsch";
            this.BtnKirsch.UseVisualStyleBackColor = true;
            this.BtnKirsch.Click += new System.EventHandler(this.BtnKirsch_Click);
            // 
            // BtnLaplace
            // 
            this.BtnLaplace.Location = new System.Drawing.Point(402, 629);
            this.BtnLaplace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLaplace.Name = "BtnLaplace";
            this.BtnLaplace.Size = new System.Drawing.Size(112, 35);
            this.BtnLaplace.TabIndex = 32;
            this.BtnLaplace.Text = "Laplace";
            this.BtnLaplace.UseVisualStyleBackColor = true;
            this.BtnLaplace.Click += new System.EventHandler(this.BtnLaplace_Click);
            // 
            // BtnRoberts
            // 
            this.BtnRoberts.Location = new System.Drawing.Point(402, 590);
            this.BtnRoberts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRoberts.Name = "BtnRoberts";
            this.BtnRoberts.Size = new System.Drawing.Size(112, 35);
            this.BtnRoberts.TabIndex = 33;
            this.BtnRoberts.Text = "Roberts";
            this.BtnRoberts.UseVisualStyleBackColor = true;
            this.BtnRoberts.Click += new System.EventHandler(this.BtnRoberts_Click);
            // 
            // BtnPrewitt
            // 
            this.BtnPrewitt.Location = new System.Drawing.Point(402, 545);
            this.BtnPrewitt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPrewitt.Name = "BtnPrewitt";
            this.BtnPrewitt.Size = new System.Drawing.Size(112, 35);
            this.BtnPrewitt.TabIndex = 34;
            this.BtnPrewitt.Text = "Prewitt";
            this.BtnPrewitt.UseVisualStyleBackColor = true;
            this.BtnPrewitt.Click += new System.EventHandler(this.BtnPrewitt_Click);
            // 
            // BtnFreiChen
            // 
            this.BtnFreiChen.Location = new System.Drawing.Point(402, 500);
            this.BtnFreiChen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFreiChen.Name = "BtnFreiChen";
            this.BtnFreiChen.Size = new System.Drawing.Size(112, 35);
            this.BtnFreiChen.TabIndex = 35;
            this.BtnFreiChen.Text = "Frei-Chen";
            this.BtnFreiChen.UseVisualStyleBackColor = true;
            this.BtnFreiChen.Click += new System.EventHandler(this.BtnFreiChen_Click);
            // 
            // BtnGabor
            // 
            this.BtnGabor.Location = new System.Drawing.Point(402, 455);
            this.BtnGabor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGabor.Name = "BtnGabor";
            this.BtnGabor.Size = new System.Drawing.Size(112, 35);
            this.BtnGabor.TabIndex = 36;
            this.BtnGabor.Text = "Gabor";
            this.BtnGabor.UseVisualStyleBackColor = true;
            this.BtnGabor.Click += new System.EventHandler(this.BtnGabor_Click);
            // 
            // BtnSM
            // 
            this.BtnSM.Location = new System.Drawing.Point(29, 455);
            this.BtnSM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSM.Name = "BtnSM";
            this.BtnSM.Size = new System.Drawing.Size(174, 35);
            this.BtnSM.TabIndex = 37;
            this.BtnSM.Text = "Splitting and Merging";
            this.BtnSM.UseVisualStyleBackColor = true;
            this.BtnSM.Click += new System.EventHandler(this.BtnSM_Click);
            // 
            // TxtSM
            // 
            this.TxtSM.Location = new System.Drawing.Point(228, 459);
            this.TxtSM.Name = "TxtSM";
            this.TxtSM.Size = new System.Drawing.Size(100, 26);
            this.TxtSM.TabIndex = 38;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 728);
            this.Controls.Add(this.TxtSM);
            this.Controls.Add(this.BtnSM);
            this.Controls.Add(this.BtnGabor);
            this.Controls.Add(this.BtnFreiChen);
            this.Controls.Add(this.BtnPrewitt);
            this.Controls.Add(this.BtnRoberts);
            this.Controls.Add(this.BtnLaplace);
            this.Controls.Add(this.BtnKirsch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.panelDestination);
            this.Controls.Add(this.panelSource);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Rotatie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Constrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Luminozitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button BtnFTJ;
        private System.Windows.Forms.TextBox TxtFTJ;
        private System.Windows.Forms.Button BtnFM;
        private System.Windows.Forms.TextBox TxtOutlier;
        private System.Windows.Forms.Button BtnOutlier;
        private System.Windows.Forms.Button BtnMarkov;
        private System.Windows.Forms.Button BtnFM2;
        private System.Windows.Forms.Button BtnFTS;
        private System.Windows.Forms.Button BtnUM;
        private System.Windows.Forms.Button BtnKirsch;
        private System.Windows.Forms.Button BtnLaplace;
        private System.Windows.Forms.Button BtnRoberts;
        private System.Windows.Forms.Button BtnPrewitt;
        private System.Windows.Forms.Button BtnFreiChen;
        private System.Windows.Forms.Button BtnGabor;
        private System.Windows.Forms.Button BtnSM;
        private System.Windows.Forms.TextBox TxtSM;
    }
}

