using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Week3_Polymorphism.Shapes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw(Graphics g, Color c)
        {
            //  Console.WriteLine($"This is a point with ({X},{Y})");

            g.DrawLine(new Pen(c), X, Y, X, Y);
            
        }
    }
}
