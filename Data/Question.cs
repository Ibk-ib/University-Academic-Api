namespace UniversityAcademicApi.Data
{
    public class Question : BaseEntity
    {
        public Guid CourseId { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public string OptionA { get; set; } = string.Empty;

        public string OptionB { get; set; } = string.Empty;

        public string OptionC { get; set; } = string.Empty;

        public string OptionD { get; set; } = string.Empty;

        public string CorrectAnswer { get; set; } = string.Empty;
        public Course Course { get; set; } = null!;
    }
}
