using ProjectPartB.Core.Entities;
using System.Collections.Generic;

namespace ProjectPartB.Core.IRepositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<Course> GetStudentsPerCourse(int pageIndex, int pageSize);

        IEnumerable<Student> PrintAStudentWithMultiCourses(int pageIndex, int pageSize);

        IEnumerable<Assignment> PrintStudentsToReturnAssignments(int pageIndex, int pageSize);

    }
}