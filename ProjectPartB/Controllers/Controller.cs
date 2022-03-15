using ProjectPartB.Persistence;
using ProjectPartB.Views.ViewCreateEntities;
using ProjectPartB.Views.ViewDeleteEntities;
using ProjectPartB.Views.ViewPairEntities;
using ProjectPartB.Views.ViewUpdateEntities;

namespace ProjectPartB.Controllers
{
    public class Controller
    {
        protected UnitOfWork unitOfWork { get; } = new UnitOfWork(new MySchoolContext());

        // Create Views
        protected ViewCreateCourse GetViewCreateCourse { get; } = new ViewCreateCourse();
        protected ViewCreateTrainer GetViewCreateTrainer { get; } = new ViewCreateTrainer();
        protected ViewCreateStudent GetViewCreateStudent { get; } = new ViewCreateStudent();
        protected ViewCreateAssignment GetViewCreateAssignment { get; } = new ViewCreateAssignment();

        // Update Views
        protected ViewUpdateCourse GetViewUpdateCourse { get; } = new ViewUpdateCourse();
        protected ViewUpdateTrainer GetViewUpdateTrainer { get; } = new ViewUpdateTrainer();
        protected ViewUpdateStudent GetViewUpdateStudent { get; } = new ViewUpdateStudent();
        protected ViewUpdateAssignment GetViewUpdateAssignment { get; } = new ViewUpdateAssignment();

        // Delete Views 
        protected ViewDeleteCourse GetViewDeleteCourse { get; } = new ViewDeleteCourse();
        protected ViewDeleteTrainer GetViewDeleteTrainer { get; } = new ViewDeleteTrainer();
        protected ViewDeleteStudent GetViewDeleteStudent { get; } = new ViewDeleteStudent();
        protected ViewDeleteAssignment GetViewDeleteAssignment { get; } = new ViewDeleteAssignment();

        // Pair Views
        protected ViewPairCoursesTrainer GetViewPairCoursesTrainers { get; } = new ViewPairCoursesTrainer();
        protected ViewPairCoursesStudent GetViewPairCoursesStudents { get; } = new ViewPairCoursesStudent();
        protected ViewPairCourseAssignment GetViewPairCourseAssignments { get; } = new ViewPairCourseAssignment();

    }
}