namespace glasses_Shop
{
    partial class frmTotalPrice
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
            this.txtDate1 = new System.Windows.Forms.TextBox();
            this.txtDate2 = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbldate2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDate1
            // 
            this.txtDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate1.Location = new System.Drawing.Point(38, 29);
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDate1.Size = new System.Drawing.Size(269, 24);
            this.txtDate1.TabIndex = 33;
            this.txtDate1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Justdate);
            // 
            // txtDate2
            // 
            this.txtDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate2.Location = new System.Drawing.Point(37, 74);
            this.txtDate2.Name = "txtDate2";
            this.txtDate2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDate2.Size = new System.Drawing.Size(269, 24);
            this.txtDate2.TabIndex = 34;
            this.txtDate2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Justdate);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(310, 35);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(89, 18);
            this.lbldate.TabIndex = 35;
            this.lbldate.Text = "التاريخ الأول ";
            // 
            // lbldate2
            // 
            this.lbldate2.AutoSize = true;
            this.lbldate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate2.Location = new System.Drawing.Point(316, 80);
            this.lbldate2.Name = "lbldate2";
            this.lbldate2.Size = new System.Drawing.Size(88, 18);
            this.lbldate2.TabIndex = 36;
            this.lbldate2.Text = "التاريخ الثاني";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldate2);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.txtDate2);
            this.groupBox1.Controls.Add(this.txtDate1);
            this.groupBox1.Location = new System.Drawing.Point(35, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(410, 125);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إجمالي المبيعات بين تاريخين";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(277, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 29);
            this.button1.TabIndex = 38;
            this.button1.Text = "الاجمالي";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(179, 197);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(19, 20);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "0";
            // 
            // frmTotalPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 299);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmTotalPrice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtDate1;
        internal System.Windows.Forms.TextBox txtDate2;
        internal System.Windows.Forms.Label lbldate;
        internal System.Windows.Forms.Label lbldate2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotal;
    }
}