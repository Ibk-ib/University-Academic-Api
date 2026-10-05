namespace UniversityAcademicApi.Data
{
    public class ExamAnswer : BaseEntity
    {
        public Guid ExamAttemptId { get; set; }

        public Guid QuestionId { get; set; }

        public string SelectedAnswer { get; set; } = string.Empty;

        public bool IsCorrect { get; set; }
        public ExamAttempt ExamAttempt { get; set; } = null!;
        public Question Question { get; set; } = null!;
    }
}
