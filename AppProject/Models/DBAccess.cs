using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProject.Models
{ 
    public class DBAccess    //here provided a database work simulation
    {

        public DBAccess()
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
                new Answer("protected internal", false)}, "Який рівень доступа мають класи, якщо модифікатор не вказаний?"));
            Questions.Add(new Question(QuestionCategory.Basic,
                new Answer[]
                {new Answer("IComparable", false),
                    new Answer("IEnumerable", true),
                    new Answer("IDisposable", false),
                    new Answer("а?", false)}, "Який інтерфейс використовують для перебору елементів в циклі foreach?"));
            Questions.Add(new Question(QuestionCategory.Basic,
                new Answer[]
                {new Answer("Породжуючий патерн", false),
                    new Answer("Архітектурний патерн", true),
                    new Answer("Патерн поведінки", false),
                    new Answer("Структурний патерн", false)}, "Що таке MVC?"));
            Questions.Add(new Question(QuestionCategory.Easy,
                new Answer[]
                {new Answer("Open()", false),
                    new Answer("Main()", true),
                    new Answer("Create()", false),
                    new Answer("Begin()", false)}, "З якого методу починається виконання будь-якої програми?"));
            Questions.Add(new Question(QuestionCategory.Easy,
                new Answer[]
                {new Answer("int", false),
                    new Answer("double", true),
                    new Answer("bool", false),
                    new Answer("DateTime", false)}, "Який тип даних можна використати для задання чисел з плаваючою комою?"));
            Questions.Add(new Question(QuestionCategory.Easy,
                new Answer[]
                {new Answer("Struct", false),
                    new Answer("Object", true),
                    new Answer("Array", false),
                    new Answer("Int32", false)}, "Від якого класу наслідуються всі типи в .NET?"));
            Questions.Add(new Question(QuestionCategory.Complicated,
                new Answer[]
                {new Answer("Текст для користувача", false),
                    new Answer("Метадані збірки", true),
                    new Answer("Сміття після компіляції", false),
                    new Answer("Збірка", false)}, "Що таке Assembly Manifest?"));
            Questions.Add(new Question(QuestionCategory.Complicated,
                new Answer[]
                {new Answer("Загальні безкоштовні, а приватні платні", false),
                    new Answer("Приватні знаходяться в каталозі програми, а загальні в GAC", true),
                    new Answer("Приватних не існує", false),
                    new Answer("Хто я?", false)}, "В чому різниця між приватними та загальними збірками?"));
            Questions.Add(new Question(QuestionCategory.Complicated,
                new Answer[]
                {new Answer("Grand Auto Compiler", false),
                    new Answer("Global Assembly Cache", true),
                    new Answer("Great Automatisation Company", false),
                    new Answer("Garbage After Collection", false)}, "Що таке GAC"));

            return Questions;
        }
    }
}
