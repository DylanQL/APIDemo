namespace APIDemo.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool Active { get; set; }

        // Navigation property
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
