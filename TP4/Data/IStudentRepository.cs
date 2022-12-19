using TP4.Models;

namespace TP4.Data
{
    public interface IStudentRepository: IRepository<StudentModel>
    {
        public IEnumerable<String> GetAllCourses();
        public IEnumerable<StudentModel> GetStudentsWithSpecificCourse(string course);
    }
}
