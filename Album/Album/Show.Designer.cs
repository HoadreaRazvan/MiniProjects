namespace Album
{
    partial class Show
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
            this.lstStatus = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstStatus
            // 
            this.lstStatus.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstStatus.GridLines = true;
            this.lstStatus.HideSelection = false;
            this.lstStatus.Location = new System.Drawing.Point(0, 1);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(607, 415);
            this.lstStatus.TabIndex = 0;
            this.lstStatus.UseCompatibleStateImageBehavior = false;
            this.lstStatus.View = System.Windows.Forms.View.Details;
            this.lstStatus.SelectedIndexChanged += new System.EventHandler(this.lstStatus_SelectedIndexChanged);
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 416);
            this.Controls.Add(this.lstStatus);
            this.Name = "Show";
            this.Text = "Show";
            this.Load += new System.EventHandler(this.Show_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstStatus;
    }
}