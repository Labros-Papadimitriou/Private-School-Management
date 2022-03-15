using ProjectPartB.Core.Entities;

namespace ProjectPartB.HelperClasses.PairEntities
{
    public class SeedPairEntity
    {
        public static void PairCourseTrainer(Course course, Trainer trainer)
        {
            course.Trainers.Add(trainer);
            trainer.Courses.Add(course);
        }

        public static void PairCourseStudent(Course course, Student student)
        {
            course.Students.Add(student);
            student.Courses.Add(course);
        }

        public static void PairCourseAssignment(Course course, Assignment assignment)
        {
            course.Assignments.Add(assignment);
            assignment.Course = course;
        }
    }
}
