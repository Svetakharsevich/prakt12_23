using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr11_12
{
    class Triangles
    {
        double x0;
        double y0;
        double S;
        double p;
        public double P(double x1, double y1, double x2, double y2, double x3, double y3)//Периметр
        {
            double P;
            Console.WriteLine(P = Math.Sqrt(Math.Pow(x2 - x1, 2)
                + Math.Pow(y2 - y1, 2)) + Math.Sqrt(Math.Pow(x3 - x2, 2)
                + Math.Pow(y3 - y2, 2)) + Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)));
            return Math.Round(P, 3); ;

        }
        public double IntrtsectionX0(double x1, double x2,double x3)//точка пересечении медианы
        {
            double x;
            Console.WriteLine(x=(x1 + x2 + x3) / 3);
            return Math.Round(x, 3); ;
        }
        public double IntrtsectionY0(double y1, double y2, double y3)//точка пересечения медианы
        {
            double y;
            Console.WriteLine(y = (y1 + y2 + y3) / 3);
            return Math.Round(y, 3); ;
        }
        public double Ss(double x1, double y1, double x2, double y2, double x3, double y3)//Площадь
        {
            double S;
            Console.WriteLine(S=Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)) / 2);
            return Math.Round(S, 3);

        }


    }
}
