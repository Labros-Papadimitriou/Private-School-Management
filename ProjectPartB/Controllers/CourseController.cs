using ProjectPartB.Views;
using System.Linq;

namespace ProjectPartB.Controllers
{
    public class CourseController : Controller
    {
        public void ReadAllCourses()
        {
            ViewTables.PrintCourses(unitOfWork.Courses.GetAll());
        }

        public void CreateCourse()
        {
            unitOfWork.Courses.Add(GetViewCreateCourse.PrintCreateNewCourse());
            unitOfWork.Complete();
        }

        public void DeleteCourse()
        {
            var courseId = GetViewDeleteCourse.ChooseCourseToDelete(unitOfWork.Courses.GetAll());
            var course = unitOfWork.Courses.Find(x => x.Id == courseId).First();
            course.Trainers.Clear();
            course.Students.Clear();
            course.Assignments.Clear();
            unitOfWork.Courses.Remove(course);
            unitOfWork.Complete();
        }

        public void UpdateCourse()
        {
            var courseId = GetViewUpdateCourse.ChooseCourseToUpdate(unitOfWork.Courses.GetAll());
            var course = unitOfWork.Courses.Find(x => x.Id == courseId).First();
            var courseNew = GetViewCreateCourse.PrintCreateNewCourse();
            course.Title = courseNew.Title;
            course.Stream = courseNew.Stream;
            course.Type = courseNew.Type;
            course.StartDate = courseNew.StartDate;
            course.EndDate = courseNew.EndDate;
            unitOfWork.Courses.ModifyEntity(course);
            unitOfWork.Complete();
        }
    }
}