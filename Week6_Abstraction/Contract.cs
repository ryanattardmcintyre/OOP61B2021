using System;
using System.Collections.Generic;
using System.Text;

namespace Week6_Abstraction
{
    /*
     * Characteristics of abstract classes
     * 
     * 1. cannot be instantiated; they have to be inherited if you would like make use of their members
     * 2. they allow the developer to postpone the implementation of any members (referring to properties and methods)
     * 3. they allow the side-by-side existence of implemented methods and abstract methods
     * 4. HOWEVER, they can be used as a normal class, so it can be inherited, you can declare anything in them properties, fields, methods, enums...
     * 
     * 
     * Characteristics of interfaces
     * 
     * Same as abstract classes but they do not allow anything to be implemented. You are forced to inherit them
     * 
     * 
     */

    public abstract class Contract
    {
        public DateTime StartDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public string Lessor { get; set; }
        public string Lessee { get; set; }

        public abstract double CalculateTaxFromRent();
        public abstract double CalculateNetBalance();

        public double CalculateRentalDurationInDays()
        {
            return TerminationDate.Subtract(StartDate).TotalDays;
        }

    }
}
