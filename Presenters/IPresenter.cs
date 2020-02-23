using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Presenters
{
    public interface IPresenter
    {
        List<Question> Questions { get; set; }
        List<QuestionCategory> Categories { get; set; }
        List<List<string>> GetQuestions();

        List<string> GetAnswers(string quesetionString);

        bool CheckAnswer(string questionString, string anwerString);

    }
}
