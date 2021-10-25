using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public class ImprovedEulerMethod : NumericalMethod
    {
        public ImprovedEulerMethod(int N, double y0, double x0, double X, DifferentialEquation DE) : base(N, y0, x0, X, DE)
        {
        
        }
        protected override double calcY(double prevX, double prevY)
        {
            double h = getStep();
            double k1 = differentialEquation.calcDerivative(prevX, prevY);
            double k2 = differentialEquation.calcDerivative(prevX+h, prevY+h*k1);
            double Y = prevY + h * (k1 + k2) / 2;
            return Y;
        }
    }
}
