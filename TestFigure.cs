using System;
namespace abstractimplementation
{
    public abstract class Figure
    {
        public double width,height,radius;
        public const float pi=3.14f;
        public abstract double getArea();
    }
        public class Rectangle:Figure{
            public Rectangle(double width,double height)
            {
                this.width=width;
                this.height=height;
            }
            public override double getArea()
            {
                return width*height;
            }
        }
        public class Circle:Figure{
            public Circle(double radius)
            {
                this.radius=radius;
            }
              public override double getArea()
            {
                return pi*radius*radius;
            }   
        }
        class TestFigure
        {
            static void Main()
            {
                var obj=new Rectangle(10.45,20.54);
                var obj1=new Circle(12.5);
                System.Console.WriteLine("Area of Rectangle is"+obj.getArea());
                System.Console.WriteLine("Area of Circle is"+obj1.getArea());
            }

        }
}
