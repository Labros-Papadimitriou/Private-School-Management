using System;

namespace ProjectPartB.Core.Entities
{
    public class Assignment : IEntities
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime SubDateTime { get; set; }

        public int OralMark { get; set; }

        public int TotalMark { get; set; }

        // Navigation Property
        public Course Course { get; set; }
    }
}