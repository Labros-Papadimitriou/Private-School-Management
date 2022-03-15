using ProjectPartB.Views;

namespace ProjectPartB.Controllers
{
    public class MixedEntitiesController : Controller
    {
        public void ReadAllTrainersPerCourse() => ViewTables.PrintTrainersPerCourse(unitOfWork.Trainers.GetTrainersPerCourse(0, 30));
        public void ReadAllStudentsPerCourse() => ViewTables.PrintStudentsPerCourse(unitOfWork.Students.GetStudentsPerCourse(0, 50));
        public void ReadAllAssignmentsPerCourse() => ViewTables.PrintAssignmentsPerCourse(unitOfWork.Assignments.GetAssignmentsPerCourse(0, 70));
        public void ReadAllAssignmentsPerStudent() => ViewTables.PrintAssignmentsPerStudent(unitOfWork.Assignments.PrintAssignmentsPerStudent(0, 70));
        public void ReadAllStudentsWithMultiCourses() => ViewTables.PrintAStudentWithMultiCourses(unitOfWork.Students.PrintAStudentWithMultiCourses(0, 50));
        public void ReadAllStudentsToReturnAssignments() => ViewTables.PrintStudentsToReturnAssignments(unitOfWork.Students.PrintStudentsToReturnAssignments(0, 50));
        public void MatchTrainersWithCourse()
        {
            var courseId = GetViewPairCoursesTrainers.ChooseCourseToMatch(unitOfWork.Courses.GetAll());
            var trainerId = GetViewPairCoursesTrainers.ChooseTrainersToAddToCourse(unitOfWork.Trainers.GetAll());

            var course = unitOfWork.Courses.SingleOrDefault(c => c.Id == courseId);
            var trainer = unitOfWork.Trainers.SingleOrDefault(t => t.Id == trainerId);

            trainer.Courses.Add(course);
            course.Trainers.Add(trainer);

            unitOfWork.Complete();
        }
        public void MatchStudentsWithCourse()
        {
            var courseId = GetViewPairCoursesStudents.ChooseCourseToMatch(unitOfWork.Courses.GetAll());
            var studentId = GetViewPairCoursesStudents.ChooseStudentsToAddToCourse(unitOfWork.Students.GetAll());

            var course = unitOfWork.Courses.SingleOrDefault(c => c.Id == courseId);
            var student = unitOfWork.Students.SingleOrDefault(s => s.Id == studentId);

            student.Courses.Add(course);
            course.Students.Add(student);

            unitOfWork.Complete();
        }
        public void MatchAssignmentsWithCourse()
        {
            var courseId = GetViewPairCourseAssignments.ChooseCourseToMatch(unitOfWork.Courses.GetAll());
            var assignmentId = GetViewPairCourseAssignments.ChooseAssignmentsToAddToCourse(unitOfWork.Assignments.GetAll());

            var course = unitOfWork.Courses.SingleOrDefault(c => c.Id == courseId);
            var assignment = unitOfWork.Assignments.SingleOrDefault(s => s.Id == assignmentId);

            assignment.Course = course;
            course.Assignments.Add(assignment);

            unitOfWork.Complete();
        }
    }
}
