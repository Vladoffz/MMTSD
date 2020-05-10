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
        QuestionsGetting getting = new QuestionsGetting();
        public void AddQA(QuestionDTO questionDTO)
        {
            Question question;
            Answer[] answers = new Answer[4];
            for (int i = 0; i < 4; i++)
            {
                answers[i] = new Answer(questionDTO.Answers[i].Text, questionDTO.Answers[i].IsRight);
            }
            question = new Question((DAL.Entities.QuestionCategory)questionDTO.Category, answers, questionDTO.QuestionText);
            getting.AddQuestion(question);
        }

        public List<QuestionDTO> GetQA()
        {
            List<Question> quests = getting.GetQuestions();
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

            return questsDTO;
        }
    }
}
