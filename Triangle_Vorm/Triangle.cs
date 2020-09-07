using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            h = H; // vqsota
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
        public double Height()
        {
            return Surface() * 2 / a;
        }

        public double Median()
        {
            return (Math.Sqrt(2 * b * b + 2 * c * c - a * a) / 2);
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
                if ((a < b + c) && (b < a + c) && (c < a + b)) // summa 2 storon doljna bqt bolshe tretjey
                    return true;
                else return false;
            }
        }

        public string TriangleType()
        {
            string type = "";
            if (a == b && b == c)
            {
                type = "Равносторонний";
            }
            else if ((a == b) && (a != c) || (b == c) && (b != a) || (a == c) && (a != b))
            {
                type = "Равнобедренный";
            }
            else if (a != b || b != c)
            {
                type = "Разносторонний";
            }
            else if (c * 2 == (a * 2 + b * 2))
            {
                type = "Правильный";
            }
            else if (c * 2 > (a * 2 + b * 2))
            {
                type = "Тупоугольный";
            }
            else if (c * 2 < (a * 2 + b * 2))
            {
                type = "Остроугольный";
            }
            return type;
        }
        public string Source()
        {
            string source = Application.StartupPath;
            switch (TriangleType())
            {
                case "Равносторонний":
                    source += "equilateral";
                    break;
                case "Равнобедренный":
                    source += "isosceles";
                    break;
                case "Разносторонний":
                    source += "scalane";
                    break;
                case "Правильный":
                    source += "right";
                    break;
                case "Тупоугольный":
                    source += "obtuse";
                    break;
                case "Остроугольный":
                    source += "acute";
                    break;
            }
            return source;
        }
    }
}