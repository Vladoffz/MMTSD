using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MMTSD.Entities;
using MMTSD.BLL.Abstract;
using MMTSD.BLL.Impl;
using MMTSD.Models;

namespace WpfAppMMTSD.ViewModel
{
    public interface IApplicationViewModel
    {
        IEnumerable<QuestionDTO> SelectedQuestionsInApplication { get; set;}

        Dictionary<string, AnswerDTO> QuesAnsw { get; set;}

        IEnumerable<QuestionDTO> SelectedQuestionsCollection { get; set; }

        IEnumerable<AnswerDTO> SelectedAnswersCollection { get; set; }

        IEnumerable<QuestionDTO> Questions { get; set; }

        string SelectedQuestionString { get; set; }

        void RandomizeQuestions();

        void GetAnswers(string questString);

        void CheckAllAnswers(string answerString);

        void MoveNext();
    }
}