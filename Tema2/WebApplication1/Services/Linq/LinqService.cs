namespace WebApplication1.Services.Linq
{
    public class Student
    {
        public Student(string name, int age, string gender, string subject, int idNumber)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Subject = subject;
            IdNumber = idNumber;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Subject { get; set; }
        public int IdNumber { get; set; }
    }

    public class LinqService : ILinqService
    {
        //am facut o clasa statica pentru StudentStorage, care stocheaza lista de users

        public int CountStudentsOver(int value)
        {
            //Query-expression
            //var query = from student in stUdents
            //            where student.Age >= value
            //                select student;

            //return query.Count();

            //Method-expression 
            return StudentStorage.stUdents.Count(student => student.Age >= value);
        }
    }
}
