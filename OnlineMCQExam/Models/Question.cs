using System.ComponentModel.DataAnnotations;

namespace OnlineMCQExam.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int ExamId { get; set; }
        [Required]
        [MaxLength(1000)]
        public string QuestionText { get; set; }
        [Required]
        [MaxLength(50)]
        public string QuestionType { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
        public int CreatedByUserId { get; set; }

        public Exam Exam { get; set; }
        public User CreatedByUser { get; set; }
        public ICollection<Option> Options { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; } = new HashSet<UserAnswer>();
    }
}
