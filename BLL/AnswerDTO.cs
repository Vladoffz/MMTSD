using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public sealed class AnswerDTO
    {
        private string _Text;
        private bool _IsRight;

        public string Text
        {
            get { return _Text;}
            set
            {
                _Text = value;
            }
        }
        public bool IsRight
        {
            get { return _IsRight; }
            set
            {
                _IsRight = value;
            }
        }

        public AnswerDTO(string Text, bool IsRight)
        {
            this._Text = Text;
            this._IsRight = IsRight;
        }

        public AnswerDTO()
        { }
        public override string ToString()
        {
            return this.Text;
        }
    }
}
