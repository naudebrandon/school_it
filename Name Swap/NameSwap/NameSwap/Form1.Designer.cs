namespace NameSwap
{
    partial class frmNameSwap
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtSurname2 = new System.Windows.Forms.TextBox();
            this.txtSurname1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Surname";
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(30, 56);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(137, 20);
            this.txtName1.TabIndex = 2;
            // 
            // txtSurname2
            // 
            this.txtSurname2.Location = new System.Drawing.Point(276, 114);
            this.txtSurname2.Name = "txtSurname2";
            this.txtSurname2.Size = new System.Drawing.Size(137, 20);
            this.txtSurname2.TabIndex = 3;
            // 
            // txtSurname1
            // 
            this.txtSurname1.Location = new System.Drawing.Point(276, 56);
            this.txtSurname1.Name = "txtSurname1";
            this.txtSurname1.Size = new System.Drawing.Size(137, 20);
            this.txtSurname1.TabIndex = 4;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(30, 114);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(137, 20);
            this.txtName2.TabIndex = 5;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(186, 56);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 6;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            // 
            // frmNameSwap
            // 
            this.ClientSize = new System.Drawing.Size(438, 164);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtSurname1);
            this.Controls.Add(this.txtSurname2);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frmNameSwap";
            this.Text = "Name Swap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtSurname2;
        private System.Windows.Forms.TextBox txtSurname1;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Button btnSwap;
    }
}

