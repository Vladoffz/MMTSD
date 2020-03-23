using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMMTSD.Model
{
    [Serializable]
    public sealed class Answer : INotifyPropertyChanged
    {
        private string _Text;
        private bool _IsRight;

        public string Text
        {
            get { return _Text;}
            set
            {
                _Text = value;
                OnPropertyChanged("TEXT");
            }
        }
        public bool IsRight
        {
            get { return _IsRight; }
            set
            {
                _IsRight = value;
                OnPropertyChanged("IsRight");
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
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
