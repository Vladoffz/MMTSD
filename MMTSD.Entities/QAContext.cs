using System.Collections.Generic;

namespace MMTSD.Entities
{
    public class QAContext
    {
        public List<Question> Questions { get; set; }
        public List<Answer> Answers { get; set; }

        public QAContext()
        {
            Serialization<List<Question>> serializationQuestions = new Serialization<List<Question>>(@"serializedList.xml", null);
            Questions = serializationQuestions.Deserialize();
            Serialization<Answer> serializationAnswers = new Serialization<Answer>(@"serializedList.xml", null);
        }
    }
}