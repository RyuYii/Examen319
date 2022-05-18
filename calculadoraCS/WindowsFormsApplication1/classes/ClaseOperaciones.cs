using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.classes
{
    class ClaseOperaciones
    {
        public double Sumas(double n1, double n2)
        {
            double s;
            s = n1 + n2;
            return s;
        }

        public double Restas(double n1, double n2)
        {
            double s;
            s = n1 - n2;
            return s;
        }

        public double Multiplicacion(double n1, double n2)
        {
            double s;
            s = n1 * n2;
            return s;
        }

        public double Division(double n1, double n2)
        {
            double s;
            s = n1 / n2;
            return s;
        }

        public double Cuadrado(double n1)
        {
            double s;
            s = n1 * n1;
            return s;
        }

        public double Raiz(double n1)
        {
            double s;
            s = Math.Sqrt(n1);
            return s;
        }

        public double inversoMultiplicativo(double n1)
        {
            double s;
            s = 1 / n1;
            return s;
        }

        public double Modulo(double n1)
        {
            double s;
            s = n1 / 100;
            return s;
        }
    }
}
