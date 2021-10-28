using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Week3_Polymorphism.Shapes
{
    public  class Rectangle: Square
    {
        public double Width { get; set; }


        public override double FindArea()
        {
            return Length * Width;
        }

        public override double FindPerimeter()
        {
            return (Length + Width) * 2;
        }

        public override void Draw(Graphics g, Color c)
        {
            g.DrawRectangle(new Pen(c), (float)X, (float)Y, (float)Length, (float)Width);
        }
    }
}
