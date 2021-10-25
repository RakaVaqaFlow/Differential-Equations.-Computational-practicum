using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public abstract class DifferentialEquation : Grid
    {
        DifferentialEquation(int N, double y0, double x0, double X)
            : base(N, x0, X) {}

        public abstract double calcYPrime(double x, double y);
        public abstract double[] calcExactSolution();
        protected abstract bool isCountinious(double x0, double X);
       
    }
}
