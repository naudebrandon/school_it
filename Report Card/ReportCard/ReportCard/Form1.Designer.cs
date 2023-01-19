namespace ReportCard
{
    partial class frmReportCard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.edtMark2 = new System.Windows.Forms.TextBox();
            this.edtMark1 = new System.Windows.Forms.TextBox();
            this.edtSubject = new System.Windows.Forms.TextBox();
            this.edtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblMark1 = new System.Windows.Forms.Label();
            this.lblMark2 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.grpOutput.SuspendLayout();
            this.grbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblAverage);
            this.grpOutput.Controls.Add(this.lblMark2);
            this.grpOutput.Controls.Add(this.lblMark1);
            this.grpOutput.Controls.Add(this.lblSubject);
            this.grpOutput.Controls.Add(this.label7);
            this.grpOutput.Controls.Add(this.label2);
            this.grpOutput.Controls.Add(this.label8);
            this.grpOutput.Controls.Add(this.label9);
            this.grpOutput.Controls.Add(this.label10);
            this.grpOutput.Location = new System.Drawing.Point(326, 8);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(317, 311);
            this.grpOutput.TabIndex = 3;
            this.grpOutput.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Average:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Report Output";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mark 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mark 1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Subject:";
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.btnGenerate);
            this.grbInput.Controls.Add(this.edtMark2);
            this.grbInput.Controls.Add(this.edtMark1);
            this.grbInput.Controls.Add(this.edtSubject);
            this.grbInput.Controls.Add(this.edtName);
            this.grbInput.Controls.Add(this.label6);
            this.grbInput.Controls.Add(this.label5);
            this.grbInput.Controls.Add(this.label4);
            this.grbInput.Controls.Add(this.label3);
            this.grbInput.Controls.Add(this.label1);
            this.grbInput.Location = new System.Drawing.Point(12, 8);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(300, 311);
            this.grbInput.TabIndex = 2;
            this.grbInput.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(121, 259);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(138, 29);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // edtMark2
            // 
            this.edtMark2.Location = new System.Drawing.Point(84, 215);
            this.edtMark2.Name = "edtMark2";
            this.edtMark2.Size = new System.Drawing.Size(66, 23);
            this.edtMark2.TabIndex = 8;
            // 
            // edtMark1
            // 
            this.edtMark1.Location = new System.Drawing.Point(84, 183);
            this.edtMark1.Name = "edtMark1";
            this.edtMark1.Size = new System.Drawing.Size(66, 23);
            this.edtMark1.TabIndex = 7;
            // 
            // edtSubject
            // 
            this.edtSubject.Location = new System.Drawing.Point(84, 148);
            this.edtSubject.Name = "edtSubject";
            this.edtSubject.Size = new System.Drawing.Size(186, 23);
            this.edtSubject.TabIndex = 6;
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(84, 112);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(186, 23);
            this.edtName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mark 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mark 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Input";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(108, 102);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(0, 15);
            this.lblSubject.TabIndex = 9;
            // 
            // lblMark1
            // 
            this.lblMark1.AutoSize = true;
            this.lblMark1.Location = new System.Drawing.Point(108, 204);
            this.lblMark1.Name = "lblMark1";
            this.lblMark1.Size = new System.Drawing.Size(0, 15);
            this.lblMark1.TabIndex = 10;
            // 
            // lblMark2
            // 
            this.lblMark2.AutoSize = true;
            this.lblMark2.Location = new System.Drawing.Point(108, 238);
            this.lblMark2.Name = "lblMark2";
            this.lblMark2.Size = new System.Drawing.Size(0, 15);
            this.lblMark2.TabIndex = 11;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAverage.Location = new System.Drawing.Point(108, 272);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(0, 15);
            this.lblAverage.TabIndex = 12;
            // 
            // frmReportCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 331);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grbInput);
            this.MaximizeBox = false;
            this.Name = "frmReportCard";
            this.Text = "Report Card";
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpOutput;
        private Label label7;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox grbInput;
        private Button btnGenerate;
        private TextBox edtMark2;
        private TextBox edtMark1;
        private TextBox edtSubject;
        private TextBox edtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lblAverage;
        private Label lblMark2;
        private Label lblMark1;
        private Label lblSubject;
    }
}