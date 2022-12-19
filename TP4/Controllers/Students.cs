using Microsoft.AspNetCore.Mvc;
using TP4.Data;
using TP4.Models;

namespace TP4.Controllers
{
    public class Students : Controller
    {
        public IActionResult Index(string course)
        {
            UniversityContext universityContext = UniversityContext.Instantiate_UniversityContext();
            StudentRepository repo = new StudentRepository(universityContext);
            List<StudentModel> students = (List<StudentModel>) repo.GetStudentsWithSpecificCourse(string course);
            return View(students);
        }
    }
}
