using TP4.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace TP4.Data

{
    public class StudentRepository : Repository<StudentModel> ,IStudentRepository
    {
        private readonly UniversityContext _universityContext;
        public StudentRepository(UniversityContext universityContext) : base(universityContext) 
        {
        this._universityContext= universityContext;
    }
        
           public IEnumerable<String> GetAllCourses()

        {
            return _universityContext.Student.Select(s => s.course).Distinct().ToList();
        }
        public IEnumerable<StudentModel> GetStudentsWithSpecificCourse(string course)
        {
           return _universityContext.Student.Where(s => s.course == course);
        }

    }
}
