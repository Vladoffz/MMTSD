using System.Collections.Generic;

namespace MMTSD.Entities
{
    public class DbInitializer
    {
        QAContext context = new QAContext();
        Serialization<List<Question>> serializationQuestions = new Serialization<List<Question>>(@"serializedList.xml", null);
        Serialization<Answer> serializationAnswers = new Serialization<Answer>(@"serializedList.xml", null);

        public void Initialize()
        {
            List<Question> deserialized = serializationQuestions.Deserialize();
            for (int i = 0; i < deserialized.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    deserialized[i].Answers[j].Question = deserialized[i];
                }
            }
            foreach (var i in deserialized)
            {
                context.Questions.Add(i);
            }

            context.SaveChanges();

            foreach (var i in deserialized)
            {
                foreach (var j in i.Answers)
                {
                    context.Answers.Add(j);
                }
            }

            context.SaveChanges();
        }
    }
}