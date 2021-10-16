
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabPage);
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 513;
            this.splitContainer1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Euler method";
            series1.Name = "Series_EM";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Imp. Euler\'s method";
            series2.Name = "Series_IEM";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "Runge Kutta method";
            series3.Name = "Series_RK";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "Exact solution";
            series4.Name = "Series_ES";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(499, 415);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // checkBox_ES
            // 
            this.checkBox_ES.AutoSize = true;
            this.checkBox_ES.Checked = true;
            this.checkBox_ES.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ES.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_ES.Location = new System.Drawing.Point(0, 304);
            this.checkBox_ES.Name = "checkBox_ES";
            this.checkBox_ES.Size = new System.Drawing.Size(283, 21);
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
            this.checkBox_RKM.Location = new System.Drawing.Point(0, 283);
            this.checkBox_RKM.Name = "checkBox_RKM";
            this.checkBox_RKM.Size = new System.Drawing.Size(283, 21);
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
            this.checkBox_IEM.Location = new System.Drawing.Point(0, 262);
            this.checkBox_IEM.Name = "checkBox_IEM";
            this.checkBox_IEM.Size = new System.Drawing.Size(283, 21);
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
            this.checkBox_EM.Location = new System.Drawing.Point(0, 241);
            this.checkBox_EM.Name = "checkBox_EM";
            this.checkBox_EM.Size = new System.Drawing.Size(283, 21);
            this.checkBox_EM.TabIndex = 16;
            this.checkBox_EM.Text = "EM";
            this.checkBox_EM.UseVisualStyleBackColor = true;
            this.checkBox_EM.CheckedChanged += new System.EventHandler(this.checkBox_EM_CheckedChanged);
            // 
            // button_Plot
            // 
            this.button_Plot.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Plot.Location = new System.Drawing.Point(0, 200);
            this.button_Plot.Margin = new System.Windows.Forms.Padding(5);
            this.button_Plot.Name = "button_Plot";
            this.button_Plot.Padding = new System.Windows.Forms.Padding(3);
            this.button_Plot.Size = new System.Drawing.Size(283, 41);
            this.button_Plot.TabIndex = 15;
            this.button_Plot.Text = "Plot";
            this.button_Plot.UseVisualStyleBackColor = true;
            this.button_Plot.Click += new System.EventHandler(this.button_Plot_Click);
            // 
            // textBox_N
            // 
            this.textBox_N.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_N.Location = new System.Drawing.Point(0, 178);
            this.textBox_N.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(283, 22);
            this.textBox_N.TabIndex = 14;
            this.textBox_N.Text = "1000";
            this.textBox_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_N
            // 
            this.label_N.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_N.Location = new System.Drawing.Point(0, 150);
            this.label_N.Name = "label_N";
            this.label_N.Padding = new System.Windows.Forms.Padding(5);
            this.label_N.Size = new System.Drawing.Size(283, 28);
            this.label_N.TabIndex = 13;
            this.label_N.Text = "N";
            // 
            // textBox_X
            // 
            this.textBox_X.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_X.Location = new System.Drawing.Point(0, 128);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(283, 22);
            this.textBox_X.TabIndex = 12;
            this.textBox_X.Text = "3";
            this.textBox_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_X
            // 
            this.label_X.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_X.Location = new System.Drawing.Point(0, 100);
            this.label_X.Name = "label_X";
            this.label_X.Padding = new System.Windows.Forms.Padding(5);
            this.label_X.Size = new System.Drawing.Size(283, 28);
            this.label_X.TabIndex = 11;
            this.label_X.Text = "X";
            // 
            // textBox_x0
            // 
            this.textBox_x0.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_x0.Location = new System.Drawing.Point(0, 78);
            this.textBox_x0.Name = "textBox_x0";
            this.textBox_x0.Size = new System.Drawing.Size(283, 22);
            this.textBox_x0.TabIndex = 10;
            this.textBox_x0.Text = "0";
            this.textBox_x0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_x0
            // 
            this.label_x0.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_x0.Location = new System.Drawing.Point(0, 50);
            this.label_x0.Name = "label_x0";
            this.label_x0.Padding = new System.Windows.Forms.Padding(5);
            this.label_x0.Size = new System.Drawing.Size(283, 28);
            this.label_x0.TabIndex = 9;
            this.label_x0.Text = "x₀";
            // 
            // textBox_y0
            // 
            this.textBox_y0.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_y0.Location = new System.Drawing.Point(0, 28);
            this.textBox_y0.Name = "textBox_y0";
            this.textBox_y0.Size = new System.Drawing.Size(283, 22);
            this.textBox_y0.TabIndex = 1;
            this.textBox_y0.Text = "1,41421356";
            this.textBox_y0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_y0
            // 
            this.label_y0.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_y0.Location = new System.Drawing.Point(0, 0);
            this.label_y0.Name = "label_y0";
            this.label_y0.Padding = new System.Windows.Forms.Padding(5);
            this.label_y0.Size = new System.Drawing.Size(283, 28);
            this.label_y0.TabIndex = 0;
            this.label_y0.Text = "y₀";
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPage1);
            this.tabPage.Controls.Add(this.tabPage2);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Location = new System.Drawing.Point(0, 0);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(513, 450);
            this.tabPage.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "sol. graph";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "error graph";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.LegendText = "EM error";
            series5.Name = "Series_EM_Error";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.LegendText = "IEM error";
            series6.Name = "Series_IEM_Error";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.LegendText = "RKM error";
            series7.Name = "Series3";
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Size = new System.Drawing.Size(499, 415);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Computational practicum";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

