using System.Linq;
using MMTSD.DAL.Impl;
using MMTSD.Entities;
using MMTSD.Models;

namespace MMTSD.BLL.Impl
{
    public class AnswerMapper
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public AnswerDTO AnswerToAnswerDTO(Answer answer)
        {
            return new AnswerDTO{id=answer.id, IsRight = answer.IsRight, Text = answer.Text};
        }

        public Answer AnswerDTOToAnswer(AnswerDTO answerDTO)
        {
            return unitOfWork.Answers.GetAll().ToList().Find(x => x.id == answerDTO.id);
        }
    }
}