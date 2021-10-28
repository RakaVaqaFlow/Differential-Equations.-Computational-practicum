using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public class DataСontainer
    {
        public DifferentialEquation myDE;
        public NumericalMethod EuelerMethod;
        public NumericalMethod ImprovedEulerMethod;
        public NumericalMethod RungeKuttaMethod;
        private int n0;
        private int N;
        private double y0;
        private double x0;
        private double X;
        private Int32[] xGE;
        private double[] getGlobalError(string method)
        {
            double[] GlobalError = new double[N - n0];
            NumericalMethod numericalMethod;
            for (int i = 0; i < N - n0; i++)
            {
                if (method == "EulerMethod")
                    numericalMethod = new EulerMethod(xGE[i], y0, x0, X, myDE);
                else if (method == "ImprovedEulerMethod")
                    numericalMethod = new ImprovedEulerMethod(xGE[i], y0, x0, X, myDE);
                else if (method == "RungeKuttaMethod")
                    numericalMethod = new RungeKuttaMethod(xGE[i], y0, x0, X, myDE);
                else throw new Exception("wrong method");

                GlobalError[i] = numericalMethod.getGlobalError();

            }

            return GlobalError;
        }
        public DataСontainer(double y0, double x0, double X, int n0, int N)
        {
            myDE = new MyDifferentialEquation(N, y0, x0, X);
            EuelerMethod = new EulerMethod(N, y0, x0, X, myDE);
            ImprovedEulerMethod = new ImprovedEulerMethod(N, y0, x0, X, myDE);
            RungeKuttaMethod = new RungeKuttaMethod(N, y0, x0, X, myDE);
            this.n0 = n0;
            this.N = N;
            this.y0 = y0;
            this.x0 = x0;
            this.X = X;
            xGE = new Int32[N - n0];

            for (int i = 0; i < N - n0; i++) xGE[i] = i + n0;
        }
        public int[] getXforGlobalError()
        {
            return xGE;
        }
        public double[] getGlobalErrorOfEM()
        {   
            return getGlobalError("EulerMethod");
        }

        public double[] getGlobalErrorOfIEM()
        {
            return getGlobalError("ImprovedEulerMethod");
        }
        public double[] getGlobalErrorOfRKM()
        {
            return getGlobalError("RungeKuttaMethod");
        }

        public double getYmaxOfSol()
        {

        }
        public double getYmaxOfLTE()
        {

        }
        public double getYminOfSol()
        {

        }

        public double getYminOfLTE()
        {

        }
    }
}
