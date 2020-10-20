using MMTSD.Entities;
using MMTSD.Models;
using System.Collections.Generic;

namespace WpfAppMMTSD.ViewModel
{
    public interface IAdministrationViewModel
    {
        List<QuestionCategory> difficulties { get; set; }

        IEnumerable<QuestionDTO> listQuestions { get; set; }

        void AddQuestion(QuestionDTO question);

    }
}