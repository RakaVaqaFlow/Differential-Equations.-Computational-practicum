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

        public override double calcYPrime(double x, double y) { }
        public override double[] calcExactSolution() { }
        protected override bool isCountinious(double x0, double X) { }

    }
}
