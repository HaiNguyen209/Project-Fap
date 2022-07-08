using Microsoft.AspNetCore.Mvc;
using Project.Model;
using System.Collections.Generic;
using System.Linq;

namespace Project.Controllers
{
    public class AttendenceController : Controller
    {

        ProjectFapContext context = new ProjectFapContext();
        public IActionResult Index(string id)
        {
            var dataClass = context.Grades.Where(cls => cls.Id == id);

            var dataAttendence = (from c in dataClass
                                  join a in context.Attendances on c.Id equals a.ClassId
                                  where a.ClassId == id
                                  select a).ToList();

            return View(dataAttendence);
        }

        public IActionResult Edit(string id)
        {
            var ListAttendance = (from g in context.Grades
                                 join a in context.Attendances on g.Id equals a.ClassId
                                 where g.Id == id
                                 select a).ToList();

            return View(ListAttendance);
        }
        [HttpPost]
        public IActionResult Edit(List<Attendance> ListAttendance)
        {
            try
            {
                for (int i = 0; i < ListAttendance.Count(); i++)
                {
                    context.Attendances.Update(ListAttendance[i]);
                }
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Edit error" + ex.Message);
            }
            return RedirectToAction("Index", new {id = ListAttendance[0].ClassId });
        }
    }
}
