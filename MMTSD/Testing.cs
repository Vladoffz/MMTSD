using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMTSD
{
    sealed class Testing
    {
        public List<Question> Questions = new List<Question>();

        public bool CheckOut(Question question, Answer answer)
        {

            if (Questions.Contains(question))
            {
                if (question.Answers.Contains(answer))
                {
                    return answer.IsRight;
                }
                else
                {
                    throw new Exception("There is no such answer in this question");
                }
            }
            else
            {
                throw new Exception("There is no such question in the question list");
            }
        }

        public Testing()
        {
            Questions.Add(new Question(QuestionCategory.Basic, 
                new Answer[]
                {new Answer("aaaa?", false), 
                new Answer("bbbb?", true),
                new Answer("ccccc?", false),
                new Answer("dddd", false)}, "a noo da basic"));
            Questions.Add(new Question(QuestionCategory.Basic,
                new Answer[]
                {new Answer("aaaa?", false),
                    new Answer("bbbb?", true),
                    new Answer("ccccc?", false),
                    new Answer("dddd", false)}, "prikol basic"));
            Questions.Add(new Question(QuestionCategory.Complicated,
                new Answer[]
                {new Answer("aaaa?", false),
                    new Answer("bbbb?", true),
                    new Answer("ccccc?", false),
                    new Answer("dddd", false)}, "hi girls complicated"));
            Questions.Add(new Question(QuestionCategory.Easy,
                new Answer[]
                {new Answer("aaaa?", false),
                    new Answer("bbbb?", true),
                    new Answer("ccccc?", false),
                    new Answer("dddd", false)}, "hahaha easy"));
        }
    }
}
