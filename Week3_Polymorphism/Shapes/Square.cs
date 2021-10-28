using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Week3_Polymorphism.Shapes
{
    public class Square: Shape
    {
        public double Length { get; set; }


        public override double FindPerimeter()
        {
            return Length * 4;
        }

        public override double FindArea()
        {
            return Length * Length;
        }

        public override void Draw(Graphics g,Color c)
        {
            g.DrawRectangle(new Pen(c), (float)X, (float) Y, (float)Length, (float)Length);
        }

    }

    
}
