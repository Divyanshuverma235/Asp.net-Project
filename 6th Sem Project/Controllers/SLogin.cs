using Microsoft.AspNetCore.Mvc;

namespace _6th_Sem_Project.Controllers
{
    public class SLogin : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }
    }
}
