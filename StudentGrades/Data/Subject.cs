namespace StudentGrades.Data
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Grade> Grades { get; set; } = new();
    }
}
