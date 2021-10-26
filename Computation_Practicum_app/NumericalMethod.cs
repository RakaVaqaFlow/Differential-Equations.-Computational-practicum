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
        private double[] localErrors;
        //private double[] globalErrors;
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
            calcLocalTruncationErrors();
        }

        protected abstract double calcY(double prevX, double prevY);
        private void calcLocalTruncationErrors() 
        {
            double[] yExact = differentialEquation.getY();
            double[] yNumerical = getY();
            double[] Errors = new double[getN()];
            for(int i=0; i<getN(); i++)
            {
                Errors[i] = Math.Abs(yExact[i] - yNumerical[i]);
            }
            this.localErrors = Errors;
        }
        public double[] getLocalTruncationErrors() => this.localErrors;
        public double getGlobalTruncationError()
        {
            double maxError = 0;
            for(int i=0; i<getN(); i++)
            {
                if (localErrors[i] > maxError) maxError = localErrors[i];
            }
            return maxError;
        }
        
    }
}
