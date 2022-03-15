using ProjectPartB.Views;
using System.Linq;

namespace ProjectPartB.Controllers
{
    public class StudentController : Controller
    {
        public void ReadAllStudents()
        {
            ViewTables.PrintStudents(unitOfWork.Students.GetAll());
        }

        public void CreateStudent()
        {
            unitOfWork.Students.Add(GetViewCreateStudent.PrintCreateNewStudent());
            unitOfWork.Complete();
        }

        public void DeleteStudent()
        {
            var studentId = GetViewDeleteStudent.ChooseStudentToDelete(unitOfWork.Students.GetAll());
            var student = unitOfWork.Students.Find(x => x.Id == studentId).First();
            student.Courses.Clear();
            unitOfWork.Students.Remove(student);
            unitOfWork.Complete();
        }

        public void UpdateStudent()
        {
            var studentId = GetViewUpdateStudent.ChooseStudentToUpdate(unitOfWork.Students.GetAll());
            var student = unitOfWork.Students.Find(x => x.Id == studentId).First();
            var studentNew = GetViewCreateStudent.PrintCreateNewStudent();
            student.FirstName = studentNew.FirstName;
            student.LastName = studentNew.LastName;
            student.DateOfBirth = studentNew.DateOfBirth;
            student.TuitionFees = studentNew.TuitionFees;
            unitOfWork.Students.ModifyEntity(student);
            unitOfWork.Complete();
        }
    }
}