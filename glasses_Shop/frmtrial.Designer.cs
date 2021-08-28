namespace glasses_Shop
{
    partial class frmtrial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartProg = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uses Left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "10";
            // 
            // btnStartProg
            // 
            this.btnStartProg.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnStartProg.Location = new System.Drawing.Point(30, 190);
            this.btnStartProg.Name = "btnStartProg";
            this.btnStartProg.Size = new System.Drawing.Size(131, 40);
            this.btnStartProg.TabIndex = 3;
            this.btnStartProg.Text = "Start Program";
            this.btnStartProg.UseVisualStyleBackColor = true;
            this.btnStartProg.Click += new System.EventHandler(this.btnStartProg_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(326, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmtrial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 320);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStartProg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmtrial";
            this.Text = "frmtrial";
            this.Load += new System.EventHandler(this.frmtrial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartProg;
        private System.Windows.Forms.Button btnClose;
    }
}