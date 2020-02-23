using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MMTSD_Models;
//using MMTSD_Views;

namespace MMTSD_Business_Layer
{
    public sealed class Testing
    {
        //public List<Question> Questions = new List<Question>();
        //private List<QuestionCategory> Categories = new List<QuestionCategory>();

        //public Testing()
        //{
        //    var dbAccess = new DBAccess();
        //    Questions = dbAccess.GetQA();

        //    foreach (var i in Enum.GetValues(typeof(QuestionCategory)))
        //    {
        //        Categories.Add((QuestionCategory)i);
        //    }
        //}

        //public List<List<string>> GetQuestions()
        //{
        //    var doubleList = new List<List<string>>();
        //    foreach (var cat in Categories)
        //    {
        //        var list = new List<string>();
        //        foreach (var que in Questions)
        //        {
        //            if (cat == que.Category)
        //            {
        //                list.Add(que.QuestionText);
        //            }
        //        }
        //        doubleList.Add(list);
        //    }

        //    return doubleList;
        //}
        //public List<string> getAnswers(string quesetionString)
        //{
        //    var list = new List<string>();
        //    foreach (var quest in this.Questions)
        //    {
        //        if (quest.QuestionText == quesetionString)
        //        {
        //            foreach (var answ in quest.Answers)
        //            {
        //                list.Add(answ.Text);
        //            }
        //        }
        //    }

        //    return list;
        //}

        //public bool checkAnswer(string questionString, string anwerString)
        //{
        //    foreach (var que in this.Questions)
        //    {
        //        if (questionString == que.QuestionText)
        //        {
        //            foreach (var ans in que.Answers)
        //            {
        //                if (anwerString == ans.Text)
        //                {
        //                    return ans.IsRight;
        //                }
        //            }
        //        }
        //    }

        //    throw new Exception("not found");
        //}
    }
}
