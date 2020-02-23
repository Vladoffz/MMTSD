using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProject.Models;
using AppProject.Views;

namespace AppProject.Presenters
{
    public sealed class TestingPresenter : IPresenter
    {
        public List<Question> Questions { get; set;}
        public List<QuestionCategory> Categories { get; set; }
        public List<string> QuestionsText { get; set; }
        private IViewMain view;
        private int count = 0;
        private bool b;
        public TestingPresenter(IViewMain view)
        {
            Categories = new List<QuestionCategory>();
            QuestionsText = new List<string>();
            this.view = view;
            var dbAccess = new DBAccess();
            Questions = dbAccess.GetQA();
            foreach (var i in Enum.GetValues(typeof(QuestionCategory)))
            {
                Categories.Add((QuestionCategory)i);
            }
            foreach (var q in this.GetQuestions()[count])
            {
                view.questionsText.Add(q);
            }

        }

        public void Update()
        {
            if (count < GetQuestions().Count-1 && !b)
            {
                count++;
                view.questionsText.Clear();
                foreach (var q in this.GetQuestions()[count])
                {
                    view.questionsText.Add(q);
                }
            }
            else if(count >= 0)
            {
                b = true;
                QuestionForm form = new QuestionForm(GetAnswers(QuestionsText[QuestionsText.Count- count-1]),
                     QuestionsText[QuestionsText.Count - count-1], (MainForm)view);
                form.Show();

                count--;
            }
            else
            {
                ((MainForm)view).Close();
            }

        }
        public List<List<string>> GetQuestions()
        {
            var doubleList = new List<List<string>>();
            foreach (var cat in Categories)
            {
                var list = new List<string>();
                foreach (var que in Questions)
                {
                    if (cat == que.Category)
                    {
                        list.Add(que.QuestionText);
                    }
                }
                doubleList.Add(list);
            }

            return doubleList;
        }
        public List<string> GetAnswers(string quesetionString)
        {
            var list = new List<string>();
            foreach (var quest in this.Questions)
            {
                if (quest.QuestionText == quesetionString)
                {
                    foreach (var answ in quest.Answers)
                    {
                        list.Add(answ.Text);
                    }
                }
            }

            return list;
        }

        public bool CheckAnswer(string questionString, string anwerString)
        {
            foreach (var que in this.Questions)
            {
                if (questionString == que.QuestionText)
                {
                    foreach (var ans in que.Answers)
                    {
                        if (anwerString == ans.Text)
                        {
                            return ans.IsRight;
                        }
                    }
                }
            }

            throw new Exception("not found");
        }
    }
}
