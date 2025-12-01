using StudentGrades.Data;

namespace StudentGrades.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        // Student
        public int StudentId { get; set; }
        public Student Student { get; set; }

        // Subject
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        // Teacher
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
