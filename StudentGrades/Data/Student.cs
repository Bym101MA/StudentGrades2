namespace StudentGrades.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{LastName} {FirstName}";

        public List<Grade> Grades { get; set; } = new();
    }
}
