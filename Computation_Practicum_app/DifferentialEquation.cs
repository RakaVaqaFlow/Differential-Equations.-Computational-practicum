using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public abstract class DifferentialEquation : Grid
    {
        public DifferentialEquation(int N, double y0, double x0, double X)
            : base(N, y0, x0, X) {}

        public abstract double calcDerivative(double x, double y);
        protected abstract void calcExactSolution();
        protected abstract double[] findDiscontinuityPoints();
       
    }
}
