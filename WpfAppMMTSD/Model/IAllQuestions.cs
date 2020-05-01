using System.Collections.Generic;

namespace WpfAppMMTSD.Model
{
    public interface IAllQuestions
    {
        IEnumerable<IQuestion> Questions { get; set; }

        IEnumerable<IQuestion> GetQA();

        void AddQA(Question question);
    }
}