using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public abstract class NumericalMethod : Grid
    {
        protected DifferentialEquation differentialEquation;
        public NumericalMethod(int N, double y0, double x0, double X, DifferentialEquation DE)
            : base(N, y0, x0, X) {
            this.differentialEquation = DE;

            double h = getStep();
            double[] y = getY();
            double[] x = getX();

            for (int i = 0; i < N; i++)
            {
                if (i == 0) y[i] = y0;
                else y[i] = calcY(x[i - 1], y[i - 1]);
            }
            this.setY(y);
            
        }

        protected abstract double calcY(double prevX, double prevY);
        public void calcLocalTruncationError() 
        {
            
        }
        public void calcGlobalTruncationError(int n0, int n)
        {

        }
        
    }
}
