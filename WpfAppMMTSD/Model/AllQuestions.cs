using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMMTSD.Model
{ 
    public class AllQuestions    //here provided a database work simulation
    {

        public AllQuestions()
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        public List<Question> GetQA()
        {
            var Questions = new List<Question>();

            Questions.Add(new Question(QuestionCategory.Basic,
                new Answer[]
                {new Answer("public", false),
                new Answer("internal", true),
                new Answer("private", false),
                new Answer("protected internal", false)}, "Which access level do classes have if the modifier is not specified"));
            Questions.Add(new Question(QuestionCategory.Basic,
                new Answer[]
                {new Answer("IComparable", false),
                    new Answer("IEnumerable", true),
                    new Answer("IDisposable", false),
                    new Answer("а?", false)}, "Which interface is used to iterate elements in foreach loop?"));
            Questions.Add(new Question(QuestionCategory.Basic,
                new Answer[]
                {new Answer("Generative pattern", false),
                    new Answer("Architecture pattern", true),
                    new Answer("Behavior pattern", false),
                    new Answer("Structural pattern", false)}, "What is MVC?"));
            Questions.Add(new Question(QuestionCategory.Easy,
                new Answer[]
                {new Answer("Open()", false),
                    new Answer("Main()", true),
                    new Answer("Create()", false),
                    new Answer("Begin()", false)}, "From what method does any application start?"));
            Questions.Add(new Question(QuestionCategory.Easy,
                new Answer[]
                {new Answer("int", false),
                    new Answer("double", true),
                    new Answer("bool", false),
                    new Answer("DateTime", false)}, "Which data type can we use to specify floating numbers?"));
            Questions.Add(new Question(QuestionCategory.Easy,
                new Answer[]
                {new Answer("Struct", false),
                    new Answer("Object", true),
                    new Answer("Array", false),
                    new Answer("Int32", false)}, "Which type is basic for all types in .NET?"));
            Questions.Add(new Question(QuestionCategory.Complicated,
                new Answer[]
                {new Answer("Text for user", false),
                    new Answer("Assembly metadata", true),
                    new Answer("Garbage after compilation", false),
                    new Answer("Assembly", false)}, "What is Assembly Manifest?"));
            Questions.Add(new Question(QuestionCategory.Complicated,
                new Answer[]
                {new Answer("General are free and private are paid", false),
                    new Answer("Private are in application catalog and general are in GAC", true),
                    new Answer("Private don't exist", false),
                    new Answer("What?", false)}, "What is the difference between private and general assemblies?"));
            Questions.Add(new Question(QuestionCategory.Complicated,
                new Answer[]
                {new Answer("Grand Auto Compiler", false),
                    new Answer("Global Assembly Cache", true),
                    new Answer("Great Automatisation Company", false),
                    new Answer("Garbage After Collection", false)}, "What is GAC"));

            return Questions;
        }
    }
}
