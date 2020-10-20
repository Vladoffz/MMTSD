using MMTSD.DAL.Abstract;
using MMTSD.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MMTSD.DAL.Impl
{
    public class QuestionRepository : IQuestionRepository
    {
        private QAContext context;

        public QuestionRepository(QAContext QAcontext)
        {
            context = QAcontext;
        }
        public void Create(Question obj)
        {
            context.Questions.Add(obj);
        }

        public void Delete(int id)
        {
            context.Questions.Remove(context.Questions.ToList().Find(x => x.id == id));
        }

        public IEnumerable<Question> GetAll()
        {
            List<Answer> answers = context.Answers.ToList();
            List<Question> deserialized = new List<Question>(context.Questions.ToList());
            for (int i = 0; i < deserialized.Count; i++)
            {
                deserialized[i].Answers = new Answer[4];
                for (int j = 0, k = i * 4; j < 4; j++, k++)
                {
                    deserialized[i].Answers[j] = answers[k];
                }
            }

            return deserialized;
            //return context.Questions.Include(x=>x.Answers == context.Answers.ToArray()).ToList();
        }

        public Question Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Question obj)
        {
            throw new System.NotImplementedException();
        }
    }
}