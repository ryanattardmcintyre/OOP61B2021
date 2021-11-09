using System;
using Week5_ClassRelationships.Composition;

namespace Week5_ClassRelationships
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student(new Course());
            
        }
    }
}
