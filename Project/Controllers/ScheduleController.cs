using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System.Dynamic;
using System.Linq;

namespace Project.Controllers
{
    public class ScheduleController : Controller
    {

        ProjectFapContext context = new ProjectFapContext();
        public IActionResult Index()
        {
            var dataSchedules =context.ScheduleOfTeachers.ToList();
            var dataSlots = context.Slots.ToList();

            dynamic mymodal = new ExpandoObject();
            mymodal.Schedule = dataSchedules;
            mymodal.Slots = dataSlots;
            return View(mymodal);
        }
    }
}
