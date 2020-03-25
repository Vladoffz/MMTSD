using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WpfAppMMTSD.Model;

namespace WpfAppMMTSD.ViewModel
{
    public interface IApplicationViewModel
    {
        IEnumerable<IQuestion> SelectedQuestionsInApplication { get; set;}

        Dictionary<string, IAnswer> QuesAnsw { get; set;}

        IEnumerable<IQuestion> SelectedQuestionsCollection { get; set; }

        IEnumerable<IAnswer> SelectedAnswersCollection { get; set; }

        IEnumerable<IQuestion> Questions { get; set; }

        string SelectedQuestionString { get; set; }

        void RandomizeQuestions();

        void GetAnswers(string questString);

        void CheckAllAnswers(string answerString);

        void MoveNext();
    }
}