using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAL.Entities;
using DAL;
using WpfAppMMTSD.Model;

namespace BLL
{
    public class QuestionReceiving
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        Serialization<List<Question>> serializedList;
        IEnumerable<QuestionDTO> Questions { get; set; } = new List<QuestionDTO>();
        public QuestionReceiving()
        {
            serializedList = new Serialization<List<Question>>(connectionString, null);
        }
        public void AddQA(QuestionDTO question)
        {
            ((List<QuestionDTO>)(Questions)).Add(question);
            List<Question> questions = new Serialization<List<Question>>(connectionString, null).Deserialize();
            List<Question> pleaseHelpMe = new List<Question>();
            foreach (var i in questions)
            {
                Answer[] answers = new Answer[4];
                for (int j = 0; j < 4; j++)
                {
                    answers[j] = new Answer(i.Answers[j].Text, i.Answers[j].IsRight);
                }

                pleaseHelpMe.Add(new Question((DAL.Entities.QuestionCategory) i.Category, answers, i.QuestionText));
            }
            Answer[] answersToAddedQuest = new Answer[4];
            for (int j = 0; j < 4; j++)
            {
                answersToAddedQuest[j] = new Answer(question.Answers[j].Text, question.Answers[j].IsRight);
            }
            pleaseHelpMe.Add(new Question((DAL.Entities.QuestionCategory)question.Category, answersToAddedQuest, question.QuestionText));
            serializedList = new Serialization<List<Question>>(connectionString, pleaseHelpMe);
            File.Delete(connectionString);
            serializedList.Serialize();
        }

        public List<QuestionDTO> GetQA()
        {
            List<Question> quests = serializedList.Deserialize();
            List<QuestionDTO> questsDTO = new List<QuestionDTO>();
            foreach (var i in quests)
            {
                AnswerDTO[] answersDTO = new AnswerDTO[4];
                for (int j = 0; j < 4; j++)
                {
                    answersDTO[j] = new AnswerDTO(i.Answers[j].Text, i.Answers[j].IsRight);
                }
                questsDTO.Add(new QuestionDTO((QuestionCategory)i.Category, answersDTO, i.QuestionText));
            }

            Questions = questsDTO;
            return Questions as List<QuestionDTO>;
        }
    }
}
