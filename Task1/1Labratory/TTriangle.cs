using System.Xml.Linq;

namespace _1Labratory
{
    class TTriangle
    {
        protected double a, b, c;

        public TTriangle()
        {
            a = 3;
            b = 4;
            c = 5;       
        }

        public TTriangle(double sideA, double sideB, double sideC)
        {
            Fill_sides(sideA, sideB, sideC);
        }

        public static bool Check_Triangle_Exists(double a, double b, double c)
        {   
            if (a < 0 || b < 0 || c < 0)
                return false;

            double max_side = Math.Max(a, Math.Max(b, c));
            double sum_allsides = a + b + c;

            return (max_side < sum_allsides - max_side);
        }

        public void Fill_sides(double a, double b, double c)
        {
            if (Check_Triangle_Exists(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                Console.WriteLine("Такого трикутника не існує!");
            }
        }

        public double FillSide_A
        {
            get { return a; }
            set { 
                  if (Check_Triangle_Exists(value,b,c))
                    a = value;
                }
        }

        public double FillSide_B
        {
            get { return b; }
            set 
            {
                if (Check_Triangle_Exists(a, value, c))
                    b = value;
            }
        }

        public double FillSide_C
        {
            get { return c; }
            set
            {
                if (Check_Triangle_Exists(a, b, value))
                    c = value;
            }
        }

        public double count_perimeter()
        {
            return a + b + c;
        }

        public double count_area()
        {
            double p = count_perimeter() / 2.0;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }
}
