using System;

namespace ShapesTest
{
    public class Figure
    {
        private double x;
        private double y;
        public string Name {get; set;}

        public Figure(double xx, double yy, string name)
        {
            X = xx;
            Y = yy;
            Name = name;
        }

        public double X
        {
            get{return x; }
            private set
            {
                if(value > 0)
                {
                    x = value;
                }
            }
        }

         public double Y
        {
            get{return y; }
            private set
            {
                if(value > 0)
                {
                    y = value;
                }
            }
        }
        public virtual double Area()
        {
            double area = X * Y;
            return area;
        }
    }
}
