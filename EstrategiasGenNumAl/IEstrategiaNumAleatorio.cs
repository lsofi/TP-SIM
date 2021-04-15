using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GeneracionDeNumerosAleatorios
{
    abstract class IEstrategiaNumAleatorio
    {
        
        public virtual bool validarK(int k)
        {
            return true;
        }

        public virtual string stringVerk()
        {
            return "";
        }

        public virtual int calcularA(int k)
        {
            return 0;
        }

        public virtual bool validarX0impar(int x0)
        {
            return true;
        }

        public virtual double calcularM(int g)
        {
            return Math.Pow(2,g);
        }

        public virtual bool verificarMyCPrimos(double m, int c)
        {
            return true;
        }
        
        public virtual double[] calcularSiguiente(int xi, int a, int c, double m)
        {
            double[] vector = new double[2];
            return vector;
        }
    }
}
