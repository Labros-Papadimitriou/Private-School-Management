using ProjectPartB.Controllers;
using ProjectPartB.Core.Entities;
using ProjectPartB.Validations;
using ProjectPartB.Views.ViewMenus;
using System;
using System.Collections.Generic;

namespace ProjectPartB
{
    public class ApplicationMenu : Controller
    {
        private MixedEntitiesController MixedController { get; } = new MixedEntitiesController();
        private CourseController CourseController { get; } = new CourseController();
        private TrainerController TrainerController { get; } = new TrainerController();
        private StudentController StudentController { get; } = new StudentController();
        private AssignmentController AssignmentController { get; } = new AssignmentController();

        public void Run()
        {
            string choice;
            do
            {
                Console.Clear();
                ViewMainMenu.PrintMainMenu();
                choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    case "1": Console.Clear(); PrintSyntheticData(); break;
                    case "2": Console.Clear(); PrintCreationData(); break;
                    case "3": Console.Clear(); PrintUpdateData(); break;
                    case "4": Console.Clear(); PrintDeleteData(); break;
                    default: break;
                }
            } while (choice != "E");
        }

        public void PrintSyntheticData()
        {
            string option;
            do
            {
                ViewInsideMenu.PrintInsideMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose an option from 1 to 10");
                Console.ResetColor();
                option = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (option)
                {
                    case "1": CourseController.ReadAllCourses(); break;
                    case "2": TrainerController.ReadAllTrainers(); break;
                    case "3": StudentController.ReadAllStudents(); break;
                    case "4": AssignmentController.ReadAllAssignments(); break;
                    case "5": MixedController.ReadAllTrainersPerCourse(); break;
                    case "6": MixedController.ReadAllStudentsPerCourse(); break;
                    case "7": MixedController.ReadAllAssignmentsPerCourse(); break;
                    case "8": MixedController.ReadAllAssignmentsPerStudent(); break;
                    case "9": MixedController.ReadAllStudentsWithMultiCourses(); break;
                    case "10": MixedController.ReadAllStudentsToReturnAssignments(); break;
                    case "E": Console.Clear(); break;
                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please Enter a Number from 1 to 10"); Console.ResetColor(); break;
                }
                Console.WriteLine("\n\n");
            } while (option != "E");
        }

        public void PrintCreationData()
        {
            string option;
            do
            {
                ViewCreateMenu.PrintCreationMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose an option from 1 to 7");
                Console.ResetColor();
                option = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (option)
                {
                    case "1": CourseController.CreateCourse(); break;
                    case "2": TrainerController.CreateTrainer(); break;
                    case "3": StudentController.CreateStudent(); break;
                    case "4": AssignmentController.CreateAssignment(); break;
                    case "5": if (Validation.IsCountZero((IEnumerable<IEntities>)unitOfWork.Courses.GetAll(), unitOfWork.Trainers.GetAll())) { MixedController.MatchTrainersWithCourse(); } break;
                    case "6": if (Validation.IsCountZero((IEnumerable<IEntities>)unitOfWork.Courses.GetAll(), unitOfWork.Students.GetAll())) { MixedController.MatchStudentsWithCourse(); } break;
                    case "7": if (Validation.IsCountZero((IEnumerable<IEntities>)unitOfWork.Courses.GetAll(), unitOfWork.Assignments.GetAll())) { MixedController.MatchAssignmentsWithCourse(); } break;
                    case "E": Console.Clear(); break;
                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please Enter a Number from 1 to 7"); Console.ResetColor(); break;
                }
                Console.WriteLine("\n\n");
                Console.Clear();
            } while (option != "E");
        }

        public void PrintDeleteData()
        {
            string option;
            do
            {
                ViewDeleteMenu.PrintDeleteMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose an option from 1 to 4");
                Console.ResetColor();
                option = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (option)
                {
                    case "1": if (Validation.IsCountZero(unitOfWork.Courses.GetAll())) { CourseController.DeleteCourse(); } break;
                    case "2": if (Validation.IsCountZero(unitOfWork.Trainers.GetAll())) { TrainerController.DeleteTrainer(); } break;
                    case "3": if (Validation.IsCountZero(unitOfWork.Students.GetAll())) { StudentController.DeleteStudent(); } break;
                    case "4": if (Validation.IsCountZero(unitOfWork.Assignments.GetAll())) { AssignmentController.DeleteAssignment(); } break;
                    case "E": Console.Clear(); break;
                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please Enter a Number from 1 to 4"); Console.ResetColor(); break;
                }
                Console.WriteLine("\n\n");
                Console.Clear();
            } while (option != "E");
        }

        public void PrintUpdateData()
        {
            string option;
            do
            {
                ViewUpdateMenu.PrintUpdateMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose an option from 1 to 4");
                Console.ResetColor();
                option = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (option)
                {
                    case "1": if (Validation.IsCountZero(unitOfWork.Courses.GetAll())) { CourseController.UpdateCourse(); } break;
                    case "2": if (Validation.IsCountZero(unitOfWork.Trainers.GetAll())) { TrainerController.UpdateTrainer(); } break;
                    case "3": if (Validation.IsCountZero(unitOfWork.Students.GetAll())) { StudentController.UpdateStudent(); } break;
                    case "4": if (Validation.IsCountZero(unitOfWork.Assignments.GetAll())) { AssignmentController.UpdateAssignment(); } break;
                    case "E": Console.Clear(); break;
                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please Enter a Number from 1 to 4"); Console.ResetColor(); break;
                }
                Console.WriteLine("\n\n");
                Console.Clear();
            } while (option != "E");
        }
    }
}
