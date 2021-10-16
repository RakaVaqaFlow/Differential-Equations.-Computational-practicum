using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public class ES: Grid
    {
        public ES(int N, double y0, double x0, double X) : base(N, x0, X)
        {
            double h = (X - x0) / N;
            for (int i = 0; i < N; i++)
            {
                if (i == 0) y[i] = y0;
                else y[i] = Math.Sqrt(Math.Exp(Math.Pow(x[i - 1], 2)) / (1 + Math.Exp(Math.Pow(x[i - 1], 2))));
            }
        }
    }
}
