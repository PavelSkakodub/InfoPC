
namespace SPO_Wind_Form_Lab1
{
    partial class FormSystemMonitor
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblCPUValue = new MetroFramework.Controls.MetroLabel();
            this.lblRAMValue = new MetroFramework.Controls.MetroLabel();
            this.pbRAM = new MetroFramework.Controls.MetroProgressBar();
            this.pbCPU = new MetroFramework.Controls.MetroProgressBar();
            this.chartCPURAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pcCPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcRAM = new System.Diagnostics.PerformanceCounter();
            this.lblUseV = new MetroFramework.Controls.MetroLabel();
            this.lblAvalibleV = new MetroFramework.Controls.MetroLabel();
            this.lblEstablishedV = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPURAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCPUValue
            // 
            this.lblCPUValue.AutoSize = true;
            this.lblCPUValue.Location = new System.Drawing.Point(23, 99);
            this.lblCPUValue.Name = "lblCPUValue";
            this.lblCPUValue.Size = new System.Drawing.Size(28, 19);
            this.lblCPUValue.TabIndex = 1;
            this.lblCPUValue.Text = "ЦП";
            // 
            // lblRAMValue
            // 
            this.lblRAMValue.AutoSize = true;
            this.lblRAMValue.Location = new System.Drawing.Point(23, 168);
            this.lblRAMValue.Name = "lblRAMValue";
            this.lblRAMValue.Size = new System.Drawing.Size(36, 19);
            this.lblRAMValue.TabIndex = 2;
            this.lblRAMValue.Text = "ОЗУ";
            // 
            // pbRAM
            // 
            this.pbRAM.Location = new System.Drawing.Point(78, 154);
            this.pbRAM.Name = "pbRAM";
            this.pbRAM.Size = new System.Drawing.Size(487, 50);
            this.pbRAM.TabIndex = 3;
            // 
            // pbCPU
            // 
            this.pbCPU.Location = new System.Drawing.Point(78, 87);
            this.pbCPU.Name = "pbCPU";
            this.pbCPU.Size = new System.Drawing.Size(487, 50);
            this.pbCPU.TabIndex = 4;
            // 
            // chartCPURAM
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCPURAM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCPURAM.Legends.Add(legend1);
            this.chartCPURAM.Location = new System.Drawing.Point(23, 286);
            this.chartCPURAM.Name = "chartCPURAM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series1.Legend = "Legend1";
            series1.Name = "ЦП";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series2.Legend = "Legend1";
            series2.Name = "ОЗУ";
            this.chartCPURAM.Series.Add(series1);
            this.chartCPURAM.Series.Add(series2);
            this.chartCPURAM.Size = new System.Drawing.Size(671, 204);
            this.chartCPURAM.TabIndex = 5;
            this.chartCPURAM.Text = "chart1";
            // 
            // pcCPU
            // 
            this.pcCPU.CategoryName = "Processor";
            this.pcCPU.CounterName = "% Processor Time";
            this.pcCPU.InstanceName = "_total";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pcRAM
            // 
            this.pcRAM.CategoryName = "Memory";
            this.pcRAM.CounterName = "% Committed Bytes in Use";
            // 
            // lblUseV
            // 
            this.lblUseV.AutoSize = true;
            this.lblUseV.Location = new System.Drawing.Point(178, 226);
            this.lblUseV.Name = "lblUseV";
            this.lblUseV.Size = new System.Drawing.Size(16, 19);
            this.lblUseV.TabIndex = 6;
            this.lblUseV.Text = "0";
            // 
            // lblAvalibleV
            // 
            this.lblAvalibleV.AutoSize = true;
            this.lblAvalibleV.Location = new System.Drawing.Point(178, 245);
            this.lblAvalibleV.Name = "lblAvalibleV";
            this.lblAvalibleV.Size = new System.Drawing.Size(16, 19);
            this.lblAvalibleV.TabIndex = 7;
            this.lblAvalibleV.Text = "0";
            // 
            // lblEstablishedV
            // 
            this.lblEstablishedV.AutoSize = true;
            this.lblEstablishedV.Location = new System.Drawing.Point(178, 264);
            this.lblEstablishedV.Name = "lblEstablishedV";
            this.lblEstablishedV.Size = new System.Drawing.Size(16, 19);
            this.lblEstablishedV.TabIndex = 8;
            this.lblEstablishedV.Text = "0";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(78, 264);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Установлено:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(78, 245);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Доступно:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(78, 226);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Используется:";
            // 
            // FormSystemMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 533);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblEstablishedV);
            this.Controls.Add(this.lblAvalibleV);
            this.Controls.Add(this.lblUseV);
            this.Controls.Add(this.chartCPURAM);
            this.Controls.Add(this.pbCPU);
            this.Controls.Add(this.pbRAM);
            this.Controls.Add(this.lblRAMValue);
            this.Controls.Add(this.lblCPUValue);
            this.Name = "FormSystemMonitor";
            this.Text = "Системный монитор";
            this.Load += new System.EventHandler(this.FormSystemMonitor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chartCPURAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblCPUValue;
        private MetroFramework.Controls.MetroLabel lblRAMValue;
        private MetroFramework.Controls.MetroProgressBar pbRAM;
        private MetroFramework.Controls.MetroProgressBar pbCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPURAM;
        private System.Diagnostics.PerformanceCounter pcCPU;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter pcRAM;
        private MetroFramework.Controls.MetroLabel lblUseV;
        private MetroFramework.Controls.MetroLabel lblAvalibleV;
        private MetroFramework.Controls.MetroLabel lblEstablishedV;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}