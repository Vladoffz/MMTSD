using MMTSD.BLL.Abstract;
using MMTSD.DAL.Impl;
using MMTSD.Models;
using System.Collections.Generic;
using System.Linq;

namespace MMTSD.BLL.Impl
{
    public class QuestionService : IQuestionService
    {
        QuestionMapper mapper = new QuestionMapper();
        UnitOfWork unitOfWork = new UnitOfWork();

        public void Create(QuestionDTO obj)
        {
            unitOfWork.Questions.Create(mapper.QuestionDTOToQuestion(obj));
        }

        public void Delete(int id)
        {
            unitOfWork.Questions.Delete(id);
        }

        public IEnumerable<QuestionDTO> GetAll()
        {
            List<QuestionDTO> list = new List<QuestionDTO>();
            foreach (var i in unitOfWork.Questions.GetAll().ToList())
            {
                list.Add(mapper.QuestionToQuestionDTO(i));
            }

            return list;

        }

        public QuestionDTO Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(QuestionDTO obj)
        {
            throw new System.NotImplementedException();
        }
    }
}