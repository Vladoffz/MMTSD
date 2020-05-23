using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MMTSD.Entities;
using MMTSD.BLL.Abstract;
using MMTSD.BLL.Impl;
using MMTSD.Models;

namespace WpfAppMMTSD.ViewModel
{
    public interface IAdministrationViewModel
    {
        List<QuestionCategory> difficulties { get; set; }

        IEnumerable<QuestionDTO> listQuestions { get; set; }

        void AddQuestion(QuestionDTO question);

    }
}