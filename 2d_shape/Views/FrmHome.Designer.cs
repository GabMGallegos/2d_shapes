namespace _2d_shape.Views
{
    partial class FrmHome
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
            this.miShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miShapesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miShapesToolStripMenuItem
            // 
            this.miShapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRectangleToolStripMenuItem,
            this.miTriangleToolStripMenuItem});
            this.miShapesToolStripMenuItem.Name = "miShapesToolStripMenuItem";
            this.miShapesToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.miShapesToolStripMenuItem.Text = "Shapes";
            // 
            // miRectangleToolStripMenuItem
            // 
            this.miRectangleToolStripMenuItem.Name = "miRectangleToolStripMenuItem";
            this.miRectangleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.miRectangleToolStripMenuItem.Text = "Rectangle";
            this.miRectangleToolStripMenuItem.Click += new System.EventHandler(this.miRectangleToolStripMenuItem_Click);
            // 
            // miTriangleToolStripMenuItem
            // 
            this.miTriangleToolStripMenuItem.Name = "miTriangleToolStripMenuItem";
            this.miTriangleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.miTriangleToolStripMenuItem.Text = "Triangle";
            this.miTriangleToolStripMenuItem.Click += new System.EventHandler(this.miTriangleToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Shapes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miTriangleToolStripMenuItem;
    }
}