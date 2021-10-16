using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public class EM : Grid
    {
        public EM(int N, double x0, double X, double Y):base(N, x0, X)
        {
            double h = (X - x0) / N;
            for (int i=0; i<N; i++)
            {
                if (i == 0) y[i] = Y;
                else y[i] = y[i - 1] + h * (x[i - 1] * y[i - 1] - x[i - 1] * Math.Pow(y[i - 1], 3));
            }
        }
    }
}
