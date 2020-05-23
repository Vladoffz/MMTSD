using System.Linq;
using MMTSD.DAL.Impl;
using MMTSD.Entities;
using MMTSD.Models;

namespace MMTSD.BLL.Impl
{
    public class QuestionMapper
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        public QuestionDTO QuestionToQuestionDTO(Question question)
        {
            QuestionDTO questionDTO = new QuestionDTO();
            questionDTO.id = question.id;
            questionDTO.QuestionText = question.QuestionText;
            questionDTO.Category = question.Category;
            questionDTO.Answers = new AnswerDTO[question.Answers.Length];
            AnswerMapper mapper = new AnswerMapper();
            for (int i = 0; i < question.Answers.Length; i++)
            {
                questionDTO.Answers[i] = mapper.AnswerToAnswerDTO(question.Answers[i]);
            }

            return questionDTO;
        }

        public Question QuestionDTOToQuestion(QuestionDTO questionDTO)
        {
            return unitOfWork.Questions.GetAll().ToList().Find(x => x.id == questionDTO.id);
        }
    }
}