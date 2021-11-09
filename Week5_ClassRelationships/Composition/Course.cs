using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_ClassRelationships.Composition
{
    class Course
    {
        public string Title { get; set; }
        public int Years { get; set; }
        public int Level { get; set; }

    }

    class Student
    {
        public Course CourseFollowing { get; set; }

        public Student(Course c) //composition: forces a object to exist only if the other object exists
        {
            CourseFollowing = c;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdCardNo { get; set; }


    }
}
