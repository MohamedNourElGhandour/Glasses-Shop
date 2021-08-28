namespace glasses_Shop
{
    partial class frmStart
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolstripCustommer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstriptotalsales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripCustommer,
            this.toolstriptotalsales});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(295, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolstripCustommer
            // 
            this.toolstripCustommer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripCustommer.Name = "toolstripCustommer";
            this.toolstripCustommer.Size = new System.Drawing.Size(61, 20);
            this.toolstripCustommer.Text = "العميل";
            this.toolstripCustommer.Click += new System.EventHandler(this.toolstripCustommer_Click);
            // 
            // toolstriptotalsales
            // 
            this.toolstriptotalsales.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstriptotalsales.Name = "toolstriptotalsales";
            this.toolstriptotalsales.Size = new System.Drawing.Size(120, 20);
            this.toolstriptotalsales.Text = "إجمالى المبيعات";
            this.toolstriptotalsales.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolstriptotalsales.Click += new System.EventHandler(this.toolstriptotalsales_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 266);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "frmStart";
            this.Text = "frmStart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolstripCustommer;
        private System.Windows.Forms.ToolStripMenuItem toolstriptotalsales;
    }
}