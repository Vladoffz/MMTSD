using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WpfAppMMTSD.View;
using WpfAppMMTSD.Model;

namespace WpfAppMMTSD.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private IEnumerable<IQuestion> _SelectedQuestionsCollection;
        private IEnumerable<IAnswer> _SelectedAnswersCollection;
        public IEnumerable<IQuestion> SelectedQuestionsInApplication;
        public Dictionary<string, IAnswer> QuesAnsw;

        public IEnumerable<IQuestion> SelectedQuestionsCollection
        {
            get { return _SelectedQuestionsCollection; }
            set
            {
                _SelectedQuestionsCollection = value;
                OnPropertyChanged("SelectedQuestionsCollection");
            }
        }
        public IEnumerable<IAnswer> SelectedAnswersCollection
        {
            get { return _SelectedAnswersCollection; }
            set
            {
                _SelectedAnswersCollection = value;
                OnPropertyChanged("SelectedAnswersCollection");
            }
        }


        IAllQuestions quest = new AllQuestions();
        public IEnumerable<IQuestion> Questions { get; set; }
        private string _c = "shto";
        public string SelectedQuestionString
        {
            get { return _c; }
            set
            {
                _c = value;
                OnPropertyChanged("SelectedQuestionString");
            }
        }

        public ApplicationViewModel()
        {
            _SelectedQuestionsCollection = new ObservableCollection<Question>();
            _SelectedAnswersCollection = new ObservableCollection<Answer>();
            SelectedQuestionsInApplication = new List<Question>();
            QuesAnsw = new Dictionary<string, IAnswer>();

            Questions = quest.GetQA(); 
            RandomizeQuestions();

            SelectedQuestionString = ((ObservableCollection<Question>)_SelectedQuestionsCollection)[0].QuestionText;
            GetAnswers(SelectedQuestionString);
        }
        
        public void RandomizeQuestions()
        {
            Random rnd = new Random();
            List<QuestionCategory> Categories = new List<QuestionCategory>();
            foreach (var i in Enum.GetValues(typeof(QuestionCategory)))
            {
                Categories.Add((QuestionCategory)i);
            }
            var questions = new List<Question>();
            foreach (var cat in Categories)
            {
                var list = new List<Question>();
                foreach (var que in Questions)
                {
                    if (cat == que.Category)
                    {
                        list.Add((Question)que);
                    }
                }
                questions.Add(list[rnd.Next(list.Count)]);
            }

            foreach (var quest in questions)
            {
                int n = quest.Answers.Length;
                while (n > 1)
                {
                    n--;
                    int k = rnd.Next(n + 1);
                    Answer value = quest.Answers[k];
                    quest.Answers[k] = quest.Answers[n];
                    quest.Answers[n] = value;
                }
            }
            foreach (var i in questions)
            {
                ((ObservableCollection<Question>)_SelectedQuestionsCollection).Add(i);
            }
        }

        public void GetAnswers(string questString)
        {
            IEnumerable<IAnswer> answers = new ObservableCollection<Answer>();
            foreach (var i in _SelectedQuestionsCollection)
            {
                if (i.QuestionText == questString)
                {
                    SelectedQuestionString = i.QuestionText;
                    foreach(var j in i.Answers)
                    {
                        ((ObservableCollection<Answer>)answers).Add(j);
                    }
                }
            }

            SelectedAnswersCollection = answers;
        }

        public void CheckAllAnswers(string answerString)
        {
            try
            {
                foreach (var quest in _SelectedQuestionsCollection)
                {
                    foreach (var answ in quest.Answers)
                    {
                        if (answ.Text == answerString)
                        {
                            if (!SelectedQuestionsInApplication.Contains(quest))
                            {
                                ((List<Question>)SelectedQuestionsInApplication).Add(quest as Question);
                                QuesAnsw.Add(quest.QuestionText,
                                    _SelectedAnswersCollection.Single(x => x.Text == answerString));
                            }
                            else if (SelectedQuestionsInApplication.Contains(quest) && answ.Text != null)
                            {
                                QuesAnsw[quest.QuestionText] =
                                    _SelectedAnswersCollection.Single(x => x.Text == answerString);
                            }
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                throw new Exception("You haven't chosen the answer!");
            }
        }

        public void MoveNext()
        {
            foreach (var i in _SelectedQuestionsCollection)
            {
                if (!QuesAnsw.ContainsKey(i.QuestionText))
                {
                    GetAnswers(i.QuestionText);
                    break;
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
