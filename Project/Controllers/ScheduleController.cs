using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Modelss;
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
            var dataGrade = context.Grades.ToList();

            dynamic mymodal = new ExpandoObject();
            mymodal.Schedule = dataSchedules;
            mymodal.Slots = dataSlots;
            mymodal.Grade = dataGrade;
            return View(mymodal);
        }
        public IActionResult TimetableOfStudent()
        {
            var username = HttpContext.Session.GetString("username");
            var dataSchedulesOfStudent = (from s1 in context.ScheduleOfStudents
                                          join s2 in context.Students on s1.StudentId equals s2.Id
                              where s2.UserName.Equals(username)
                              select s1).ToList();

            var dataSchedules = context.ScheduleOfStudents.ToList();
            var dataSlots = context.Slots.ToList();
            var dataGrade = context.Grades.ToList();

            dynamic mymodal = new ExpandoObject();
            mymodal.Schedule = dataSchedulesOfStudent;
            mymodal.Slots = dataSlots;
            mymodal.Grade = dataGrade;
            return View(mymodal);
        }
    }
}
