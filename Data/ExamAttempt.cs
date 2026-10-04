namespace UniversityAcademicApi.Data
{
    public class ExamAttempt : BaseEntity
    {
            public Guid StudentId { get; set; }

            public Guid CourseId { get; set; }

            public DateTime StartedAt { get; set; }

            public DateTime? SubmittedAt { get; set; }

            public decimal Score { get; set; }

            public string Grade { get; set; } = string.Empty;

            public decimal GradePoint { get; set; }
    }
}
