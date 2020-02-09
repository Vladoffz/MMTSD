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
    }
}
