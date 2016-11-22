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
            this.BTN_FilterON = new System.Windows.Forms.Button();
            this.BTN_filterOFF = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnStartMåling = new System.Windows.Forms.Button();
            this.ChartBT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStopMåling = new System.Windows.Forms.Button();
            this.BTNGemdata = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBT)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1694, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolStripKalibrerSystem,
            this.btnToolStripNulpunktsjusterSystem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // btnToolStripKalibrerSystem
            // 
            this.btnToolStripKalibrerSystem.Name = "btnToolStripKalibrerSystem";
            this.btnToolStripKalibrerSystem.Size = new System.Drawing.Size(186, 26);
            this.btnToolStripKalibrerSystem.Text = "Kalibrér system";
            this.btnToolStripKalibrerSystem.Click += new System.EventHandler(this.btnToolStripKalibrerSystem_Click);
            // 
            // btnToolStripNulpunktsjusterSystem
            // 
            this.btnToolStripNulpunktsjusterSystem.Name = "btnToolStripNulpunktsjusterSystem";
            this.btnToolStripNulpunktsjusterSystem.Size = new System.Drawing.Size(186, 26);
            this.btnToolStripNulpunktsjusterSystem.Text = "Nulpunktsjuster";
            this.btnToolStripNulpunktsjusterSystem.Click += new System.EventHandler(this.btnToolStripNulpunktsjusterSystem_Click);
            // 
            // btnKalibrerSystem
            // 
            this.btnKalibrerSystem.Location = new System.Drawing.Point(11, 41);
            this.btnKalibrerSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKalibrerSystem.Name = "btnKalibrerSystem";
            this.btnKalibrerSystem.Size = new System.Drawing.Size(143, 32);
            this.btnKalibrerSystem.TabIndex = 1;
            this.btnKalibrerSystem.Text = "Kalibrér system";
            this.btnKalibrerSystem.UseVisualStyleBackColor = true;
            this.btnKalibrerSystem.Click += new System.EventHandler(this.btnKalibrerSystem_Click);
            // 
            // btnNulpunktsjusterSystem
            // 
            this.btnNulpunktsjusterSystem.Location = new System.Drawing.Point(11, 102);
            this.btnNulpunktsjusterSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNulpunktsjusterSystem.Name = "btnNulpunktsjusterSystem";
            this.btnNulpunktsjusterSystem.Size = new System.Drawing.Size(143, 32);
            this.btnNulpunktsjusterSystem.TabIndex = 2;
            this.btnNulpunktsjusterSystem.Text = "Nulpunktsjuster";
            this.btnNulpunktsjusterSystem.UseVisualStyleBackColor = true;
            this.btnNulpunktsjusterSystem.Click += new System.EventHandler(this.btnNulpunktsjusterSystem_Click);
            // 
            // BTN_FilterON
            // 
            this.BTN_FilterON.Location = new System.Drawing.Point(217, 41);
            this.BTN_FilterON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_FilterON.Name = "BTN_FilterON";
            this.BTN_FilterON.Size = new System.Drawing.Size(143, 32);
            this.BTN_FilterON.TabIndex = 4;
            this.BTN_FilterON.Text = "Filtrér";
            this.BTN_FilterON.UseVisualStyleBackColor = true;
            this.BTN_FilterON.Click += new System.EventHandler(this.BTN_FilterON_Click);
            // 
            // BTN_filterOFF
            // 
            this.BTN_filterOFF.Location = new System.Drawing.Point(217, 41);
            this.BTN_filterOFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_filterOFF.Name = "BTN_filterOFF";
            this.BTN_filterOFF.Size = new System.Drawing.Size(143, 32);
            this.BTN_filterOFF.TabIndex = 5;
            this.BTN_filterOFF.Text = "Fjern filter";
            this.BTN_filterOFF.UseVisualStyleBackColor = true;
            this.BTN_filterOFF.Click += new System.EventHandler(this.BTN_filterOFF_Click);
            // 
            // btnStartMåling
            // 
            this.btnStartMåling.Location = new System.Drawing.Point(444, 41);
            this.btnStartMåling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartMåling.Name = "btnStartMåling";
            this.btnStartMåling.Size = new System.Drawing.Size(143, 32);
            this.btnStartMåling.TabIndex = 6;
            this.btnStartMåling.Text = "Start måling";
            this.btnStartMåling.UseVisualStyleBackColor = true;
            this.btnStartMåling.Click += new System.EventHandler(this.btnStartMåling_Click);
            // 
            // ChartBT
            // 
            chartArea1.Name = "BTChartArea";
            this.ChartBT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartBT.Legends.Add(legend1);
            this.ChartBT.Location = new System.Drawing.Point(23, 154);
            this.ChartBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChartBT.Name = "ChartBT";
            series1.ChartArea = "BTChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "BTSerie";
            this.ChartBT.Series.Add(series1);
            this.ChartBT.Size = new System.Drawing.Size(1652, 716);
            this.ChartBT.TabIndex = 7;
            this.ChartBT.Text = "chart1";
            // 
            // btnStopMåling
            // 
            this.btnStopMåling.Location = new System.Drawing.Point(444, 102);
            this.btnStopMåling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStopMåling.Name = "btnStopMåling";
            this.btnStopMåling.Size = new System.Drawing.Size(143, 32);
            this.btnStopMåling.TabIndex = 8;
            this.btnStopMåling.Text = "Stop måling";
            this.btnStopMåling.UseVisualStyleBackColor = true;
            this.btnStopMåling.Click += new System.EventHandler(this.btnStopMåling_Click);
            // 
            // BTNGemdata
            // 
            this.BTNGemdata.Location = new System.Drawing.Point(217, 102);
            this.BTNGemdata.Name = "BTNGemdata";
            this.BTNGemdata.Size = new System.Drawing.Size(143, 32);
            this.BTNGemdata.TabIndex = 9;
            this.BTNGemdata.Text = "Gem data";
            this.BTNGemdata.UseVisualStyleBackColor = true;
            this.BTNGemdata.Click += new System.EventHandler(this.BTNGemdata_Click);
            // 
            // BTAHovedvindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1694, 830);
            this.Controls.Add(this.BTNGemdata);
            this.Controls.Add(this.btnStopMåling);
            this.Controls.Add(this.ChartBT);
            this.Controls.Add(this.btnStartMåling);
            this.Controls.Add(this.BTN_filterOFF);
            this.Controls.Add(this.BTN_FilterON);
            this.Controls.Add(this.btnNulpunktsjusterSystem);
            this.Controls.Add(this.btnKalibrerSystem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BTAHovedvindue";
            this.Text = "BTA - Hovedvindue";
            this.Shown += new System.EventHandler(this.BTAHovedvindue_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBT)).EndInit();
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
        private System.Windows.Forms.Button BTN_FilterON;
        private System.Windows.Forms.Button BTN_filterOFF;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnStartMåling;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBT;
        private System.Windows.Forms.Button btnStopMåling;
        private System.Windows.Forms.Button BTNGemdata;
    }
}

