namespace NMEA_Checksum_Generator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toChecksum = new System.Windows.Forms.TextBox();
            this.checksumD = new System.Windows.Forms.TextBox();
            this.generateChecksum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "String to convert Include $ & *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Checksum";
            // 
            // toChecksum
            // 
            this.toChecksum.Location = new System.Drawing.Point(61, 67);
            this.toChecksum.Name = "toChecksum";
            this.toChecksum.Size = new System.Drawing.Size(217, 22);
            this.toChecksum.TabIndex = 2;
            // 
            // checksumD
            // 
            this.checksumD.Location = new System.Drawing.Point(61, 155);
            this.checksumD.Name = "checksumD";
            this.checksumD.Size = new System.Drawing.Size(100, 22);
            this.checksumD.TabIndex = 3;
            // 
            // generateChecksum
            // 
            this.generateChecksum.Location = new System.Drawing.Point(331, 80);
            this.generateChecksum.Name = "generateChecksum";
            this.generateChecksum.Size = new System.Drawing.Size(86, 23);
            this.generateChecksum.TabIndex = 4;
            this.generateChecksum.Text = "Generate";
            this.generateChecksum.UseVisualStyleBackColor = true;
            this.generateChecksum.Click += new System.EventHandler(this.generateChecksum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 253);
            this.Controls.Add(this.generateChecksum);
            this.Controls.Add(this.checksumD);
            this.Controls.Add(this.toChecksum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "NMEA Checksum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toChecksum;
        private System.Windows.Forms.TextBox checksumD;
        private System.Windows.Forms.Button generateChecksum;
    }
}

