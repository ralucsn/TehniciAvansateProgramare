using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.Linq;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLinqController : ControllerBase
    {
        private readonly ILinqService _linqService;

        public TestLinqController(ILinqService linqService)
        {
            _linqService = linqService;
        }

        [HttpGet("count-students-over")]
        public int CountStudentsOver(int age)
        {
            return _linqService.CountStudentsOver(age);
        }

        [HttpGet("linq-where")]
        public List<Student> FilterStudents(int age)
        {
            return StudentStorage.stUdents.Where(u => u.Age == age).ToList();
        }

        [HttpGet("linq-string")]
        public IEnumerable<string> GetStudentsByGender(string gender)
        {
            var stud1 = StudentStorage.stUdents;
            var stud2 = StudentStorage.stUdents;

            var students = 
                from student1 in stud1
                join student2 in stud2 on student1.Age equals student2.Age
                where student1.Gender == gender && student2.Gender == gender && student1.IdNumber != student2.IdNumber
                select $"{student1.Name} and {student2.Name} have the same age: {student1.Age}";

            return students;
        }
    }
}
