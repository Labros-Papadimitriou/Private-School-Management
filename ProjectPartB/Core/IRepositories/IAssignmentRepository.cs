using ProjectPartB.Core.Entities;
using System.Collections.Generic;

namespace ProjectPartB.Core.IRepositories
{
    public interface IAssignmentRepository : IRepository<Assignment>
    {
        IEnumerable<Course> GetAssignmentsPerCourse(int pageIndex, int pageSize);

        IEnumerable<Student> PrintAssignmentsPerStudent(int pageIndex, int pageSize);
    }
}