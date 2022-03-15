using System;
using System.Collections.Generic;

namespace ProjectPartB.Core.Entities
{
    public class Student : IEntities
    {
        public Student()
        {
            Courses = new HashSet<Course>();
        }
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int TuitionFees { get; set; }

        // Navigation Properties
        public virtual ICollection<Course> Courses { get; set; }
    }
}