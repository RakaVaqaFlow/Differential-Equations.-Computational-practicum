using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computation_Practicum_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Plot_Click(object sender, EventArgs e)
        {
            try
            {
                double y0 = Double.Parse(textBox_y0.Text);
                double x0 = Double.Parse(textBox_x0.Text);
                double X = Double.Parse(textBox_X.Text);
                int N = Int32.Parse(textBox_N.Text);
                /*
                EulerMethod newEM = new EulerMethod(N, y0, x0, X);
                ImprovedEulerMethod newIEM = new ImprovedEulerMethod(N, y0, x0, X);
                RungeKuttaMethod newRKM = new RungeKuttaMethod(N, y0, x0, X);
                DifferentialEquation newES = new MyDifferentialEquation(N, y0, x0, X);
                
                chart1.Series[0].Points.DataBindXY(newEM.getX(), newEM.getY());
                chart1.Series[1].Points.DataBindXY(newIEM.getX(), newIEM.getY());
                chart1.Series[2].Points.DataBindXY(newRKM.getX(), newRKM.getY());
                chart1.Series[3].Points.DataBindXY(newEM.getX(), newEM.getY());

                chart2.Series[0].Points.DataBindXY(newEM.getX(), newEM.getY());
                chart2.Series[1].Points.DataBindXY(newEM.getX(), newEM.getY());
                chart2.Series[2].Points.DataBindXY(newEM.getX(), newEM.getY());
                

                chart1.ChartAreas[0].AxisX.Minimum = x0;
                chart1.ChartAreas[0].AxisX.Maximum = X;

                chart2.ChartAreas[0].AxisX.Minimum = x0;
                chart2.ChartAreas[0].AxisX.Maximum = X;
                */
            }
            catch
            {
                MessageBox.Show("Wrong data format!");
            }
            
        }

        private void checkBox_EM_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].Enabled = checkBox_EM.Checked;
            chart2.Series[0].Enabled = checkBox_EM.Checked;
        }

        private void checkBox_IEM_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[1].Enabled = checkBox_IEM.Checked;
            chart2.Series[1].Enabled = checkBox_IEM.Checked;
        }

        private void checkBox_RKM_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[2].Enabled = checkBox_RKM.Checked;
            chart2.Series[2].Enabled = checkBox_RKM.Checked;
        }

        private void checkBox_ES_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[3].Enabled = checkBox_ES.Checked;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            button_Plot_Click(sender, e);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl.SelectedIndex == 0)
            {
                checkBox_ES.Visible = true;
            }
            else if (tabControl.SelectedIndex == 1)
            {
                checkBox_ES.Visible = false;
            }
        }
    }
}
