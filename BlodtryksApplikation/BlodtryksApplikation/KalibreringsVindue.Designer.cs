namespace BlodtryksApplikation
{
    partial class KalibreringsForm
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
            this.txbKalibreringNr1 = new System.Windows.Forms.TextBox();
            this.txbKalibreringNr2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKalibreringNr1 = new System.Windows.Forms.Button();
            this.btnKalibreringNr2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalibrerings Guide";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(58, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kalibreringstryk nr. 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(58, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kalibreringstryk nr. 2:";
            // 
            // txbKalibreringNr1
            // 
            this.txbKalibreringNr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbKalibreringNr1.Location = new System.Drawing.Point(364, 226);
            this.txbKalibreringNr1.Name = "txbKalibreringNr1";
            this.txbKalibreringNr1.Size = new System.Drawing.Size(138, 35);
            this.txbKalibreringNr1.TabIndex = 3;
            // 
            // txbKalibreringNr2
            // 
            this.txbKalibreringNr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbKalibreringNr2.Location = new System.Drawing.Point(364, 378);
            this.txbKalibreringNr2.Name = "txbKalibreringNr2";
            this.txbKalibreringNr2.Size = new System.Drawing.Size(138, 35);
            this.txbKalibreringNr2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(526, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "mmHg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(526, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "mmHg";
            // 
            // btnKalibreringNr1
            // 
            this.btnKalibreringNr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnKalibreringNr1.Location = new System.Drawing.Point(699, 223);
            this.btnKalibreringNr1.Name = "btnKalibreringNr1";
            this.btnKalibreringNr1.Size = new System.Drawing.Size(287, 41);
            this.btnKalibreringNr1.TabIndex = 7;
            this.btnKalibreringNr1.Text = "Godkend kalibrering";
            this.btnKalibreringNr1.UseVisualStyleBackColor = true;
            this.btnKalibreringNr1.Click += new System.EventHandler(this.btnKalibreringNr1_Click);
            // 
            // btnKalibreringNr2
            // 
            this.btnKalibreringNr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnKalibreringNr2.Location = new System.Drawing.Point(699, 375);
            this.btnKalibreringNr2.Name = "btnKalibreringNr2";
            this.btnKalibreringNr2.Size = new System.Drawing.Size(287, 41);
            this.btnKalibreringNr2.TabIndex = 8;
            this.btnKalibreringNr2.Text = "Godkend kalibrering";
            this.btnKalibreringNr2.UseVisualStyleBackColor = true;
            this.btnKalibreringNr2.Click += new System.EventHandler(this.btnKalibreringNr2_Click);
            // 
            // KalibreringsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1098, 759);
            this.Controls.Add(this.btnKalibreringNr2);
            this.Controls.Add(this.btnKalibreringNr1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbKalibreringNr2);
            this.Controls.Add(this.txbKalibreringNr1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KalibreringsForm";
            this.Text = "KalibreringsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbKalibreringNr1;
        private System.Windows.Forms.TextBox txbKalibreringNr2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKalibreringNr1;
        private System.Windows.Forms.Button btnKalibreringNr2;
    }
}