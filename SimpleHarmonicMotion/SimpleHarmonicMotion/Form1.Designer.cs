namespace SimpleHarmonicMotion
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
            this.simpleHarmonicMotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idealSimplePendulumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulerMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cromerMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realisticSimplePendulumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dampedOscillationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dampedDrivenOscillationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonLinearDampedDrivenOscillationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleHarmonicMotionToolStripMenuItem
            // 
            this.simpleHarmonicMotionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idealSimplePendulumToolStripMenuItem,
            this.realisticSimplePendulumToolStripMenuItem});
            this.simpleHarmonicMotionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleHarmonicMotionToolStripMenuItem.Name = "simpleHarmonicMotionToolStripMenuItem";
            this.simpleHarmonicMotionToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.simpleHarmonicMotionToolStripMenuItem.Text = "Simple Harmonic Motion";
            this.simpleHarmonicMotionToolStripMenuItem.Click += new System.EventHandler(this.simpleHarmonicMotionToolStripMenuItem_Click);
            // 
            // idealSimplePendulumToolStripMenuItem
            // 
            this.idealSimplePendulumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eulerMethodToolStripMenuItem,
            this.cromerMethodToolStripMenuItem});
            this.idealSimplePendulumToolStripMenuItem.Name = "idealSimplePendulumToolStripMenuItem";
            this.idealSimplePendulumToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.idealSimplePendulumToolStripMenuItem.Text = "Ideal Simple Pendulum";
            this.idealSimplePendulumToolStripMenuItem.Click += new System.EventHandler(this.idealSimplePendulumToolStripMenuItem_Click);
            // 
            // eulerMethodToolStripMenuItem
            // 
            this.eulerMethodToolStripMenuItem.Name = "eulerMethodToolStripMenuItem";
            this.eulerMethodToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.eulerMethodToolStripMenuItem.Text = "Euler Method";
            this.eulerMethodToolStripMenuItem.Click += new System.EventHandler(this.eulerMethodToolStripMenuItem_Click);
            // 
            // cromerMethodToolStripMenuItem
            // 
            this.cromerMethodToolStripMenuItem.Name = "cromerMethodToolStripMenuItem";
            this.cromerMethodToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.cromerMethodToolStripMenuItem.Text = "Cromer Method";
            this.cromerMethodToolStripMenuItem.Click += new System.EventHandler(this.cromerMethodToolStripMenuItem_Click);
            // 
            // realisticSimplePendulumToolStripMenuItem
            // 
            this.realisticSimplePendulumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dampedOscillationsToolStripMenuItem,
            this.dampedDrivenOscillationsToolStripMenuItem,
            this.nonLinearDampedDrivenOscillationsToolStripMenuItem});
            this.realisticSimplePendulumToolStripMenuItem.Name = "realisticSimplePendulumToolStripMenuItem";
            this.realisticSimplePendulumToolStripMenuItem.Size = new System.Drawing.Size(347, 34);
            this.realisticSimplePendulumToolStripMenuItem.Text = "Realistic Simple Pendulum";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleHarmonicMotionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Theta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Omega";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(3, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 26);
            this.textBox2.TabIndex = 5;
            // 
            // dampedOscillationsToolStripMenuItem
            // 
            this.dampedOscillationsToolStripMenuItem.Name = "dampedOscillationsToolStripMenuItem";
            this.dampedOscillationsToolStripMenuItem.Size = new System.Drawing.Size(474, 34);
            this.dampedOscillationsToolStripMenuItem.Text = "Damped Oscillations";
            this.dampedOscillationsToolStripMenuItem.Click += new System.EventHandler(this.dampedOscillationsToolStripMenuItem_Click);
            // 
            // dampedDrivenOscillationsToolStripMenuItem
            // 
            this.dampedDrivenOscillationsToolStripMenuItem.Name = "dampedDrivenOscillationsToolStripMenuItem";
            this.dampedDrivenOscillationsToolStripMenuItem.Size = new System.Drawing.Size(474, 34);
            this.dampedDrivenOscillationsToolStripMenuItem.Text = "Damped Driven Oscillations";
            this.dampedDrivenOscillationsToolStripMenuItem.Click += new System.EventHandler(this.dampedDrivenOscillationsToolStripMenuItem_Click);
            // 
            // nonLinearDampedDrivenOscillationsToolStripMenuItem
            // 
            this.nonLinearDampedDrivenOscillationsToolStripMenuItem.Name = "nonLinearDampedDrivenOscillationsToolStripMenuItem";
            this.nonLinearDampedDrivenOscillationsToolStripMenuItem.Size = new System.Drawing.Size(474, 34);
            this.nonLinearDampedDrivenOscillationsToolStripMenuItem.Text = "Non-Linear Damped Driven Oscillations";
            this.nonLinearDampedDrivenOscillationsToolStripMenuItem.Click += new System.EventHandler(this.nonLinearDampedDrivenOscillationsToolStripMenuItem_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 227);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 26);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(3, 292);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 26);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(3, 349);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 26);
            this.textBox5.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "q";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "FD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "OmegaD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem simpleHarmonicMotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idealSimplePendulumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realisticSimplePendulumToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eulerMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cromerMethodToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem dampedOscillationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dampedDrivenOscillationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonLinearDampedDrivenOscillationsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}

