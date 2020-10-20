using MMTSD.DAL.Abstract;
using MMTSD.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MMTSD.DAL.Impl
{
    public class AnswerRepository : IAnswerRepository
    {
        private QAContext context;

        public AnswerRepository(QAContext QAcontext)
        {
            context = QAcontext;
        }
        public void Create(Answer obj)
        {
            context.Answers.Add(obj);
        }

        public void Delete(int id)
        {
            context.Answers.Remove(context.Answers.ToList().Find(x => x.id == id));
        }

        public IEnumerable<Answer> GetAll()
        {
            return context.Answers.ToList();
        }

        public Answer Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Answer obj)
        {
            throw new System.NotImplementedException();
        }
    }
}