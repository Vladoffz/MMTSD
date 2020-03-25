using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMMTSD.Model
{
    [Serializable]
    public enum QuestionCategory
    {
        Easy, 
        Basic,
        Complicated
    }
    [Serializable]
    public sealed class Question : INotifyPropertyChanged, IQuestion
    {
        private QuestionCategory _category;
        private Answer[] _answers;
        private string _questionText;
        public QuestionCategory Category
        {
            get { return _category; }
            set
            {
                _category = value;
                OnPropertyChanged("Category");
            }
        }

        public Answer[] Answers
        {
            get { return _answers; }
            set
            {
                _answers = value;
                OnPropertyChanged("Answers");
            }
        }

        public string QuestionText
        {
            get { return _questionText; }
            set
            {
                _questionText = value;
                OnPropertyChanged("QuestionText");
            }
        }

        public Question(QuestionCategory Category, Answer[] Answers, string QuestionText)
        {
            this.Category = Category;
            this.Answers = Answers;
            this.QuestionText = QuestionText;
        }

        public Question()
        { }
        public override string ToString()
        {
            return this.QuestionText;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
