using System;
using System.Collections.Generic;
using System.Text;
using Week3_Polymorphism.Shapes;

namespace Week5_ClassRelationships.Aggregation
{

    //relationship between Calculator class and Shape class is aggregation
    //aggregation when you make reference to another class only to use it not to store it within the parent class
    class Calculator
    {
        public double Add(double num1, double num2) { return num1 + num2; }

        public double CalculateArea(Shape shape)
        {
            return shape.FindArea();
        }
        


    }


     


}
