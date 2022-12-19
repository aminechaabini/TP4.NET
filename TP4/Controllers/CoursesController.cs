using Microsoft.AspNetCore.Mvc;
using TP4.Data;
using TP4.Models;

namespace TP4.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            UniversityContext universityContext= UniversityContext.Instantiate_UniversityContext();
            StudentRepository repo= new StudentRepository(universityContext);
            List<String> courses = (List<String>) repo.GetAllCourses();
            return View(courses);
        }

    }
}
