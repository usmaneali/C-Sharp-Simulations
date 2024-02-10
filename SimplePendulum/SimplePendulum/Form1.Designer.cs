namespace SimplePendulum
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
            this.verlutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerChromerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rungeKutaMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rungeKuta4MethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simplePendulumToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1249, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simplePendulumToolStripMenuItem
            // 
            this.simplePendulumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eulerToolStripMenuItem,
            this.verlutToolStripMenuItem,
            this.eulerChromerToolStripMenuItem,
            this.rungeKutaMethodToolStripMenuItem,
            this.rungeKuta4MethodToolStripMenuItem});
            this.simplePendulumToolStripMenuItem.Name = "simplePendulumToolStripMenuItem";
            this.simplePendulumToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.simplePendulumToolStripMenuItem.Text = "Simple Pendulum";
            // 
            // eulerToolStripMenuItem
            // 
            this.eulerToolStripMenuItem.Name = "eulerToolStripMenuItem";
            this.eulerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.eulerToolStripMenuItem.Text = "Euler Method";
            this.eulerToolStripMenuItem.Click += new System.EventHandler(this.eulerToolStripMenuItem_Click);
            // 
            // verlutToolStripMenuItem
            // 
            this.verlutToolStripMenuItem.Name = "verlutToolStripMenuItem";
            this.verlutToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.verlutToolStripMenuItem.Text = "Verlut Method";
            this.verlutToolStripMenuItem.Click += new System.EventHandler(this.verlutToolStripMenuItem_Click);
            // 
            // eulerChromerToolStripMenuItem
            // 
            this.eulerChromerToolStripMenuItem.Name = "eulerChromerToolStripMenuItem";
            this.eulerChromerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.eulerChromerToolStripMenuItem.Text = "Euler Chromer";
            this.eulerChromerToolStripMenuItem.Click += new System.EventHandler(this.eulerChromerToolStripMenuItem_Click);
            // 
            // rungeKutaMethodToolStripMenuItem
            // 
            this.rungeKutaMethodToolStripMenuItem.Name = "rungeKutaMethodToolStripMenuItem";
            this.rungeKutaMethodToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.rungeKutaMethodToolStripMenuItem.Text = "Runge Kuta 2 Method ";
            // 
            // rungeKuta4MethodToolStripMenuItem
            // 
            this.rungeKuta4MethodToolStripMenuItem.Name = "rungeKuta4MethodToolStripMenuItem";
            this.rungeKuta4MethodToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.rungeKuta4MethodToolStripMenuItem.Text = "Runge Kuta 4 Method ";
            this.rungeKuta4MethodToolStripMenuItem.Click += new System.EventHandler(this.rungeKuta4MethodToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(783, 442);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 490);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.ToolStripMenuItem verlutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulerChromerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rungeKutaMethodToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem rungeKuta4MethodToolStripMenuItem;
    }
}

