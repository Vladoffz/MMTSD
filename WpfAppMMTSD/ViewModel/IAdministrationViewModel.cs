using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfAppMMTSD.Model;

namespace WpfAppMMTSD.ViewModel
{
    public interface IAdministrationViewModel
    {
        List<QuestionCategory> difficulties { get; set; }

        IEnumerable<IQuestion> listQuestions { get; set; }

        void AddQuestion(IQuestion question);

    }
}