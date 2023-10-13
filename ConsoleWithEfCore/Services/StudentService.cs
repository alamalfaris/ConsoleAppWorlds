using ConsoleWithEfCore.Database;
using ConsoleWithEfCore.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleWithEfCore.Services
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;

        public StudentService(ServiceCollection services)
        {
            _context = new DataContext(services);
        }

        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }
    }
}
