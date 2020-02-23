using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public sealed class Answer
    {
        public string Text { get; }
        public bool IsRight { get; }

        public Answer(string Text, bool IsRight)
        {
            this.Text = Text;
            this.IsRight = IsRight;
        }
    }
}
