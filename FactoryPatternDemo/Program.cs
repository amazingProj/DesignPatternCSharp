using System;

namespace FactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //get an object of Circle and call its draw method.
            IShape Shape1 = ShapeFactory.GetShape("CIRCLE");

            //call draw method of Circle
            Shape1.Draw();

            //get an object of Rectangle and call its draw method.
            IShape Shape2 = ShapeFactory.GetShape("RECTANGLE");

            //call draw method of Rectangle
            Shape2.Draw();

            //get an object of Square and call its draw method.
            IShape Shape3 = ShapeFactory.GetShape("SQUARE");

            //call draw method of square
            Shape3.Draw();
        }
    }
}
