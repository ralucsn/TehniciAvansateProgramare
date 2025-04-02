namespace WebApplication1.Services.Linq
{
    public static class StudentStorage
    {
        public static List<Student> stUdents = new List<Student>()
        {
            new Student("Tarci", 25, "M", "Info", 1),
            new Student("Adi", 29, "M", "Info", 2),
            new Student("Denisa", 19,"F", "Math", 3),
            new Student("Ana", 21,"F", "Math", 4),
            new Student("Razvan", 23, "M", "English", 5),
            new Student("Catalina", 20, "F", "English", 6),
            new Student("Paul", 27, "M", "Calculus", 7),
            new Student("Elisa", 22, "F", "Calculus", 8),
            new Student("Maria", 18, "F", "Biology", 9),
            new Student("Claudiu", 30, "M", "Biology", 10)
        };
    }
}