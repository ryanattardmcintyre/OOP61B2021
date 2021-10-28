using System;
using System.Collections.Generic;
using System.Text;

namespace Week2_ConstructorsAndInheritance
{
    public class Book
    {
        //default constructor
        //1. Constructor must bear the same name of the class
        //2. no return types; not even void

        //constructor is there to create instances BUT also it can be used to run certain type of code at the beginning
        //e.g. initialization code
        public Book(string isbn)
        {
            Isbn = isbn;
            Chapters = new List<string>();
            Tax = 0.18;
        }

        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Isbn { get; set; }
        public double Tax { get; set; }
        protected List<string> Chapters { get; set;}
        //protected: it can only be accessed from the 
        //same class or inherited classes

    }
}
