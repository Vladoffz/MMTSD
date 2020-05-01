using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Serializable]
    public sealed class Answer
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

        public Answer(string Text, bool IsRight)
        {
            this._Text = Text;
            this._IsRight = IsRight;
        }

        public Answer()
        { }
        public override string ToString()
        {
            return this.Text;
        }
    }
}
