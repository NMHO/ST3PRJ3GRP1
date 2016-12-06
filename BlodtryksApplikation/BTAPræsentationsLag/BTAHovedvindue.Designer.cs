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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnKalibrerSystem = new System.Windows.Forms.Button();
            this.btnNulpunktsjusterSystem = new System.Windows.Forms.Button();
            this.BTN_FilterON = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnStartMåling = new System.Windows.Forms.Button();
            this.ChartBT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStopMåling = new System.Windows.Forms.Button();
            this.BTNGemdata = new System.Windows.Forms.Button();
            this.cbAlarmlyd = new System.Windows.Forms.CheckBox();
            this.gbMonitorering = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiastole = new System.Windows.Forms.Label();
            this.txtSystole = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBT)).BeginInit();
            this.gbMonitorering.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKalibrerSystem
            // 
            this.btnKalibrerSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKalibrerSystem.Location = new System.Drawing.Point(59, 137);
            this.btnKalibrerSystem.Name = "btnKalibrerSystem";
            this.btnKalibrerSystem.Size = new System.Drawing.Size(294, 66);
            this.btnKalibrerSystem.TabIndex = 1;
            this.btnKalibrerSystem.Text = "Kalibrér system";
            this.btnKalibrerSystem.UseVisualStyleBackColor = true;
            this.btnKalibrerSystem.Click += new System.EventHandler(this.btnKalibrerSystem_Click);
            // 
            // btnNulpunktsjusterSystem
            // 
            this.btnNulpunktsjusterSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNulpunktsjusterSystem.Location = new System.Drawing.Point(59, 44);
            this.btnNulpunktsjusterSystem.Name = "btnNulpunktsjusterSystem";
            this.btnNulpunktsjusterSystem.Size = new System.Drawing.Size(294, 66);
            this.btnNulpunktsjusterSystem.TabIndex = 2;
            this.btnNulpunktsjusterSystem.Text = "Nulpunktsjuster";
            this.btnNulpunktsjusterSystem.UseVisualStyleBackColor = true;
            this.btnNulpunktsjusterSystem.Click += new System.EventHandler(this.btnNulpunktsjusterSystem_Click);
            // 
            // BTN_FilterON
            // 
            this.BTN_FilterON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FilterON.Location = new System.Drawing.Point(359, 44);
            this.BTN_FilterON.Name = "BTN_FilterON";
            this.BTN_FilterON.Size = new System.Drawing.Size(294, 66);
            this.BTN_FilterON.TabIndex = 4;
            this.BTN_FilterON.Text = "Diagnose-tilstand";
            this.BTN_FilterON.UseVisualStyleBackColor = true;
            this.BTN_FilterON.Click += new System.EventHandler(this.BTN_FilterON_Click);
            // 
            // btnStartMåling
            // 
            this.btnStartMåling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMåling.Location = new System.Drawing.Point(33, 44);
            this.btnStartMåling.Name = "btnStartMåling";
            this.btnStartMåling.Size = new System.Drawing.Size(294, 66);
            this.btnStartMåling.TabIndex = 6;
            this.btnStartMåling.Text = "Start måling";
            this.btnStartMåling.UseVisualStyleBackColor = true;
            this.btnStartMåling.Click += new System.EventHandler(this.btnStartMåling_Click);
            // 
            // ChartBT
            // 
            this.ChartBT.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "BTChartArea";
            this.ChartBT.ChartAreas.Add(chartArea1);
            this.ChartBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartBT.Location = new System.Drawing.Point(0, 373);
            this.ChartBT.MaximumSize = new System.Drawing.Size(3000, 1000);
            this.ChartBT.Name = "ChartBT";
            series1.BorderWidth = 2;
            series1.ChartArea = "BTChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.Name = "BTSerie";
            this.ChartBT.Series.Add(series1);
            this.ChartBT.Size = new System.Drawing.Size(1762, 787);
            this.ChartBT.TabIndex = 7;
            this.ChartBT.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Titel";
            title1.Text = "Blodtryksgraf";
            this.ChartBT.Titles.Add(title1);
            // 
            // btnStopMåling
            // 
            this.btnStopMåling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopMåling.Location = new System.Drawing.Point(33, 137);
            this.btnStopMåling.Name = "btnStopMåling";
            this.btnStopMåling.Size = new System.Drawing.Size(294, 66);
            this.btnStopMåling.TabIndex = 8;
            this.btnStopMåling.Text = "Stop måling";
            this.btnStopMåling.UseVisualStyleBackColor = true;
            this.btnStopMåling.Click += new System.EventHandler(this.btnStopMåling_Click);
            // 
            // BTNGemdata
            // 
            this.BTNGemdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGemdata.Location = new System.Drawing.Point(359, 137);
            this.BTNGemdata.Name = "BTNGemdata";
            this.BTNGemdata.Size = new System.Drawing.Size(294, 66);
            this.BTNGemdata.TabIndex = 9;
            this.BTNGemdata.Text = "Gem data";
            this.BTNGemdata.UseVisualStyleBackColor = true;
            this.BTNGemdata.Click += new System.EventHandler(this.BTNGemdata_Click);
            // 
            // cbAlarmlyd
            // 
            this.cbAlarmlyd.AutoSize = true;
            this.cbAlarmlyd.Checked = true;
            this.cbAlarmlyd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlarmlyd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlarmlyd.Location = new System.Drawing.Point(33, 223);
            this.cbAlarmlyd.Name = "cbAlarmlyd";
            this.cbAlarmlyd.Size = new System.Drawing.Size(261, 29);
            this.cbAlarmlyd.TabIndex = 14;
            this.cbAlarmlyd.Text = "Aktiver/deaktiver alarmlyd";
            this.cbAlarmlyd.UseVisualStyleBackColor = true;
            this.cbAlarmlyd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbAlarmlyd_MouseClick);
            // 
            // gbMonitorering
            // 
            this.gbMonitorering.Controls.Add(this.btnStartMåling);
            this.gbMonitorering.Controls.Add(this.cbAlarmlyd);
            this.gbMonitorering.Controls.Add(this.BTN_FilterON);
            this.gbMonitorering.Controls.Add(this.btnStopMåling);
            this.gbMonitorering.Controls.Add(this.BTNGemdata);
            this.gbMonitorering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMonitorering.Location = new System.Drawing.Point(3, 3);
            this.gbMonitorering.Name = "gbMonitorering";
            this.gbMonitorering.Size = new System.Drawing.Size(735, 298);
            this.gbMonitorering.TabIndex = 16;
            this.gbMonitorering.TabStop = false;
            this.gbMonitorering.Text = "Monitorering";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNulpunktsjusterSystem);
            this.groupBox1.Controls.Add(this.btnKalibrerSystem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1310, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 298);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indstillinger";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDiastole);
            this.groupBox2.Controls.Add(this.txtSystole);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(750, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 298);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Systolisktryk / Diastolisktryk  i mmHg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(257, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 113);
            this.label3.TabIndex = 21;
            this.label3.Text = "/";
            // 
            // txtDiastole
            // 
            this.txtDiastole.AutoSize = true;
            this.txtDiastole.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiastole.ForeColor = System.Drawing.Color.Lime;
            this.txtDiastole.Location = new System.Drawing.Point(321, 71);
            this.txtDiastole.Name = "txtDiastole";
            this.txtDiastole.Size = new System.Drawing.Size(104, 113);
            this.txtDiastole.TabIndex = 20;
            this.txtDiastole.Text = "0";
            // 
            // txtSystole
            // 
            this.txtSystole.AutoSize = true;
            this.txtSystole.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSystole.ForeColor = System.Drawing.Color.Lime;
            this.txtSystole.Location = new System.Drawing.Point(66, 71);
            this.txtSystole.Name = "txtSystole";
            this.txtSystole.Size = new System.Drawing.Size(104, 113);
            this.txtSystole.TabIndex = 19;
            this.txtSystole.Text = "0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.42781F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.82884F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.79132F));
            this.tableLayoutPanel2.Controls.Add(this.gbMonitorering, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1762, 373);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // BTAHovedvindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1762, 1160);
            this.Controls.Add(this.ChartBT);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "BTAHovedvindue";
            this.Text = "BTA - Hovedvindue";
            this.Shown += new System.EventHandler(this.BTAHovedvindue_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBT)).EndInit();
            this.gbMonitorering.ResumeLayout(false);
            this.gbMonitorering.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox cbAlarmlyd;
        private System.Windows.Forms.GroupBox gbMonitorering;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtDiastole;
        private System.Windows.Forms.Label txtSystole;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

