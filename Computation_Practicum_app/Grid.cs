using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation_Practicum_app
{
    public class Grid
    {
        private double[] x;
        private double[] y;
        private int N;
        private double h;
        private double y0;
        private double x0;
        private double X;

        public Grid(int N, double y0, double x0, double X)
        {
            this.N = N;
            this.h = (X - x0) / (N-1);
            this.x = new double[N];
            this.y = new double[N];
            this.x0 = x0;
            this.y0 = y0;
            this.X = X;

            y[0] = y0;

            for (int i=0; i<N; i++)
            {
                if (i == 0) x[i] = 0;
                else x[i] = x[i - 1] + h;
            }
        }

        public double[] getX() => this.x;
        public double[] getY() => this.y;
        public int getN() => this.N;
        public double getStep() => this.h;
        public double getY0() => this.y0;
        public double getX0() => this.x0;
        public double getXn() => this.X;
        public void setY(double[] y) { 
            this.y = y; 
        }
    }
}
