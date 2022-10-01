namespace MMTSD.Models
{
    public class AnswerDTO
    {
        public int id { get; set; }
        public string Text { get; set; }
        public bool IsRight { get; set; }
        public int Number { get; set; }
        public override string ToString()
        {
            return this.Text;
        }
    }
}
