using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public enum QuestionCategory
    {
        Easy, 
        Basic,
        Complicated
    }
    public sealed class QuestionDTO
    {
        private QuestionCategory _category;
        private AnswerDTO[] _answers;
        private string _questionText;
        public QuestionCategory Category
        {
            get { return _category; }
            set
            {
                _category = value;
            }
        }

        public AnswerDTO[] Answers
        {
            get { return _answers; }
            set
            {
                _answers = value;
            }
        }

        public string QuestionText
        {
            get { return _questionText; }
            set
            {
                _questionText = value;
            }
        }

        public QuestionDTO(QuestionCategory Category, AnswerDTO[] Answers, string QuestionText)
        {
            this.Category = Category;
            this.Answers = Answers;
            this.QuestionText = QuestionText;
        }

        public QuestionDTO()
        { }
        public override string ToString()
        {
            return this.QuestionText;
        }
    }
}
