using Microsoft.AspNetCore.Mvc;
using University.Models;
namespace University.Controllers
{
    public class StudentController : Controller
    {
        private static List<StudentViewModel> students = new List<StudentViewModel>();

        public IActionResult Index()
        {
            return View(students);
        }
        public IActionResult Create()
        {
            var studVm = new StudentViewModel();
            return View(studVm);
        }
        public IActionResult CreateStudent(StudentViewModel studentViewModel) 
        {
            students.Add(studentViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
