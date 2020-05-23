namespace MMTSD.Entities
{
    public enum QuestionCategory
    {
        Easy, 
        Basic,
        Complicated
    }
    public sealed class Question
    {
        public int id { get; set; }
        public QuestionCategory Category { get; set; }
        public Answer[] Answers { get; set; }
        public string QuestionText { get; set; }
    }
}
