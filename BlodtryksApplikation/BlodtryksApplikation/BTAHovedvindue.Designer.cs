﻿namespace BlodtryksApplikation
{
    partial class BTAHovedvindue
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolStripKalibrerSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolStripNulpunktsjusterSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKalibrerSystem = new System.Windows.Forms.Button();
            this.btnNulpunktsjusterSystem = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolStripKalibrerSystem,
            this.btnToolStripNulpunktsjusterSystem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 22);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // btnToolStripKalibrerSystem
            // 
            this.btnToolStripKalibrerSystem.Name = "btnToolStripKalibrerSystem";
            this.btnToolStripKalibrerSystem.Size = new System.Drawing.Size(158, 22);
            this.btnToolStripKalibrerSystem.Text = "Kalibrér system";
            this.btnToolStripKalibrerSystem.Click += new System.EventHandler(this.btnToolStripKalibrerSystem_Click);
            // 
            // btnToolStripNulpunktsjusterSystem
            // 
            this.btnToolStripNulpunktsjusterSystem.Name = "btnToolStripNulpunktsjusterSystem";
            this.btnToolStripNulpunktsjusterSystem.Size = new System.Drawing.Size(158, 22);
            this.btnToolStripNulpunktsjusterSystem.Text = "Nulpunktsjuster";
            this.btnToolStripNulpunktsjusterSystem.Click += new System.EventHandler(this.btnToolStripNulpunktsjusterSystem_Click);
            // 
            // btnKalibrerSystem
            // 
            this.btnKalibrerSystem.Location = new System.Drawing.Point(8, 33);
            this.btnKalibrerSystem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKalibrerSystem.Name = "btnKalibrerSystem";
            this.btnKalibrerSystem.Size = new System.Drawing.Size(107, 26);
            this.btnKalibrerSystem.TabIndex = 1;
            this.btnKalibrerSystem.Text = "Kalibrér system";
            this.btnKalibrerSystem.UseVisualStyleBackColor = true;
            this.btnKalibrerSystem.Click += new System.EventHandler(this.btnKalibrerSystem_Click);
            // 
            // btnNulpunktsjusterSystem
            // 
            this.btnNulpunktsjusterSystem.Location = new System.Drawing.Point(8, 83);
            this.btnNulpunktsjusterSystem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNulpunktsjusterSystem.Name = "btnNulpunktsjusterSystem";
            this.btnNulpunktsjusterSystem.Size = new System.Drawing.Size(107, 26);
            this.btnNulpunktsjusterSystem.TabIndex = 2;
            this.btnNulpunktsjusterSystem.Text = "Nulpunktsjuster";
            this.btnNulpunktsjusterSystem.UseVisualStyleBackColor = true;
            this.btnNulpunktsjusterSystem.Click += new System.EventHandler(this.btnNulpunktsjusterSystem_Click);
            // 
            // BTAHovedvindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 567);
            this.Controls.Add(this.btnNulpunktsjusterSystem);
            this.Controls.Add(this.btnKalibrerSystem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BTAHovedvindue";
            this.Text = "BTA - Hovedvindue";
            this.Shown += new System.EventHandler(this.BTAHovedvindue_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnToolStripKalibrerSystem;
        private System.Windows.Forms.Button btnKalibrerSystem;
        private System.Windows.Forms.ToolStripMenuItem btnToolStripNulpunktsjusterSystem;
        private System.Windows.Forms.Button btnNulpunktsjusterSystem;
    }
}

