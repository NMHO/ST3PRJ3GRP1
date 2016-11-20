namespace BTAPræsentationsLag
{
    partial class GemVindue
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
            this.LCPR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCPR = new System.Windows.Forms.TextBox();
            this.txbPersonalenr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lsignallængde = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RB10sek = new System.Windows.Forms.RadioButton();
            this.RB1min = new System.Windows.Forms.RadioButton();
            this.RBHelesignalet = new System.Windows.Forms.RadioButton();
            this.btnGem = new System.Windows.Forms.Button();
            this.btnAnuller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gem";
            // 
            // LCPR
            // 
            this.LCPR.AutoSize = true;
            this.LCPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCPR.Location = new System.Drawing.Point(23, 56);
            this.LCPR.Name = "LCPR";
            this.LCPR.Size = new System.Drawing.Size(105, 20);
            this.LCPR.TabIndex = 1;
            this.LCPR.Text = "CPR-nummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personalenummer";
            // 
            // txbCPR
            // 
            this.txbCPR.Location = new System.Drawing.Point(27, 80);
            this.txbCPR.Name = "txbCPR";
            this.txbCPR.Size = new System.Drawing.Size(100, 20);
            this.txbCPR.TabIndex = 3;
            // 
            // txbPersonalenr
            // 
            this.txbPersonalenr.Location = new System.Drawing.Point(249, 79);
            this.txbPersonalenr.Name = "txbPersonalenr";
            this.txbPersonalenr.Size = new System.Drawing.Size(100, 20);
            this.txbPersonalenr.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Signalets længde:";
            // 
            // Lsignallængde
            // 
            this.Lsignallængde.AutoSize = true;
            this.Lsignallængde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lsignallængde.Location = new System.Drawing.Point(173, 141);
            this.Lsignallængde.Name = "Lsignallængde";
            this.Lsignallængde.Size = new System.Drawing.Size(0, 20);
            this.Lsignallængde.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hvor meget skal gemmes?";
            // 
            // RB10sek
            // 
            this.RB10sek.AutoSize = true;
            this.RB10sek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB10sek.Location = new System.Drawing.Point(27, 221);
            this.RB10sek.Name = "RB10sek";
            this.RB10sek.Size = new System.Drawing.Size(99, 20);
            this.RB10sek.TabIndex = 8;
            this.RB10sek.TabStop = true;
            this.RB10sek.Text = "10 sekunder";
            this.RB10sek.UseVisualStyleBackColor = true;
            // 
            // RB1min
            // 
            this.RB1min.AutoSize = true;
            this.RB1min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB1min.Location = new System.Drawing.Point(158, 221);
            this.RB1min.Name = "RB1min";
            this.RB1min.Size = new System.Drawing.Size(67, 20);
            this.RB1min.TabIndex = 9;
            this.RB1min.TabStop = true;
            this.RB1min.Text = "1 minut";
            this.RB1min.UseVisualStyleBackColor = true;
            // 
            // RBHelesignalet
            // 
            this.RBHelesignalet.AutoSize = true;
            this.RBHelesignalet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBHelesignalet.Location = new System.Drawing.Point(249, 221);
            this.RBHelesignalet.Name = "RBHelesignalet";
            this.RBHelesignalet.Size = new System.Drawing.Size(105, 20);
            this.RBHelesignalet.TabIndex = 10;
            this.RBHelesignalet.TabStop = true;
            this.RBHelesignalet.Text = "Hele signalet";
            this.RBHelesignalet.UseVisualStyleBackColor = true;
            // 
            // btnGem
            // 
            this.btnGem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGem.Location = new System.Drawing.Point(158, 279);
            this.btnGem.Name = "btnGem";
            this.btnGem.Size = new System.Drawing.Size(101, 43);
            this.btnGem.TabIndex = 11;
            this.btnGem.Text = "Gem";
            this.btnGem.UseMnemonic = false;
            this.btnGem.UseVisualStyleBackColor = true;
            // 
            // btnAnuller
            // 
            this.btnAnuller.Location = new System.Drawing.Point(345, 314);
            this.btnAnuller.Name = "btnAnuller";
            this.btnAnuller.Size = new System.Drawing.Size(75, 23);
            this.btnAnuller.TabIndex = 12;
            this.btnAnuller.Text = "Anuller";
            this.btnAnuller.UseVisualStyleBackColor = true;
            // 
            // GemVindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(432, 349);
            this.Controls.Add(this.btnAnuller);
            this.Controls.Add(this.btnGem);
            this.Controls.Add(this.RBHelesignalet);
            this.Controls.Add(this.RB1min);
            this.Controls.Add(this.RB10sek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lsignallængde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPersonalenr);
            this.Controls.Add(this.txbCPR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LCPR);
            this.Controls.Add(this.label1);
            this.Name = "GemVindue";
            this.Text = "GemVindue";
            this.Load += new System.EventHandler(this.GemVindue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LCPR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCPR;
        private System.Windows.Forms.TextBox txbPersonalenr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lsignallængde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RB10sek;
        private System.Windows.Forms.RadioButton RB1min;
        private System.Windows.Forms.RadioButton RBHelesignalet;
        private System.Windows.Forms.Button btnGem;
        private System.Windows.Forms.Button btnAnuller;
    }
}