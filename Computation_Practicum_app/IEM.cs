using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public class IEM : Grid
    {
        public IEM(int N, double y0, double x0, double X) : base(N, x0, X)
        {
            double h = (X - x0) / N;
            for (int i = 0; i < N; i++)
            {
                if (i == 0) y[i] = y0;
                else
                {
                    double k1 = y[i - 1];
                    double yi = y[i - 1] + h * y[i - 1];
                    double k2 = x[i] * yi - x[i] * Math.Pow(yi, 3);
                    y[i] = y[i - 1] + h * (k1 + k2) / 2;

                }
            }
        }
    }
}
