using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Polymorphism.Shapes
{
    public class Cuboid: Rectangle
    {

        public double Height { get; set; }

        public override double FindArea()
        {
            return 2 * ((Length * Width) + (Width * Height) + (Length * Height));
        }

        public override double FindPerimeter()
        {
            return 4 * (Length + Width + Height);
        }
    }
}
