using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::Draw() method.");
        }
    }
}
