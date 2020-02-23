using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProject.Models;
using AppProject.Views;

namespace AppProject.Presenters
{
    public interface IPresenter
    {
        List<Question> Questions { get; set; }
        List<QuestionCategory> Categories { get; set; }
        List<List<string>> GetQuestions();
        List<string> QuestionsText { get; set; }
        List<string> GetAnswers(string quesetionString);

        bool CheckAnswer(string questionString, string anwerString);
        void Update();

    }
}
