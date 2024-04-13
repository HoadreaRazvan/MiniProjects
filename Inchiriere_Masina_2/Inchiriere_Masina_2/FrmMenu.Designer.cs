namespace Inchiriere_Masina_2
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.LvwTabel = new System.Windows.Forms.ListView();
            this.TspFunctii = new System.Windows.Forms.ToolStrip();
            this.BtnAdd = new System.Windows.Forms.ToolStripButton();
            this.BtnShow = new System.Windows.Forms.ToolStripButton();
            this.TspFunctii.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvwTabel
            // 
            this.LvwTabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LvwTabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LvwTabel.GridLines = true;
            this.LvwTabel.HideSelection = false;
            this.LvwTabel.Location = new System.Drawing.Point(12, 51);
            this.LvwTabel.Name = "LvwTabel";
            this.LvwTabel.Size = new System.Drawing.Size(705, 273);
            this.LvwTabel.TabIndex = 0;
            this.LvwTabel.UseCompatibleStateImageBehavior = false;
            this.LvwTabel.View = System.Windows.Forms.View.Details;
            // 
            // TspFunctii
            // 
            this.TspFunctii.AutoSize = false;
            this.TspFunctii.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnShow,
            this.BtnAdd});
            this.TspFunctii.Location = new System.Drawing.Point(0, 0);
            this.TspFunctii.Name = "TspFunctii";
            this.TspFunctii.Size = new System.Drawing.Size(733, 33);
            this.TspFunctii.TabIndex = 1;
            this.TspFunctii.Text = "toolStrip1";
            // 
            // BtnAdd
            // 
            this.BtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(23, 30);
            this.BtnAdd.Text = "toolStripButton1";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnShow.Image = ((System.Drawing.Image)(resources.GetObject("BtnShow.Image")));
            this.BtnShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(23, 30);
            this.BtnShow.Text = "toolStripButton2";
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 336);
            this.Controls.Add(this.TspFunctii);
            this.Controls.Add(this.LvwTabel);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.TspFunctii.ResumeLayout(false);
            this.TspFunctii.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvwTabel;
        private System.Windows.Forms.ToolStrip TspFunctii;
        private System.Windows.Forms.ToolStripButton BtnAdd;
        private System.Windows.Forms.ToolStripButton BtnShow;
    }
}