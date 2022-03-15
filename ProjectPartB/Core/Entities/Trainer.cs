using System.Collections.Generic;

namespace ProjectPartB.Core.Entities
{
    public class Trainer : IEntities
    {
        public Trainer()
        {
            Courses = new HashSet<Course>();
        }
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Subject { get; set; }

        // Navigation Properties
        public virtual ICollection<Course> Courses { get; set; }
    }
}