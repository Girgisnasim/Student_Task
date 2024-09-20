using Microsoft.AspNetCore.Mvc;
using Student_Task.ModelView;
using Student_Task.Repository;

namespace Student_Task.Controllers
{
    public class StudentController : Controller
    {
        private Istudentservice Istudentservice { get; set; }
        public StudentController(Istudentservice studentservice)
        {
            Istudentservice = studentservice;
        }
        [HttpGet]
        public IActionResult form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult form(studentMV studentMV)
        {
            if (studentMV != null)
            {

                if (ModelState.IsValid)
                {
                    Istudentservice.Add_New_Student(studentMV);
                }
            }
            return View();
        }
    }
}
