using System.Data.Entity;

namespace MMTSD.Entities
{
    public class QAContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public QAContext() : base("DbConnection")
        {
            //Serialization<List<Question>> serializationQuestions = new Serialization<List<Question>>(@"serializedList.xml", null);
            //Questions = serializationQuestions.Deserialize();
            //Serialization<Answer> serializationAnswers = new Serialization<Answer>(@"serializedList.xml", null);
        }
    }
}