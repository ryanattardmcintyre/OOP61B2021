using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Week3_Polymorphism.Shapes
{
    public class Circle: Shape
    {
        public double Radius { get; set; }

        public override void Draw(Graphics g, Color c)
        {
            
            g.DrawEllipse(new Pen(c), X, Y, (float)Radius * 2, (float)Radius * 2);
        }

        public override double FindArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double FindPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

    }
}
