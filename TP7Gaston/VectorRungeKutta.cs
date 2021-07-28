using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    class VectorRungeKutta
    {
        private double h;
        private double e;
        private double t;
        private double z;
        private double k1;
        private double l1;
        private double eh2;
        private double tk1h2;
        private double zl1h2;
        private double k2;
        private double l2;
        private double tk2h2;
        private double zl2h2;
        private double k3;
        private double l3;
        private double eh;
        private double tk3h;
        private double zl3h;
        private double k4;
        private double l4;
        private double alfa;
        private double beta;

        public VectorRungeKutta(double eo, double To, double Zo, double h, double alfa, double beta)
        {
            this.E = eo;
            this.T = To;
            this.Z = Zo;
            this.H = h;
            this.Alfa = alfa;
            this.Beta = beta;
        }

        public double H { get => h; set => h = value; }
        public double E { get => e; set => e = value; }
        public double T { get => t; set => t = value; }
        public double Z { get => z; set => z = value; }
        public double K1 { get => k1; set => k1 = value; }
        public double L1 { get => l1; set => l1 = value; }
        public double Eh2 { get => eh2; set => eh2 = value; }
        public double Tk1h2 { get => tk1h2; set => tk1h2 = value; }
        public double Zl1h2 { get => zl1h2; set => zl1h2 = value; }
        public double K2 { get => k2; set => k2 = value; }
        public double L2 { get => l2; set => l2 = value; }
        public double Tk2h2 { get => tk2h2; set => tk2h2 = value; }
        public double Zl2h2 { get => zl2h2; set => zl2h2 = value; }
        public double K3 { get => k3; set => k3 = value; }
        public double L3 { get => l3; set => l3 = value; }
        public double Eh { get => eh; set => eh = value; }
        public double Tk3h { get => tk3h; set => tk3h = value; }
        public double Zl3h { get => zl3h; set => zl3h = value; }
        public double K4 { get => k4; set => k4 = value; }
        public double L4 { get => l4; set => l4 = value; }
        public double Alfa { get => alfa; set => alfa = value; }
        public double Beta { get => beta; set => beta = value; }

        public VectorRungeKutta siguiente()
        {
            double incT = H / 6 * (K1 + 2 * K2 + 2 * K3 + K4);
            double incZ = H / 6 * (L1 + 2 * L2 + 2 * L3 + L4);
            VectorRungeKutta siguiente = new VectorRungeKutta(E + H, T + incT, Z + incZ, H, Alfa, Beta);
            siguiente.calcularValores();
            return siguiente;
        }

        public void calcularValores()
        {
            this.k1 = funcT(E, T, Z);
            this.l1 = funcZ(E, T, Z);

            this.eh2 = E + H / 2;
            this.tk1h2 = t + k1 * h / 2;
            this.zl1h2 = z + l1 * h / 2;
            this.k2 = funcT(eh2, tk1h2, zl1h2);
            this.l2 = funcZ(eh2, tk1h2, zl1h2);

            this.tk2h2 = t + k2 * h / 2;
            this.zl2h2 = z + l2 * h / 2;
            this.k3 = funcT(eh2, tk2h2, zl2h2);
            this.l3 = funcZ(eh2, tk2h2, zl2h2);

            this.eh = e + h;
            this.tk3h = t + k3 * h;
            this.zl3h = z + l3 * h;
            this.k4 = funcT(eh, tk3h, zl3h);
            this.l4 = funcZ(eh, tk3h, zl3h);
        }

        private double funcT(double e, double T, double Z)
        {
            return Z;
        }

        private double funcZ(double e, double T, double Z)
        {
            return Alfa * (Math.Sqrt(Z)) + Beta * T;
        }
    }
}
