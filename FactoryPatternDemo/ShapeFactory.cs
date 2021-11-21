using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    public static class ShapeFactory
    {
        public static IShape GetShape(string ShapeType)
        {
            if (ShapeType == null)
            {
                return null;
            }
            if (ShapeType.Equals("CIRCLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Circle();
            }
            else
            {
                if (ShapeType.Equals("SQUARE", StringComparison.InvariantCultureIgnoreCase))
                {
                    return new Square();
                }
                else
                {
                    if (ShapeType.Equals("RECTANGLE", StringComparison.InvariantCultureIgnoreCase))
                    {
                        return new Rectangle();
                    }
                }
            }
            return null;
        }
    }
}
