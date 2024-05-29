using System.ComponentModel.DataAnnotations;

namespace OnlineMCQExam.Models
{
    public class Option
    {
        public int OptionId { get; set; }
        public int QuestionId { get; set; }
        [Required]
        [MaxLength(500)]
        public string OptionText { get; set; }
        [Required]
        public bool IsCorrect { get; set; }

        public Question Question { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; } = new List<UserAnswer>();
    }
}
