
namespace Computation_Practicum_app
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox_ES = new System.Windows.Forms.CheckBox();
            this.checkBox_RKM = new System.Windows.Forms.CheckBox();
            this.checkBox_IEM = new System.Windows.Forms.CheckBox();
            this.checkBox_EM = new System.Windows.Forms.CheckBox();
            this.button_Plot = new System.Windows.Forms.Button();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label_N = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            this.textBox_x0 = new System.Windows.Forms.TextBox();
            this.label_x0 = new System.Windows.Forms.Label();
            this.textBox_y0 = new System.Windows.Forms.TextBox();
            this.label_y0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_ES);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_RKM);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_IEM);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_EM);
            this.splitContainer1.Panel2.Controls.Add(this.button_Plot);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_N);
            this.splitContainer1.Panel2.Controls.Add(this.label_N);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_X);
            this.splitContainer1.Panel2.Controls.Add(this.label_X);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_x0);
            this.splitContainer1.Panel2.Controls.Add(this.label_x0);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_y0);
            this.splitContainer1.Panel2.Controls.Add(this.label_y0);
            this.splitContainer1.Size = new System.Drawing.Size(600, 366);
            this.splitContainer1.SplitterDistance = 384;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabPage";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(384, 366);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);

            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(376, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "sol. graph";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(2, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.LegendText = "Euler method";
            series8.Name = "Series_EM";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.LegendText = "Imp. Euler\'s method";
            series9.Name = "Series_IEM";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.LegendText = "Runge Kutta method";
            series10.Name = "Series_RK";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.LegendText = "Exact solution";
            series11.Name = "Series_ES";
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(372, 336);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(376, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "error graph";
            this.tabPage2.UseVisualStyleBackColor = true;
            
            // 
            // chart2
            // 
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(2, 2);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.LegendText = "EM error";
            series12.Name = "Series_EM_Error";
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.LegendText = "IEM error";
            series13.Name = "Series_IEM_Error";
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.LegendText = "RKM error";
            series14.Name = "Series_RKM_error";
            this.chart2.Series.Add(series12);
            this.chart2.Series.Add(series13);
            this.chart2.Series.Add(series14);
            this.chart2.Size = new System.Drawing.Size(372, 336);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // checkBox_ES
            // 
            this.checkBox_ES.AutoSize = true;
            this.checkBox_ES.Checked = true;
            this.checkBox_ES.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ES.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_ES.Location = new System.Drawing.Point(0, 256);
            this.checkBox_ES.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_ES.Name = "checkBox_ES";
            this.checkBox_ES.Size = new System.Drawing.Size(213, 17);
            this.checkBox_ES.TabIndex = 19;
            this.checkBox_ES.Text = "ES";
            this.checkBox_ES.UseVisualStyleBackColor = true;
            this.checkBox_ES.CheckedChanged += new System.EventHandler(this.checkBox_ES_CheckedChanged);
            // 
            // checkBox_RKM
            // 
            this.checkBox_RKM.AutoSize = true;
            this.checkBox_RKM.Checked = true;
            this.checkBox_RKM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RKM.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_RKM.Location = new System.Drawing.Point(0, 239);
            this.checkBox_RKM.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_RKM.Name = "checkBox_RKM";
            this.checkBox_RKM.Size = new System.Drawing.Size(213, 17);
            this.checkBox_RKM.TabIndex = 18;
            this.checkBox_RKM.Text = "RKM";
            this.checkBox_RKM.UseVisualStyleBackColor = true;
            this.checkBox_RKM.CheckedChanged += new System.EventHandler(this.checkBox_RKM_CheckedChanged);
            // 
            // checkBox_IEM
            // 
            this.checkBox_IEM.AutoSize = true;
            this.checkBox_IEM.Checked = true;
            this.checkBox_IEM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IEM.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_IEM.Location = new System.Drawing.Point(0, 222);
            this.checkBox_IEM.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_IEM.Name = "checkBox_IEM";
            this.checkBox_IEM.Size = new System.Drawing.Size(213, 17);
            this.checkBox_IEM.TabIndex = 17;
            this.checkBox_IEM.Text = "IEM";
            this.checkBox_IEM.UseVisualStyleBackColor = true;
            this.checkBox_IEM.CheckedChanged += new System.EventHandler(this.checkBox_IEM_CheckedChanged);
            // 
            // checkBox_EM
            // 
            this.checkBox_EM.AutoSize = true;
            this.checkBox_EM.Checked = true;
            this.checkBox_EM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_EM.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_EM.Location = new System.Drawing.Point(0, 205);
            this.checkBox_EM.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_EM.Name = "checkBox_EM";
            this.checkBox_EM.Size = new System.Drawing.Size(213, 17);
            this.checkBox_EM.TabIndex = 16;
            this.checkBox_EM.Text = "EM";
            this.checkBox_EM.UseVisualStyleBackColor = true;
            this.checkBox_EM.CheckedChanged += new System.EventHandler(this.checkBox_EM_CheckedChanged);
            // 
            // button_Plot
            // 
            this.button_Plot.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Plot.Location = new System.Drawing.Point(0, 172);
            this.button_Plot.Margin = new System.Windows.Forms.Padding(4);
            this.button_Plot.Name = "button_Plot";
            this.button_Plot.Padding = new System.Windows.Forms.Padding(2);
            this.button_Plot.Size = new System.Drawing.Size(213, 33);
            this.button_Plot.TabIndex = 15;
            this.button_Plot.Text = "Plot";
            this.button_Plot.UseVisualStyleBackColor = true;
            this.button_Plot.Click += new System.EventHandler(this.button_Plot_Click);
            // 
            // textBox_N
            // 
            this.textBox_N.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_N.Location = new System.Drawing.Point(0, 152);
            this.textBox_N.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(213, 20);
            this.textBox_N.TabIndex = 14;
            this.textBox_N.Text = "30";
            this.textBox_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_N
            // 
            this.label_N.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_N.Location = new System.Drawing.Point(0, 129);
            this.label_N.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_N.Name = "label_N";
            this.label_N.Padding = new System.Windows.Forms.Padding(4);
            this.label_N.Size = new System.Drawing.Size(213, 23);
            this.label_N.TabIndex = 13;
            this.label_N.Text = "N";
            // 
            // textBox_X
            // 
            this.textBox_X.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_X.Location = new System.Drawing.Point(0, 109);
            this.textBox_X.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(213, 20);
            this.textBox_X.TabIndex = 12;
            this.textBox_X.Text = "3";
            this.textBox_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_X
            // 
            this.label_X.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_X.Location = new System.Drawing.Point(0, 86);
            this.label_X.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_X.Name = "label_X";
            this.label_X.Padding = new System.Windows.Forms.Padding(4);
            this.label_X.Size = new System.Drawing.Size(213, 23);
            this.label_X.TabIndex = 11;
            this.label_X.Text = "X";
            // 
            // textBox_x0
            // 
            this.textBox_x0.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_x0.Location = new System.Drawing.Point(0, 66);
            this.textBox_x0.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_x0.Name = "textBox_x0";
            this.textBox_x0.Size = new System.Drawing.Size(213, 20);
            this.textBox_x0.TabIndex = 10;
            this.textBox_x0.Text = "0";
            this.textBox_x0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_x0
            // 
            this.label_x0.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_x0.Location = new System.Drawing.Point(0, 43);
            this.label_x0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_x0.Name = "label_x0";
            this.label_x0.Padding = new System.Windows.Forms.Padding(4);
            this.label_x0.Size = new System.Drawing.Size(213, 23);
            this.label_x0.TabIndex = 9;
            this.label_x0.Text = "x₀";
            // 
            // textBox_y0
            // 
            this.textBox_y0.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_y0.Location = new System.Drawing.Point(0, 23);
            this.textBox_y0.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_y0.Name = "textBox_y0";
            this.textBox_y0.Size = new System.Drawing.Size(213, 20);
            this.textBox_y0.TabIndex = 1;
            this.textBox_y0.Text = "0,70710";
            this.textBox_y0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_y0
            // 
            this.label_y0.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_y0.Location = new System.Drawing.Point(0, 0);
            this.label_y0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_y0.Name = "label_y0";
            this.label_y0.Padding = new System.Windows.Forms.Padding(4);
            this.label_y0.Size = new System.Drawing.Size(213, 23);
            this.label_y0.TabIndex = 0;
            this.label_y0.Text = "y₀";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Computational practicum";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox_y0;
        private System.Windows.Forms.Label label_y0;
        private System.Windows.Forms.TextBox textBox_x0;
        private System.Windows.Forms.Label label_x0;
        private System.Windows.Forms.CheckBox checkBox_IEM;
        private System.Windows.Forms.CheckBox checkBox_EM;
        private System.Windows.Forms.Button button_Plot;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.CheckBox checkBox_ES;
        private System.Windows.Forms.CheckBox checkBox_RKM;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

