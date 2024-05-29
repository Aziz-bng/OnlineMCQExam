namespace OnlineMCQExam.Models
{
    public class UserAnswer
    {
        public int UserAnswerId { get; set; }
        public int ExamResultId { get; set; }
        public int QuestionId { get; set; }
        public int OptionId { get; set; }

        public ExamResult ExamResult { get; set; }
        public Question Question { get; set; }
        public Option Option { get; set; } = new Option();
    }
}
