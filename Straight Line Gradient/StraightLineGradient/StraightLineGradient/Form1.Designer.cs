namespace StraightLineGradient
{
    partial class frmGradient
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spnX1 = new System.Windows.Forms.NumericUpDown();
            this.spnX2 = new System.Windows.Forms.NumericUpDown();
            this.spnY2 = new System.Windows.Forms.NumericUpDown();
            this.spnY1 = new System.Windows.Forms.NumericUpDown();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnDetermine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spnX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnY1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X-cordinates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y-cordinates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "X1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "X2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Y1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Y2";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // spnX1
            // 
            this.spnX1.Location = new System.Drawing.Point(193, 47);
            this.spnX1.Name = "spnX1";
            this.spnX1.Size = new System.Drawing.Size(84, 20);
            this.spnX1.TabIndex = 6;
            // 
            // spnX2
            // 
            this.spnX2.Location = new System.Drawing.Point(307, 47);
            this.spnX2.Name = "spnX2";
            this.spnX2.Size = new System.Drawing.Size(84, 20);
            this.spnX2.TabIndex = 7;
            // 
            // spnY2
            // 
            this.spnY2.Location = new System.Drawing.Point(307, 125);
            this.spnY2.Name = "spnY2";
            this.spnY2.Size = new System.Drawing.Size(84, 20);
            this.spnY2.TabIndex = 9;
            // 
            // spnY1
            // 
            this.spnY1.Location = new System.Drawing.Point(193, 125);
            this.spnY1.Name = "spnY1";
            this.spnY1.Size = new System.Drawing.Size(84, 20);
            this.spnY1.TabIndex = 8;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(269, 227);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 10;
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(227, 172);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(117, 33);
            this.btnDetermine.TabIndex = 11;
            this.btnDetermine.Text = "Determine Gradient";
            this.btnDetermine.UseVisualStyleBackColor = true;
            // 
            // frmGradient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 265);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.spnY2);
            this.Controls.Add(this.spnY1);
            this.Controls.Add(this.spnX2);
            this.Controls.Add(this.spnX1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGradient";
            this.Text = "Determine Gradient";
            ((System.ComponentModel.ISupportInitialize)(this.spnX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnY1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown spnX1;
        private System.Windows.Forms.NumericUpDown spnX2;
        private System.Windows.Forms.NumericUpDown spnY2;
        private System.Windows.Forms.NumericUpDown spnY1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnDetermine;
    }
}

