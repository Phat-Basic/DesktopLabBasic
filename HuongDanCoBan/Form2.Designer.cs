namespace HuongDanCoBan
{
    partial class Form2
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
            this.rNam = new System.Windows.Forms.RadioButton();
            this.rNu = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rNam
            // 
            this.rNam.AutoSize = true;
            this.rNam.Checked = true;
            this.rNam.Location = new System.Drawing.Point(91, 31);
            this.rNam.Name = "rNam";
            this.rNam.Size = new System.Drawing.Size(48, 17);
            this.rNam.TabIndex = 0;
            this.rNam.TabStop = true;
            this.rNam.Text = "Male";
            this.rNam.UseVisualStyleBackColor = true;
            this.rNam.CheckedChanged += new System.EventHandler(this.rNam_CheckedChanged);
            // 
            // rNu
            // 
            this.rNu.AutoSize = true;
            this.rNu.Location = new System.Drawing.Point(91, 63);
            this.rNu.Name = "rNu";
            this.rNu.Size = new System.Drawing.Size(59, 17);
            this.rNu.TabIndex = 1;
            this.rNu.Text = "Female";
            this.rNu.UseVisualStyleBackColor = true;
            this.rNu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rNu);
            this.groupBox1.Controls.Add(this.rNam);
            this.groupBox1.Location = new System.Drawing.Point(308, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rNam;
        private System.Windows.Forms.RadioButton rNu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}