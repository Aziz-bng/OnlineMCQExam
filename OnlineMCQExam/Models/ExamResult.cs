using System.ComponentModel.DataAnnotations;

namespace OnlineMCQExam.Models
{
    public class ExamResult
    {
        public int ExamResultId { get; set; }
        public int UserId { get; set; }
        public int ExamId { get; set; }
        public int Score { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AttemptDate { get; set; }

        public User User { get; set; }
        public Exam Exam { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
