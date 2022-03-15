using ProjectPartB.Core.IRepositories;
using System;

namespace ProjectPartB.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        ITrainerRepository Trainers { get; }
        IStudentRepository Students { get; }
        IAssignmentRepository Assignments { get; }
        int Complete();
    }
}