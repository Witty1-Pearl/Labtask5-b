using System;

namespace ShapesTest
{
    public class Triangle : Figure
    {
        
        
        public Triangle(double xx, double yy, string name):base(xx,yy,name)
        {
            
        }
        
       
        public override double Area()
        {
            double area = 0.5 * X * Y ;
            return area;
        }
    }
}
