using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace WpfAppMMTSD.Model
{ 
    public class AllQuestions : IAllQuestions    //here provided a database work simulation
    {
        private QuestionReceiving receiving = new QuestionReceiving();
        public IEnumerable<IQuestion> Questions { get; set; } = new List<Question>();
        public IEnumerable<IQuestion> GetQA()
        {
            List<Question> questions = new List<Question>();
            foreach (var i in receiving.GetQA())
            {
                Answer[] answers = new Answer[4];
                for (int j = 0; j < i.Answers.Length; j++)
                {
                    answers[j] = new Answer(i.Answers[j].Text, i.Answers[j].IsRight);
                }
                questions.Add(new Question((QuestionCategory)i.Category, answers, i.QuestionText));
            }

            Questions = questions;
            return questions;
        }

        public void AddQA(Question question)
        {
            AnswerDTO[] answersDTO = new AnswerDTO[4];
            for (int i = 0; i < 4; i++)
            {
                answersDTO[i] = new AnswerDTO(question.Answers[i].Text, question.Answers[i].IsRight);
            }

            QuestionDTO questDTO = new QuestionDTO((BLL.QuestionCategory) question.Category, answersDTO,
                question.QuestionText);
            receiving.AddQA(questDTO);
        }
    }
}
