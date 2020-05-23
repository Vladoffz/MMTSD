using MMTSD.BLL.Abstract;
using MMTSD.Models;
using System.Collections.Generic;
using MMTSD.DAL.Abstract;
using MMTSD.DAL.Impl;
using MMTSD.Entities;

namespace MMTSD.BLL.Impl
{
    public class AnswerService : IAnswerService
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        AnswerMapper mapper = new AnswerMapper();
        public void Create(AnswerDTO obj)
        {
            unitOfWork.Answers.Create(mapper.AnswerDTOToAnswer(obj));
        }

        public void Delete(int id)
        {
            unitOfWork.Answers.Delete(id);
        }

        public IEnumerable<AnswerDTO> GetAll()
        {
            List<AnswerDTO> list = new List<AnswerDTO>();
            foreach (var i in unitOfWork.Answers.GetAll())
            {
                list.Add(mapper.AnswerToAnswerDTO(i));
            }

            return list;
        }

        public AnswerDTO Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(AnswerDTO obj)
        {
            throw new System.NotImplementedException();
        }
    }
}