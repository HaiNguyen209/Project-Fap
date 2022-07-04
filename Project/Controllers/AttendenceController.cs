using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project.Controllers
{
    public class AttendenceController : Controller
    {

       ProjectDemoContext context = new ProjectDemoContext();
        public IActionResult Index()
        {
         //   ViewBag.Attendence = context.Attendances.ToList();
            return View(context.Attendances.ToList());
        }
        public IActionResult Edit()
        {
            var ListAttendance = context.Attendances.ToList();
            return View(ListAttendance);
        }
        [HttpPost]
        public IActionResult Edit(List<Attendance> ListAttendance)
        {
            //foreach (Attendance attendance in ListAttendance)
            //{
            //    context.Attendances.Update(attendance);
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
            //}
                return RedirectToAction("Index");

        }
    }
}
