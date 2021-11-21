using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::Draw() method.");
        }
    }
}
