using Microsoft.AspNetCore.Mvc;
using Project.Model;
using System.Linq;

namespace Project.Controllers
{
    public class GradeController : Controller
    {
        public IActionResult Index()
        {
            ProjectFapContext context = new ProjectFapContext();
            var data = context.Grades.ToList();

            return View(data);
        }
    }
}
