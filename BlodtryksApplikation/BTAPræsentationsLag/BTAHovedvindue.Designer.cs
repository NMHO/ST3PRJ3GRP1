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
            this.btnKalibrerSystem = new System.Windows.Forms.Button();
            this.btnNulpunktsjusterSystem = new System.Windows.Forms.Button();
            this.BTN_FilterON = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnStartMåling = new System.Windows.Forms.Button();
            this.ChartBT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStopMåling = new System.Windows.Forms.Button();
            this.BTNGemdata = new System.Windows.Forms.Button();
            this.tbSys = new System.Windows.Forms.TextBox();
            this.tbDia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKalibrerSystem
            // 
            this.btnKalibrerSystem.Location = new System.Drawing.Point(8, 33);
            this.btnKalibrerSystem.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnNulpunktsjusterSystem.Margin = new System.Windows.Forms.Padding(2);
            this.btnNulpunktsjusterSystem.Name = "btnNulpunktsjusterSystem";
            this.btnNulpunktsjusterSystem.Size = new System.Drawing.Size(107, 26);
            this.btnNulpunktsjusterSystem.TabIndex = 2;
            this.btnNulpunktsjusterSystem.Text = "Nulpunktsjuster";
            this.btnNulpunktsjusterSystem.UseVisualStyleBackColor = true;
            this.btnNulpunktsjusterSystem.Click += new System.EventHandler(this.btnNulpunktsjusterSystem_Click);
            // 
            // BTN_FilterON
            // 
            this.BTN_FilterON.Location = new System.Drawing.Point(163, 33);
            this.BTN_FilterON.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_FilterON.Name = "BTN_FilterON";
            this.BTN_FilterON.Size = new System.Drawing.Size(148, 26);
            this.BTN_FilterON.TabIndex = 4;
            this.BTN_FilterON.Text = "Diagnose-tilstand";
            this.BTN_FilterON.UseVisualStyleBackColor = true;
            this.BTN_FilterON.Click += new System.EventHandler(this.BTN_FilterON_Click);
            // 
            // btnStartMåling
            // 
            this.btnStartMåling.Location = new System.Drawing.Point(333, 33);
            this.btnStartMåling.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartMåling.Name = "btnStartMåling";
            this.btnStartMåling.Size = new System.Drawing.Size(107, 26);
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
            this.ChartBT.Location = new System.Drawing.Point(17, 125);
            this.ChartBT.Margin = new System.Windows.Forms.Padding(2);
            this.ChartBT.Name = "ChartBT";
            series1.ChartArea = "BTChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "BTSerie";
            this.ChartBT.Series.Add(series1);
            this.ChartBT.Size = new System.Drawing.Size(1239, 582);
            this.ChartBT.TabIndex = 7;
            this.ChartBT.Text = "chart1";
            // 
            // btnStopMåling
            // 
            this.btnStopMåling.Location = new System.Drawing.Point(333, 83);
            this.btnStopMåling.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopMåling.Name = "btnStopMåling";
            this.btnStopMåling.Size = new System.Drawing.Size(107, 26);
            this.btnStopMåling.TabIndex = 8;
            this.btnStopMåling.Text = "Stop måling";
            this.btnStopMåling.UseVisualStyleBackColor = true;
            this.btnStopMåling.Click += new System.EventHandler(this.btnStopMåling_Click);
            // 
            // BTNGemdata
            // 
            this.BTNGemdata.Location = new System.Drawing.Point(163, 83);
            this.BTNGemdata.Margin = new System.Windows.Forms.Padding(2);
            this.BTNGemdata.Name = "BTNGemdata";
            this.BTNGemdata.Size = new System.Drawing.Size(148, 26);
            this.BTNGemdata.TabIndex = 9;
            this.BTNGemdata.Text = "Gem data";
            this.BTNGemdata.UseVisualStyleBackColor = true;
            this.BTNGemdata.Click += new System.EventHandler(this.BTNGemdata_Click);
            // 
            // tbSys
            // 
            this.tbSys.Enabled = false;
            this.tbSys.Location = new System.Drawing.Point(558, 39);
            this.tbSys.Name = "tbSys";
            this.tbSys.Size = new System.Drawing.Size(100, 20);
            this.tbSys.TabIndex = 10;
            // 
            // tbDia
            // 
            this.tbDia.Enabled = false;
            this.tbDia.Location = new System.Drawing.Point(558, 83);
            this.tbDia.Name = "tbDia";
            this.tbDia.Size = new System.Drawing.Size(100, 20);
            this.tbDia.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Systole";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Diastole";
            // 
            // BTAHovedvindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDia);
            this.Controls.Add(this.tbSys);
            this.Controls.Add(this.BTNGemdata);
            this.Controls.Add(this.btnStopMåling);
            this.Controls.Add(this.ChartBT);
            this.Controls.Add(this.btnStartMåling);
            this.Controls.Add(this.BTN_FilterON);
            this.Controls.Add(this.btnNulpunktsjusterSystem);
            this.Controls.Add(this.btnKalibrerSystem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BTAHovedvindue";
            this.Text = "BTA - Hovedvindue";
            this.Shown += new System.EventHandler(this.BTAHovedvindue_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKalibrerSystem;
        private System.Windows.Forms.Button btnNulpunktsjusterSystem;
        private System.Windows.Forms.Button BTN_FilterON;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnStartMåling;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBT;
        private System.Windows.Forms.Button btnStopMåling;
        private System.Windows.Forms.Button BTNGemdata;
        private System.Windows.Forms.TextBox tbSys;
        private System.Windows.Forms.TextBox tbDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

