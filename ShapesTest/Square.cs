using System;

namespace ShapesTest
{
    public class Square : Figure
    {

        public Square(double xx, double yy, string name):base(xx,yy,name)
        {
            
        }


       
         
        public override double Area()
        {
            double area = X * Y;
            return area;
        }
    }
}
