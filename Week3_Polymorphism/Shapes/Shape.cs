using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Week3_Polymorphism.Shapes
{
    public class Shape: Point
    {
        public virtual double FindArea() { return 0; }

        public virtual double FindPerimeter() { return 0; }

        public override void Draw(Graphics g, Color c)
        {
        }
    }
}
