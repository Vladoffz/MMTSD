using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfAppMMTSD.Model;
using WpfAppMMTSD.View;

namespace WpfAppMMTSD.ViewModel
{
    class AdministrationViewModel
    {
        public List<QuestionCategory> difficulties = new List<QuestionCategory>();
        AllQuestions allQuestions = new AllQuestions();
        private ObservableCollection<Question> _listQuestions;

        public ObservableCollection<Question> listQuestions
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
            _listQuestions = new ObservableCollection<Question>();
            foreach (var i in allQuestions.GetQA())
            {
                _listQuestions.Add(i);
            }
            foreach (var i in Enum.GetValues(typeof(QuestionCategory)))
            {
                difficulties.Add((QuestionCategory)i);
            }
        }

        public void AddQuestion(Question question)
        {
            allQuestions.AddQA(question);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
