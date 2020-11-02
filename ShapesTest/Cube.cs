using System;

namespace ShapesTest
{
    public class Cube : Figure
    {
        
        public Cube(double xx, double yy, string name):base(xx,yy,name)
        {
            
        }
        
        

        public override double Area()
        {
            double area = 6 * (Math.Pow(X, 2));
            return area;
        }
    }
}
