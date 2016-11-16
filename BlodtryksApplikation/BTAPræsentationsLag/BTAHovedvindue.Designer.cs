namespace BTAPræsentationsLag
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolStripKalibrerSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolStripNulpunktsjusterSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKalibrerSystem = new System.Windows.Forms.Button();
            this.btnNulpunktsjusterSystem = new System.Windows.Forms.Button();
            this.Chart_BTA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BTN_FilterON = new System.Windows.Forms.Button();
            this.BTN_filterOFF = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BTN_Start = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_BTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2552, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolStripKalibrerSystem,
            this.btnToolStripNulpunktsjusterSystem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 45);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // btnToolStripKalibrerSystem
            // 
            this.btnToolStripKalibrerSystem.Name = "btnToolStripKalibrerSystem";
            this.btnToolStripKalibrerSystem.Size = new System.Drawing.Size(342, 46);
            this.btnToolStripKalibrerSystem.Text = "Kalibrér system";
            this.btnToolStripKalibrerSystem.Click += new System.EventHandler(this.btnToolStripKalibrerSystem_Click);
            // 
            // btnToolStripNulpunktsjusterSystem
            // 
            this.btnToolStripNulpunktsjusterSystem.Name = "btnToolStripNulpunktsjusterSystem";
            this.btnToolStripNulpunktsjusterSystem.Size = new System.Drawing.Size(342, 46);
            this.btnToolStripNulpunktsjusterSystem.Text = "Nulpunktsjuster";
            this.btnToolStripNulpunktsjusterSystem.Click += new System.EventHandler(this.btnToolStripNulpunktsjusterSystem_Click);
            // 
            // btnKalibrerSystem
            // 
            this.btnKalibrerSystem.Location = new System.Drawing.Point(22, 79);
            this.btnKalibrerSystem.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnKalibrerSystem.Name = "btnKalibrerSystem";
            this.btnKalibrerSystem.Size = new System.Drawing.Size(286, 62);
            this.btnKalibrerSystem.TabIndex = 1;
            this.btnKalibrerSystem.Text = "Kalibrér system";
            this.btnKalibrerSystem.UseVisualStyleBackColor = true;
            this.btnKalibrerSystem.Click += new System.EventHandler(this.btnKalibrerSystem_Click);
            // 
            // btnNulpunktsjusterSystem
            // 
            this.btnNulpunktsjusterSystem.Location = new System.Drawing.Point(22, 198);
            this.btnNulpunktsjusterSystem.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnNulpunktsjusterSystem.Name = "btnNulpunktsjusterSystem";
            this.btnNulpunktsjusterSystem.Size = new System.Drawing.Size(286, 62);
            this.btnNulpunktsjusterSystem.TabIndex = 2;
            this.btnNulpunktsjusterSystem.Text = "Nulpunktsjuster";
            this.btnNulpunktsjusterSystem.UseVisualStyleBackColor = true;
            this.btnNulpunktsjusterSystem.Click += new System.EventHandler(this.btnNulpunktsjusterSystem_Click);
            // 
            // Chart_BTA
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_BTA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_BTA.Legends.Add(legend1);
            this.Chart_BTA.Location = new System.Drawing.Point(22, 287);
            this.Chart_BTA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Chart_BTA.Name = "Chart_BTA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart_BTA.Series.Add(series1);
            this.Chart_BTA.Size = new System.Drawing.Size(1810, 957);
            this.Chart_BTA.TabIndex = 3;
            this.Chart_BTA.Text = "chart1";
            // 
            // BTN_FilterON
            // 
            this.BTN_FilterON.Location = new System.Drawing.Point(434, 79);
            this.BTN_FilterON.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BTN_FilterON.Name = "BTN_FilterON";
            this.BTN_FilterON.Size = new System.Drawing.Size(286, 62);
            this.BTN_FilterON.TabIndex = 4;
            this.BTN_FilterON.Text = "Filtrér";
            this.BTN_FilterON.UseVisualStyleBackColor = true;
            this.BTN_FilterON.Click += new System.EventHandler(this.BTN_FilterON_Click);
            // 
            // BTN_filterOFF
            // 
            this.BTN_filterOFF.Location = new System.Drawing.Point(434, 79);
            this.BTN_filterOFF.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BTN_filterOFF.Name = "BTN_filterOFF";
            this.BTN_filterOFF.Size = new System.Drawing.Size(286, 62);
            this.BTN_filterOFF.TabIndex = 5;
            this.BTN_filterOFF.Text = "Fjern filter";
            this.BTN_filterOFF.UseVisualStyleBackColor = true;
            this.BTN_filterOFF.Click += new System.EventHandler(this.BTN_filterOFF_Click);
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(969, 79);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(286, 62);
            this.BTN_Start.TabIndex = 6;
            this.BTN_Start.Text = "Start måling";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // BTAHovedvindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2552, 1352);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.BTN_filterOFF);
            this.Controls.Add(this.BTN_FilterON);
            this.Controls.Add(this.Chart_BTA);
            this.Controls.Add(this.btnNulpunktsjusterSystem);
            this.Controls.Add(this.btnKalibrerSystem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "BTAHovedvindue";
            this.Text = "BTA - Hovedvindue";
            this.Shown += new System.EventHandler(this.BTAHovedvindue_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_BTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_BTA;
        private System.Windows.Forms.Button BTN_FilterON;
        private System.Windows.Forms.Button BTN_filterOFF;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button BTN_Start;
    }
}

