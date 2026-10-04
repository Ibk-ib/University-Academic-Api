namespace UniversityAcademicApi.Data
{
    public class Enrollment : BaseEntity
    {
        public Guid StudentId { get; set; }

        public Guid CourseId { get; set; }

        public DateTime EnrollmentDate { get; set; }
        public Student Student { get; set; } = null!;
        public Course Course { get; set; } = null!;
    }
}
