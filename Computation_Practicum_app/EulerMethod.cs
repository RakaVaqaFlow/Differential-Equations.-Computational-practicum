using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public class EulerMethod : NumericalMethod
    {
        public EulerMethod(int N, double y0, double x0, double X, DifferentialEquation DE)
            : base(N, y0, x0, X, DE) { }
   
        protected override double calcY(double prevX, double prevY)
        {
            double h = getStep();
            double Y = prevY + h * differentialEquation.calcDerivative(prevX, prevY);
            return Y;
        }

    }
}



