namespace Album
{
    partial class Album
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tranzactiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzactiiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchiriereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tranzactiiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tranzactiiToolStripMenuItem
            // 
            this.tranzactiiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tranzactiiToolStripMenuItem1,
            this.modificariToolStripMenuItem});
            this.tranzactiiToolStripMenuItem.Name = "tranzactiiToolStripMenuItem";
            this.tranzactiiToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tranzactiiToolStripMenuItem.Text = "Masini";
            // 
            // tranzactiiToolStripMenuItem1
            // 
            this.tranzactiiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripMenuItem,
            this.inchiriereToolStripMenuItem,
            this.returnareToolStripMenuItem});
            this.tranzactiiToolStripMenuItem1.Name = "tranzactiiToolStripMenuItem1";
            this.tranzactiiToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tranzactiiToolStripMenuItem1.Text = "Tranzactii";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // inchiriereToolStripMenuItem
            // 
            this.inchiriereToolStripMenuItem.Name = "inchiriereToolStripMenuItem";
            this.inchiriereToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.inchiriereToolStripMenuItem.Text = "Inchiriere";
            this.inchiriereToolStripMenuItem.Click += new System.EventHandler(this.inchiriereToolStripMenuItem_Click);
            // 
            // returnareToolStripMenuItem
            // 
            this.returnareToolStripMenuItem.Name = "returnareToolStripMenuItem";
            this.returnareToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.returnareToolStripMenuItem.Text = "Returnare";
            this.returnareToolStripMenuItem.Click += new System.EventHandler(this.returnareToolStripMenuItem_Click);
            // 
            // modificariToolStripMenuItem
            // 
            this.modificariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.stergereToolStripMenuItem,
            this.updatareToolStripMenuItem});
            this.modificariToolStripMenuItem.Name = "modificariToolStripMenuItem";
            this.modificariToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificariToolStripMenuItem.Text = "Modificari";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.stergereToolStripMenuItem.Text = "Stergere";
            // 
            // updatareToolStripMenuItem
            // 
            this.updatareToolStripMenuItem.Name = "updatareToolStripMenuItem";
            this.updatareToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.updatareToolStripMenuItem.Text = "Updatare";
            // 
            // Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 404);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Album";
            this.Text = "Album";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tranzactiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzactiiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchiriereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatareToolStripMenuItem;
    }
}