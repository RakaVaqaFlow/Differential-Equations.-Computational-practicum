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

            }
            catch
            {
                MessageBox.Show("Wrong data format!");
            }
            //EM newEM = new EM(N, X, x0, y0);
        }

        private void checkBox_EM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_IEM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_RKM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_ES_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
