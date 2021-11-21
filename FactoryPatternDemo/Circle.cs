using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::Draw() method.");
        }
    }
}
