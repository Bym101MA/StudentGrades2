namespace StudentGrades.Data
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{LastName} {FirstName}";
        public string Position { get; set; }

        public List<Grade> Grades { get; set; } = new();
    }
}
