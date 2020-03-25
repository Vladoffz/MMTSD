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
    class AdministrationViewModel : IAdministrationViewModel
    {
        public List<QuestionCategory> difficulties { get; set; } = new List<QuestionCategory>();
        private IAllQuestions allQuestions { get; set; } = new AllQuestions();
        private IEnumerable<IQuestion> _listQuestions;

        public IEnumerable<IQuestion> listQuestions
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
                ((ObservableCollection<Question>)_listQuestions).Add(i as Question);
            }
            foreach (var i in Enum.GetValues(typeof(QuestionCategory)))
            {
                difficulties.Add((QuestionCategory)i);
            }
        }

        public void AddQuestion(IQuestion question)
        {
            allQuestions.AddQA(question as Question);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
