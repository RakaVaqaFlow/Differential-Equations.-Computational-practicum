using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public abstract class NumericalMethod : Grid
    {
        public NumericalMethod(int N, double y0, double x0, double X)
            : base(N, x0, X) { }

        /*
        public calcLocalTruncationError()
        {

        }

        public calcGlobalTruncationError(){
        
        }
        */
    }
}
