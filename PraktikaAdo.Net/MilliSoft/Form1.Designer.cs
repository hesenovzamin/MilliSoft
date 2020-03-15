namespace MilliSoft
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vezifeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ısciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xerclerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.derslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telebelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vezifeToolStripMenuItem,
            this.ısciToolStripMenuItem,
            this.xerclerToolStripMenuItem,
            this.derslerToolStripMenuItem,
            this.telebelerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vezifeToolStripMenuItem
            // 
            this.vezifeToolStripMenuItem.Name = "vezifeToolStripMenuItem";
            this.vezifeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.vezifeToolStripMenuItem.Text = "Vezife";
            this.vezifeToolStripMenuItem.Click += new System.EventHandler(this.vezifeToolStripMenuItem_Click);
            // 
            // ısciToolStripMenuItem
            // 
            this.ısciToolStripMenuItem.Name = "ısciToolStripMenuItem";
            this.ısciToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.ısciToolStripMenuItem.Text = "Isci";
            this.ısciToolStripMenuItem.Click += new System.EventHandler(this.ısciToolStripMenuItem_Click);
            // 
            // xerclerToolStripMenuItem
            // 
            this.xerclerToolStripMenuItem.Name = "xerclerToolStripMenuItem";
            this.xerclerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.xerclerToolStripMenuItem.Text = "Xercler";
            this.xerclerToolStripMenuItem.Click += new System.EventHandler(this.xerclerToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // derslerToolStripMenuItem
            // 
            this.derslerToolStripMenuItem.Name = "derslerToolStripMenuItem";
            this.derslerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.derslerToolStripMenuItem.Text = "Dersler";
            this.derslerToolStripMenuItem.Click += new System.EventHandler(this.derslerToolStripMenuItem_Click);
            // 
            // telebelerToolStripMenuItem
            // 
            this.telebelerToolStripMenuItem.Name = "telebelerToolStripMenuItem";
            this.telebelerToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.telebelerToolStripMenuItem.Text = "Telebeler";
            this.telebelerToolStripMenuItem.Click += new System.EventHandler(this.telebelerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vezifeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ısciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xerclerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derslerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telebelerToolStripMenuItem;
    }
}

