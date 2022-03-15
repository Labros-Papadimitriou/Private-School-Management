using ProjectPartB.Core.Enums;
using System;
using System.Collections.Generic;

namespace ProjectPartB.Core.Entities
{
    public class Course : IEntities
    {
        public Course()
        {
            Trainers = new HashSet<Trainer>();
            Students = new HashSet<Student>();
            Assignments = new HashSet<Assignment>();
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public string Stream { get; set; }

        public CourseType Type { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        // Navigation Properties
        public virtual ICollection<Trainer> Trainers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}