using System;
using System.Collections.Generic;
using System.Text;

namespace Week1_IntroToOOP
{

    //what is a class?
    //a class is an abstract grouping of a number of characteristics
    //which normally represent a real-life entity
    //a class is a template that defines a group of members
    class Book
    {
        //these are fields:
        //1. fields are composed of (data) type and identifier
        //2. As a matter of good practice we declare fields with low case letters
        //3. fields should be private
        private string name;
        private string author;
        private string category;
        private double price;
        private int yearPublished; //camel case

        //this is a property
        //1. properties are usually composed of type, name, access modifier
        //    get and/or set
        //2. as a matter of good practice we declare properties with first letter
        //    in capital form
        //3. properties should be public
        
        public string Name //Pascal Case
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value.ToUpper(); }
        }

        public string Isbn { get; set; } //shorthand notation to code faster

        //method
        public double GetShelfPrice(double tax)
        {
            return price * (1+tax);
        }





    }
}
