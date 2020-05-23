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
using MMTSD.Entities;
using MMTSD.BLL.Abstract;
using MMTSD.BLL.Impl;
using MMTSD.Models;

namespace WpfAppMMTSD.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged, IApplicationViewModel
    {
        private IEnumerable<QuestionDTO> _SelectedQuestionsCollection;
        private IEnumerable<AnswerDTO> _SelectedAnswersCollection;
        public IEnumerable<QuestionDTO> SelectedQuestionsInApplication { get;set; }
        public Dictionary<string, AnswerDTO> QuesAnsw { get; set; }

        public IEnumerable<QuestionDTO> SelectedQuestionsCollection
        {
            get { return _SelectedQuestionsCollection; }
            set
            {
                _SelectedQuestionsCollection = value;
                OnPropertyChanged("SelectedQuestionsCollection");
            }
        }
        public IEnumerable<AnswerDTO> SelectedAnswersCollection
        {
            get { return _SelectedAnswersCollection; }
            set
            {
                _SelectedAnswersCollection = value;
                OnPropertyChanged("SelectedAnswersCollection");
            }
        }


        QuestionService service = new QuestionService();
        public IEnumerable<QuestionDTO> Questions { get; set; }
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
            _SelectedQuestionsCollection = new ObservableCollection<QuestionDTO>();
            _SelectedAnswersCollection = new ObservableCollection<AnswerDTO>();
            SelectedQuestionsInApplication = new List<QuestionDTO>();
            QuesAnsw = new Dictionary<string, AnswerDTO>();

            Questions = service.GetAll(); 
            RandomizeQuestions();

            SelectedQuestionString = ((ObservableCollection<QuestionDTO>)_SelectedQuestionsCollection)[0].QuestionText;
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
            var questions = new List<QuestionDTO>();
            foreach (var cat in Categories)
            {
                var list = new List<QuestionDTO>();
                foreach (var que in Questions)
                {
                    if (cat == que.Category)
                    {
                        list.Add((QuestionDTO)que);
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
                    AnswerDTO value = quest.Answers[k];
                    quest.Answers[k] = quest.Answers[n];
                    quest.Answers[n] = value;
                }
            }
            foreach (var i in questions)
            {
                ((ObservableCollection<QuestionDTO>)_SelectedQuestionsCollection).Add(i);
            }
        }

        public void GetAnswers(string questString)
        {
            IEnumerable<AnswerDTO> answers = new ObservableCollection<AnswerDTO>();
            foreach (var i in _SelectedQuestionsCollection)
            {
                if (i.QuestionText == questString)
                {
                    SelectedQuestionString = i.QuestionText;
                    foreach(var j in i.Answers)
                    {
                        ((ObservableCollection<AnswerDTO>)answers).Add(j);
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
                                ((List<QuestionDTO>)SelectedQuestionsInApplication).Add(quest as QuestionDTO);
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
