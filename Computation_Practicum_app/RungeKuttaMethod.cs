using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public class RungeKuttaMethod : NumericalMethod
    {
        public RungeKuttaMethod(int N, double y0, double x0, double X, DifferentialEquation DE) 
            : base(N, y0, x0, X, DE){ }

        protected override double calcY(double prevX, double prevY)
        {
            double h = getStep();
            double k1 = differentialEquation.calcDerivative(prevX, prevY);
            double k2 = differentialEquation.calcDerivative(prevX + h / 2, prevY + k1 * h / 2);
            double k3 = differentialEquation.calcDerivative(prevX + h / 2, prevY + k2 * h / 2); 
            double k4 = differentialEquation.calcDerivative(prevX + h , prevY + k3 * h); 
            double Y = prevY + h*(k1+2*k2+2*k3+k4)/6;
            return Y;
        }
    }
}
