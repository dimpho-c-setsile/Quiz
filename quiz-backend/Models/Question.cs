using System.ComponentModel.DataAnnotations;
namespace Quiz_app.Models
{
    public class Question
    {
        [Key]
        public int QnId { get; set;  }
        public required string QuestionInwords { get; set; }
        public string? pictureNmae { get; set; }
        public required string  Option1 { get; set; }
        public required string Option2 { get; set; }
        public required string Option3 { get; set; }
        public required string Option4 { get; set; }
        public required string Answer { get; set; }

    }
}
