using Microsoft.AspNetCore.Mvc;

namespace _6th_Sem_Project.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
