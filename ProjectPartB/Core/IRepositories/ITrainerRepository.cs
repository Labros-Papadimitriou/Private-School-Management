using ProjectPartB.Core.Entities;
using System.Collections.Generic;

namespace ProjectPartB.Core.IRepositories
{
    public interface ITrainerRepository : IRepository<Trainer>
    {
        IEnumerable<Course> GetTrainersPerCourse(int pageIndex, int pageSize);
    }
}