using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Views;

namespace Presenters
{
    public sealed class TestingPresenter : IPresenter
    {
        public List<Question> Questions { get; set;}
        public List<QuestionCategory> Categories { get; set; } = new List<QuestionCategory>();
        private IViewMain view;

        public TestingPresenter(IViewMain view)
        {
            this.view = view;
            var dbAccess = new DBAccess();
            Questions = dbAccess.GetQA();
            foreach (var i in Enum.GetValues(typeof(QuestionCategory)))
            {
                Categories.Add((QuestionCategory)i);
            }
            foreach (var q in Questions)
            {
                view.questionsText.Add(q.QuestionText);
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
