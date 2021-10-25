using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public class MyDifferentialEquation : DifferentialEquation 
    {
        public MyDifferentialEquation(int N, double y0, double x0, double X): base(N, y0, x0, X) {
            if (findDiscontinuityPoints().Length != 0)
            {
                string message = "The function has a discontinuity point in this interval!";
                throw new Exception(message);
            }
            calcExactSolution();
        }

        public override double calcDerivative(double x, double y) {
            return x * y - x * Math.Pow(y, 3);        
        }
        protected override void calcExactSolution()
        {
            double h = getStep();
            double[] x = getX();
            double[] y = getY();
            for (int i = 0; i < getN(); i++)
            {
                if (i == 0) y[i] = getY0();
                else y[i] = Math.Sqrt(Math.Exp(Math.Pow(x[i - 1], 2)) / (1 + Math.Exp(Math.Pow(x[i - 1], 2))));
            }
            setY(y);
        }

        //let's return empty list, because my equation has no discontinuity points 
        protected override double[] findDiscontinuityPoints() { 
            return new List<double>().ToArray(); 
        }

    }
}
