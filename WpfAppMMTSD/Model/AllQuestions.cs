using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMMTSD.Model
{ 
    public class AllQuestions : IAllQuestions    //here provided a database work simulation
    {
        private Serialization<List<Question>> serializedList;
        public IEnumerable<IQuestion> Questions { get; set; } = new List<Question>();
        public string connectionString { get; set; }= ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public AllQuestions()
        {
            serializedList = new Serialization<List<Question>>(connectionString, Questions as List<Question>);
        }
        public IEnumerable<IQuestion> GetQA()
        {
            Questions = serializedList.Deserialize();
            return Questions as List<Question>;
        }

        public void AddQA(Question question)
        {
            serializedList = new Serialization<List<Question>>(connectionString, Questions as List<Question>);
            File.Delete(connectionString);
            ((List<Question>)(Questions)).Add(question);
            serializedList.Serialize();
        }
    }
}
