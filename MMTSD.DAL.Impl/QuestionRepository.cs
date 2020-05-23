using MMTSD.Entities;
using MMTSD.DAL.Abstract;
using System.Collections.Generic;

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
            context.Questions.Remove(context.Questions.Find(x => x.id == id));
        }

        public IEnumerable<Question> GetAll()
        {
            return context.Questions;
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