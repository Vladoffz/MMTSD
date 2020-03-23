using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMMTSD.Model
{ 
    public class AllQuestions    //here provided a database work simulation
    {
        private Serialization<List<Question>> serializedList;
        List<Question> Questions = new List<Question>();
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public AllQuestions()
        {
            serializedList = new Serialization<List<Question>>(connectionString, Questions);
        }
        public List<Question> GetQA()
        {
            Questions = serializedList.Deserialize();

            return Questions;
        }

        public void AddQA(Question question)
        {
            serializedList = new Serialization<List<Question>>(connectionString, Questions);
            File.Delete(connectionString);
            Questions.Add(question);
            serializedList.Serialize();
        }
    }
}
