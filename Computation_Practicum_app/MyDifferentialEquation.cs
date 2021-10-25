using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public class MyDifferentialEquation : DifferentialEquation 
    {
        MyDifferentialEquation(int N, double y0, double x0, double X): base(N, y0, x0, X) {
             
        }

        public override double calcDerivative(double x, double y) { }
        public override double[] calcExactSolution() {
            double h = (X - x0) / N;
            for (int i = 0; i < N; i++)
            {
                if (i == 0) y[i] = y0;
                else y[i] = Math.Sqrt(Math.Exp(Math.Pow(x[i - 1], 2)) / (1 + Math.Exp(Math.Pow(x[i - 1], 2))));
            }
        }
        protected override bool isCountinious(double x0, double X) {
            return true;
        }

    }
}
