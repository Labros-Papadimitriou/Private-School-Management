using ProjectPartB.Views;
using System.Linq;

namespace ProjectPartB.Controllers
{
    public class AssignmentController : Controller
    {
        public void ReadAllAssignments()
        {
            ViewTables.PrintAssignments(unitOfWork.Assignments.GetAll());
        }
        
        public void CreateAssignment()
        {
            unitOfWork.Assignments.Add(GetViewCreateAssignment.PrintCreateNewAssignment());
            unitOfWork.Complete();
        }

        public void DeleteAssignment()
        {
            var assignmentId = GetViewDeleteAssignment.ChooseAssignmentToDelete(unitOfWork.Assignments.GetAll());
            var assignment = unitOfWork.Assignments.Find(x => x.Id == assignmentId).First();
            assignment.Course = null;
            unitOfWork.Assignments.Remove(assignment);
            unitOfWork.Complete();
        }

        public void UpdateAssignment()
        {
            var assignmentId = GetViewUpdateAssignment.ChooseAssignmentToUpdate(unitOfWork.Assignments.GetAll());
            var assignment = unitOfWork.Assignments.Find(x => x.Id == assignmentId).First();
            var assignmentNew = GetViewCreateAssignment.PrintCreateNewAssignment();
            assignment.Title = assignmentNew.Title;
            assignment.Description = assignmentNew.Description;
            assignment.SubDateTime = assignmentNew.SubDateTime;
            assignment.OralMark = assignmentNew.OralMark;
            assignment.TotalMark = assignmentNew.TotalMark;
            unitOfWork.Assignments.ModifyEntity(assignment);
            unitOfWork.Complete();
        }
    }
}