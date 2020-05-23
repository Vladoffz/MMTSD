using MMTSD.Entities;

namespace MMTSD.DAL.Impl
{
    public class UnitOfWork
    {
        QAContext context = new QAContext();
        private AnswerRepository answerRepository;
        private QuestionRepository questionRepository;

        public AnswerRepository Answers
        {
            get
            {
                if (answerRepository == null)
                {
                    answerRepository = new AnswerRepository(context);
                }

                return answerRepository;
            }
        }

        public QuestionRepository Questions
        {
            get
            {
                if (questionRepository == null)
                {
                    questionRepository = new QuestionRepository(context);
                }

                return questionRepository;
            }
        }

        public void Save()
        {
            //context.SaveChanges();
        }
    }
}