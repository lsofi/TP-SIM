using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    class VectorRungeKuttaVaciado
    {
        private double h;
        private double t;
        private double x;
        private double k1;
        private double th2;
        private double xk1h2;
        private double k2;
        private double xk2h2;
        private double k3;
        private double th;
        private double xk3h;
        private double k4;
        private double alfa = 0.001763;

        public VectorRungeKuttaVaciado(double t, double x, double h)
        {
            this.t = t;
            this.x = x;
            this.h = h;
        }

        public VectorRungeKuttaVaciado(double x, double h)
        {
            this.t = 0;
            this.x = x;
            this.h = h;
        }

        public double T { get => t; set => t = value; }
        public double X { get => x; set => x = value; }
        public double K1 { get => k1; set => k1 = value; }
        public double Th2 { get => th2; set => th2 = value; }
        public double Xk1h2 { get => xk1h2; set => xk1h2 = value; }
        public double K2 { get => k2; set => k2 = value; }
        public double Xk2h2 { get => xk2h2; set => xk2h2 = value; }
        public double K3 { get => k3; set => k3 = value; }
        public double Th { get => th; set => th = value; }
        public double Xk3h { get => xk3h; set => xk3h = value; }
        public double K4 { get => k4; set => k4 = value; }

        public VectorRungeKuttaVaciado siguiente()
        {
            double incX = (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
            VectorRungeKuttaVaciado res = new VectorRungeKuttaVaciado(t + h, x + incX, h);
            res.calcularValores();
            return res;
        }

        public void calcularValores()
        {
            this.k1 = func(t, x);
            this.th2 = t * h / 2;
            this.xk1h2 = x + k1 * h / 2;
            this.k2 = func(th2, xk1h2);
            this.xk2h2 = x + k2 * h / 2;
            this.k3 = func(th2, xk2h2);
            this.th = t + h;
            this.xk3h = x + k3 * h;
            this.k4 = func(th, xk3h);
        }

        private double func(double t, double x)
        {
            return -alfa * x * 0.5;
        }
    }
}
