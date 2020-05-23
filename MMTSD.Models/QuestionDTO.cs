using MMTSD.Entities;

namespace MMTSD.Models
{
    public class QuestionDTO
    {
        public int id { get; set; }
        public QuestionCategory Category { get; set; }
        public AnswerDTO[] Answers { get; set; }
        public string QuestionText { get; set; }
        public override string ToString()
        {
            return this.QuestionText;
        }
    }
}