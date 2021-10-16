
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_y0 = new System.Windows.Forms.Label();
            this.textBox_y0 = new System.Windows.Forms.TextBox();
            this.textBox_x0 = new System.Windows.Forms.TextBox();
            this.label_x0 = new System.Windows.Forms.Label();
            this.checkBox_IEM = new System.Windows.Forms.CheckBox();
            this.checkBox_EM = new System.Windows.Forms.CheckBox();
            this.button_Plot = new System.Windows.Forms.Button();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label_N = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.chart1);
            // 
            // splitContainer1.Panel2
            // 
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
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "EM";
            series1.Name = "Series_EM";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "IEM";
            series2.Name = "Series_IEM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(513, 450);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            // textBox_y0
            // 
            this.textBox_y0.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_y0.Location = new System.Drawing.Point(0, 28);
            this.textBox_y0.Name = "textBox_y0";
            this.textBox_y0.Size = new System.Drawing.Size(283, 22);
            this.textBox_y0.TabIndex = 1;
            this.textBox_y0.Text = "0";
            this.textBox_y0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label_x0.Click += new System.EventHandler(this.label4_Click);
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
            // 
            // textBox_N
            // 
            this.textBox_N.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_N.Location = new System.Drawing.Point(0, 178);
            this.textBox_N.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(283, 22);
            this.textBox_N.TabIndex = 14;
            this.textBox_N.Text = "20";
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
            this.textBox_X.Text = "10";
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
    }
}

