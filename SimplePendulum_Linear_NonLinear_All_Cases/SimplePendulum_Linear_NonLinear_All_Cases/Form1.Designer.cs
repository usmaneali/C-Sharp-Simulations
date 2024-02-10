namespace SimplePendulum_Linear_NonLinear_All_Cases
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
            this.linearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonLinearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idealToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dampedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dampedDrivenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.idealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dampedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dampedDrivenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simplePendulumToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1235, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simplePendulumToolStripMenuItem
            // 
            this.simplePendulumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linearToolStripMenuItem,
            this.idealToolStripMenuItem,
            this.dampedToolStripMenuItem,
            this.dampedDrivenToolStripMenuItem});
            this.simplePendulumToolStripMenuItem.Name = "simplePendulumToolStripMenuItem";
            this.simplePendulumToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.simplePendulumToolStripMenuItem.Text = "SimplePendulum";
            // 
            // linearToolStripMenuItem
            // 
            this.linearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nonLinearToolStripMenuItem,
            this.idealToolStripMenuItem1,
            this.dampedToolStripMenuItem1,
            this.dampedDrivenToolStripMenuItem1});
            this.linearToolStripMenuItem.Name = "linearToolStripMenuItem";
            this.linearToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.linearToolStripMenuItem.Text = "Linear";
            // 
            // nonLinearToolStripMenuItem
            // 
            this.nonLinearToolStripMenuItem.Name = "nonLinearToolStripMenuItem";
            this.nonLinearToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.nonLinearToolStripMenuItem.Text = "NonLinear";
            // 
            // idealToolStripMenuItem1
            // 
            this.idealToolStripMenuItem1.Name = "idealToolStripMenuItem1";
            this.idealToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.idealToolStripMenuItem1.Text = "Ideal";
            this.idealToolStripMenuItem1.Click += new System.EventHandler(this.idealToolStripMenuItem1_Click);
            // 
            // dampedToolStripMenuItem1
            // 
            this.dampedToolStripMenuItem1.Name = "dampedToolStripMenuItem1";
            this.dampedToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.dampedToolStripMenuItem1.Text = "Damped";
            this.dampedToolStripMenuItem1.Click += new System.EventHandler(this.dampedToolStripMenuItem1_Click);
            // 
            // dampedDrivenToolStripMenuItem1
            // 
            this.dampedDrivenToolStripMenuItem1.Name = "dampedDrivenToolStripMenuItem1";
            this.dampedDrivenToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.dampedDrivenToolStripMenuItem1.Text = "DampedDriven";
            this.dampedDrivenToolStripMenuItem1.Click += new System.EventHandler(this.dampedDrivenToolStripMenuItem1_Click);
            // 
            // idealToolStripMenuItem
            // 
            this.idealToolStripMenuItem.Name = "idealToolStripMenuItem";
            this.idealToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.idealToolStripMenuItem.Text = "Ideal";
            this.idealToolStripMenuItem.Click += new System.EventHandler(this.idealToolStripMenuItem_Click);
            // 
            // dampedToolStripMenuItem
            // 
            this.dampedToolStripMenuItem.Name = "dampedToolStripMenuItem";
            this.dampedToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dampedToolStripMenuItem.Text = "Damped";
            this.dampedToolStripMenuItem.Click += new System.EventHandler(this.dampedToolStripMenuItem_Click);
            // 
            // dampedDrivenToolStripMenuItem
            // 
            this.dampedDrivenToolStripMenuItem.Name = "dampedDrivenToolStripMenuItem";
            this.dampedDrivenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dampedDrivenToolStripMenuItem.Text = "DampedDriven";
            this.dampedDrivenToolStripMenuItem.Click += new System.EventHandler(this.dampedDrivenToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1038, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1038, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1002, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "q";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1002, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fd";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1038, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1002, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "th";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 471);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
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
        private System.Windows.Forms.ToolStripMenuItem linearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonLinearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idealToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dampedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dampedDrivenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem idealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dampedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dampedDrivenToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

