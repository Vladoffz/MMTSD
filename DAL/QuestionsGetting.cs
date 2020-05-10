using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using WpfAppMMTSD.Model;

namespace DAL
{
    public class QuestionsGetting
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public List<Question> GetQuestions()
        {
            Serialization<List<Question>> serialization = new Serialization<List<Question>>(connectionString, null);
            return serialization.Deserialize();
        }

        public void AddQuestion(Question question)
        {
            Serialization<List<Question>> serialization = new Serialization<List<Question>>(connectionString, null);
            List<Question> questions = serialization.Deserialize();
            questions.Add(question);
            File.Delete(connectionString);
            serialization = new Serialization<List<Question>>(connectionString, questions);
        }
    }
}
