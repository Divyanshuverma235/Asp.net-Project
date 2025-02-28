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

        public IActionResult Forgot()
        {
            return View();
        }
        public IActionResult ResendEmail()
        {
            return View();
        }

        public IActionResult ChooseNewPassword()
        {
            return View();
        }

        public IActionResult ResetComplete()
        {
            return View();
        }
        public IActionResult VerifyEmail()
        {
            return View();
        }
    }
}
