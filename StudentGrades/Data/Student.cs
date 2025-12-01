using StudentGrades.Models;

namespace StudentGrades.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }

        public string FullName => $"{LastName} {FirstName} {Patronymic}";

        public List<Grade> Grades { get; set; } = new();
    }
}