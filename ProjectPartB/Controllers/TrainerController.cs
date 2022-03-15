using ProjectPartB.Views;
using System.Linq;

namespace ProjectPartB.Controllers
{
    public class TrainerController : Controller
    {
        public void ReadAllTrainers()
        {
            ViewTables.PrintTrainers(unitOfWork.Trainers.GetAll());
        }

        public void CreateTrainer()
        {
            unitOfWork.Trainers.Add(GetViewCreateTrainer.PrintCreateNewTrainer());
            unitOfWork.Complete();
        }

        public void DeleteTrainer()
        {
            var trainerId = GetViewDeleteTrainer.ChooseTrainerToDelete(unitOfWork.Trainers.GetAll());
            var trainer = unitOfWork.Trainers.Find(x => x.Id == trainerId).First();
            trainer.Courses.Clear();
            unitOfWork.Trainers.Remove(trainer);
            unitOfWork.Complete();
        }

        public void UpdateTrainer()
        {
            var trainerId = GetViewUpdateTrainer.ChooseTrainerToUpdate(unitOfWork.Trainers.GetAll());
            var trainer = unitOfWork.Trainers.Find(x => x.Id == trainerId).First();
            var trainerNew = GetViewCreateTrainer.PrintCreateNewTrainer();
            trainer.FirstName = trainerNew.FirstName;
            trainer.LastName = trainerNew.LastName;
            trainer.Subject = trainerNew.Subject;
            unitOfWork.Trainers.ModifyEntity(trainer);
            unitOfWork.Complete();
        }
    }
}