namespace WpfAppMMTSD.Model
{
    public interface IQuestion
    {
       QuestionCategory Category { get; set; }

       Answer[] Answers { get; set; }

       string QuestionText { get; set; }
    }
}