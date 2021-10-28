using System;
using System.Collections.Generic;
using System.Text;

namespace Week2_ConstructorsAndInheritance
{
    //inheritance means:
    //we are getting the (public & protected) members of the base class

    public class Journal: Book //Journal is inheriting from Book; Book is the base class
    {
        public Journal(string isbn)
            :base(isbn) //calling the constructor of the base class
        {
            
        }

        public int Month { get; set; }


    }
}
