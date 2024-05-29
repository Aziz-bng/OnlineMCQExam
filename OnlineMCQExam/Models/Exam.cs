using System.ComponentModel.DataAnnotations;

namespace OnlineMCQExam.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public int CreatedByUserId { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public User CreatedByUser { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<ExamResult> ExamResults { get; set; }
    }
}
