﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMTSD
{
    enum QuestionCategory
    {
        Easy, 
        Basic,
        Complicated
    }
    sealed class Question
    {
        public QuestionCategory Category { get; }
        public Answer[] Answers { get; }
        public string QuestionText { get; }

        public Question(QuestionCategory Category, Answer[] Answers, string QuestionText)
        {
            this.Category = Category;
            this.Answers = Answers;
            this.QuestionText = QuestionText;
        }
    }
}
