using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MMTSD.Entities;
using MMTSD.BLL.Abstract;
using MMTSD.BLL.Impl;
using MMTSD.Models;
using WpfAppMMTSD.View;

namespace WpfAppMMTSD.ViewModel
{
    class AdministrationViewModel : IAdministrationViewModel
    {
        public List<QuestionCategory> difficulties { get; set; } = new List<QuestionCategory>();
        private QuestionService service = new QuestionService();
        private IEnumerable<QuestionDTO> _listQuestions;

        public IEnumerable<QuestionDTO> listQuestions
        {
            get { return _listQuestions; }
            set
            {
                _listQuestions = value;
                OnPropertyChanged("listQuestions");
            }
        }

        public AdministrationViewModel()
        {
            _listQuestions = new ObservableCollection<QuestionDTO>();
            foreach (var i in service.GetAll())
            {
                ((ObservableCollection<QuestionDTO>)_listQuestions).Add(i as QuestionDTO);
            }
            foreach (var i in Enum.GetValues(typeof(QuestionCategory)))
            {
                difficulties.Add((QuestionCategory)i);
            }
        }

        public void AddQuestion(QuestionDTO question)
        {
            service.Create(question as QuestionDTO);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
