namespace UniversityAcademicApi.Data
{
    public class Course : BaseEntity
    {
        public string CourseCode { get; set; } = string.Empty;

        public string CourseTitle { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int CreditUnit { get; set; }

        public string Department { get; set; } = string.Empty;

        public int Level { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Question> Questions { get; set; } = new List<Question>();
        public ICollection<ExamAttempt> ExamAttempts { get; set; } = new List<ExamAttempt>();
        public ICollection<Result> Results { get; set; } = new List<Result>();
    }
}
