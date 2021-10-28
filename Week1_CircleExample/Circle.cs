using System;
using System.Collections.Generic;
using System.Text;

namespace Week1_CircleExample
{
    class Circle //class names should be in Pascal Case
    {
        //private double radius;
       // public double Radius { get { return radius; } set => radius = value; } //lambda


        public double Radius { get; set; }

        public double FindArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double FindPermiter()
        {
            return Math.PI * 2 * Radius; 
        }
    }
}
