using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public class RKM : NumericalMethod
    {
        public RKM(int N, double y0, double x0, double X) : base(N, y0, x0, X)
        {
            double h = (X - x0) / N;
            for (int i = 0; i < N; i++)
            {
                if (i == 0) y[i] = y0;
                else
                {
                    double k1 = x[i - 1] * y[i - 1] - x[i - 1] * Math.Pow(y[i - 1], 3);

                    double xi = x[i - 1] + h / 2;
                    double yi = y[i - 1] + h * k1 / 1;
                    double k2 = xi*yi-xi*Math.Pow(yi, 3);

                    yi = y[i - 1] + k2 * h / 2;
                    double k3 = xi * yi - xi * Math.Pow(yi, 3);

                    xi = x[i - 1] + h;
                    yi = y[i - 1] + h * k3;
                    double k4 = xi * yi - xi * Math.Pow(yi, 3);
                    y[i] = y[i - 1] + h * (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                }
            }
        }
    }
}
