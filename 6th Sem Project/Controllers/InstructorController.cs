using Microsoft.AspNetCore.Mvc;

namespace _6th_Sem_Project.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult InsIndex()
        {
            return View();
        }
        public IActionResult CourseInformation()
        {
            return View();
        }

        public IActionResult CourseBuilder()
        {
            return View();
        }
    }
}
