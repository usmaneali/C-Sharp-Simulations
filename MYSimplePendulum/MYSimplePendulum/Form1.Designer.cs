namespace MYSimplePendulum
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simplePendulumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerCromerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simplePendulumToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simplePendulumToolStripMenuItem
            // 
            this.simplePendulumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eulerToolStripMenuItem,
            this.eulerCromerToolStripMenuItem,
            this.verletToolStripMenuItem});
            this.simplePendulumToolStripMenuItem.Name = "simplePendulumToolStripMenuItem";
            this.simplePendulumToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.simplePendulumToolStripMenuItem.Text = "SimplePendulum";
            // 
            // eulerToolStripMenuItem
            // 
            this.eulerToolStripMenuItem.Name = "eulerToolStripMenuItem";
            this.eulerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eulerToolStripMenuItem.Text = "Euler";
            this.eulerToolStripMenuItem.Click += new System.EventHandler(this.eulerToolStripMenuItem_Click);
            // 
            // eulerCromerToolStripMenuItem
            // 
            this.eulerCromerToolStripMenuItem.Name = "eulerCromerToolStripMenuItem";
            this.eulerCromerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eulerCromerToolStripMenuItem.Text = "EulerCromer";
            this.eulerCromerToolStripMenuItem.Click += new System.EventHandler(this.eulerCromerToolStripMenuItem_Click);
            // 
            // verletToolStripMenuItem
            // 
            this.verletToolStripMenuItem.Name = "verletToolStripMenuItem";
            this.verletToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verletToolStripMenuItem.Text = "Verlet";
            this.verletToolStripMenuItem.Click += new System.EventHandler(this.verletToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 467);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simplePendulumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerCromerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verletToolStripMenuItem;
    }
}

