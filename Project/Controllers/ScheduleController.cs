using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
