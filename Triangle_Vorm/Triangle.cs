using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Vorm
{
    class Triangle
    {
        public double a; // 1st stroka
        public double b; // 2st storka
        public double c; // 3th stroka
        public double h; // 4rd stroka

        public Triangle(double A, double B, double C) // Konstryktor
        { 
            a = A; // Sozdaem s zadannqmi dlinami storon soglasno zadaniyu
            b = B;
            c = C;
        }
        public Triangle(double A, double H) // Konstryktor
        {
            a = A; 
            h = H;
        }
        public Triangle() // Pystoy konstryktor
        {
           
        }

        public string outputA() // vqvodim storony A, dannqi metod vozrashaet strokovoe znachenie
        {
            return Convert.ToString(a); // a - ssqlka na vnytrenne pole objekta klassa.
        }

        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }

        public double Perimeter() // summa vsex storon tipa double
        {
            double p = 0;
            p = a + b + c; // vqchislenie
            return p; // vozvrat
        }

        public double Surface() // analogichno perimetry
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }

        public double GetSetA // svoistvo pozvolyaeshee ystanovit libo izmenit znachenie storonq A
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public double GetSetH
        {
            get
            { return h; }
            set
            { h = value; }
        }

        public bool ExistTriange // svoistvo pozvolyaeshee ystanovit, sywestvyet li treygolnik s zadannqmi storonami
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b)) // summa 2 storon doljna bqt bolshe tretjey
                    return true;
                else return false;
            }
        }
    }
}
