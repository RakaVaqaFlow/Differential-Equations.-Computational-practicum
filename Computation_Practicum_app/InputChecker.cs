using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computation_Practicum_app
{
    static public class InputChecker
    {
        public static bool CheckInput(double y0, double x0, double X, int n0, int N)
        {
            if (y0 == 0)
            {
                MessageBox.Show("y0 can not be zero! Please, put another value.");
            }
            else if (n0 > N)
            {
                MessageBox.Show("N must be greater than n0! Please, put another value.");
            }
            else if (x0 > X)
            {
                MessageBox.Show("X must be greater than x0! Please, put another value.");
            }
            else if (X > 8)
            {
                MessageBox.Show("X is too big! Please, put another value.");
            }
            else return true;
            return false;
        }
    }
}
