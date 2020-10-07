namespace StringsSample
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
            this.txtOne = new System.Windows.Forms.TextBox();
            this.lblReverse = new System.Windows.Forms.Label();
            this.lblHalfLeng = new System.Windows.Forms.Label();
            this.lblLeng = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtOne
            // 
            this.txtOne.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOne.Location = new System.Drawing.Point(31, 44);
            this.txtOne.Multiline = true;
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(273, 23);
            this.txtOne.TabIndex = 0;
            this.txtOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReverse
            // 
            this.lblReverse.Location = new System.Drawing.Point(81, 178);
            this.lblReverse.Name = "lblReverse";
            this.lblReverse.Size = new System.Drawing.Size(223, 23);
            this.lblReverse.TabIndex = 1;
            // 
            // lblHalfLeng
            // 
            this.lblHalfLeng.Location = new System.Drawing.Point(87, 229);
            this.lblHalfLeng.Name = "lblHalfLeng";
            this.lblHalfLeng.Size = new System.Drawing.Size(217, 23);
            this.lblHalfLeng.TabIndex = 2;
            // 
            // lblLeng
            // 
            this.lblLeng.Location = new System.Drawing.Point(81, 276);
            this.lblLeng.Name = "lblLeng";
            this.lblLeng.Size = new System.Drawing.Size(223, 19);
            this.lblLeng.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(31, 89);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(273, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reverse :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "HalfString :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Length :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter the String";
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(341, 44);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(222, 225);
            this.lstBox.TabIndex = 9;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(594, 304);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblLeng);
            this.Controls.Add(this.lblHalfLeng);
            this.Controls.Add(this.lblReverse);
            this.Controls.Add(this.txtOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.Label lblReverse;
        private System.Windows.Forms.Label lblHalfLeng;
        private System.Windows.Forms.Label lblLeng;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstBox;
    }
}

