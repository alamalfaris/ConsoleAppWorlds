using ConsoleWithEfCore.Entities;

namespace ConsoleWithEfCore.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
    }
}
