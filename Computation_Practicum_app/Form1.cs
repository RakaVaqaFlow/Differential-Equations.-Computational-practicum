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

                DifferentialEquation newDE = new MyDifferentialEquation(N, y0, x0, X);

                NumericalMethod newEM = new EulerMethod(N, y0, x0, X, newDE);
                NumericalMethod newIEM = new ImprovedEulerMethod(N, y0, x0, X, newDE);
                NumericalMethod newRKM = new RungeKuttaMethod(N, y0, x0, X, newDE);


                Solutions.Series[0].Points.DataBindXY(newEM.getX(), newEM.getY());
                Solutions.Series[1].Points.DataBindXY(newIEM.getX(), newIEM.getY());
                Solutions.Series[2].Points.DataBindXY(newRKM.getX(), newRKM.getY());
                Solutions.Series[3].Points.DataBindXY(newDE.getX(), newDE.getY());

                LTE.Series[0].Points.DataBindXY(newEM.getX(), newEM.getLocalTruncationErrors());
                LTE.Series[1].Points.DataBindXY(newIEM.getX(), newIEM.getLocalTruncationErrors());
                LTE.Series[2].Points.DataBindXY(newRKM.getX(), newRKM.getLocalTruncationErrors());
                

                Solutions.ChartAreas[0].AxisX.Minimum = x0;
                Solutions.ChartAreas[0].AxisX.Maximum = X;

                LTE.ChartAreas[0].AxisX.Minimum = x0;
                LTE.ChartAreas[0].AxisX.Maximum = X;
                
            }
            catch
            {
                MessageBox.Show("Wrong data format!");
            }
            
        }

        private void checkBox_EM_CheckedChanged(object sender, EventArgs e)
        {
            Solutions.Series[0].Enabled = checkBox_EM.Checked;
            LTE.Series[0].Enabled = checkBox_EM.Checked;
        }

        private void checkBox_IEM_CheckedChanged(object sender, EventArgs e)
        {
            Solutions.Series[1].Enabled = checkBox_IEM.Checked;
            LTE.Series[1].Enabled = checkBox_IEM.Checked;
        }

        private void checkBox_RKM_CheckedChanged(object sender, EventArgs e)
        {
            Solutions.Series[2].Enabled = checkBox_RKM.Checked;
            LTE.Series[2].Enabled = checkBox_RKM.Checked;
        }

        private void checkBox_ES_CheckedChanged(object sender, EventArgs e)
        {
            Solutions.Series[3].Enabled = checkBox_ES.Checked;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            button_Plot_Click(sender, e);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl.SelectedIndex == 0)
            {
                label_y0.Visible = true;
                textBox_y0.Visible = true;

                label_x0.Visible = true;
                textBox_x0.Visible = true;

                label_X.Visible = true;
                textBox_X.Visible = true;

                label_n0.Visible = false;
                textBox_n0.Visible = false;

                label_N.Visible = true;
                textBox_N.Visible = true;

                checkBox_ES.Visible = true;

            }
            else if(tabControl.SelectedIndex == 1)
            {
                label_y0.Visible = true;
                textBox_y0.Visible = true;

                label_x0.Visible = true;
                textBox_x0.Visible = true;

                label_X.Visible = true;
                textBox_X.Visible = true;

                label_n0.Visible = false;
                textBox_n0.Visible = false;

                label_N.Visible = true;
                textBox_N.Visible = true;

                checkBox_ES.Visible = false;
            }
            else if (tabControl.SelectedIndex == 2)
            {   
                label_y0.Visible = false;
                textBox_y0.Visible = false;

                label_x0.Visible = false;
                textBox_x0.Visible = false;

                label_X.Visible = false;
                textBox_X.Visible = false;
                
                textBox_n0.Visible = true;
                label_n0.Visible = true;

                label_N.Visible = true;
                textBox_N.Visible = true;

                checkBox_ES.Visible = false;
            }
        }

    }
}
