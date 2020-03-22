using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfAppMMTSD.Model;

namespace WpfAppMMTSD.ViewModel
{
    class TestViewModel : INotifyPropertyChanged
    {
        private Answer _answer = new Answer("aaa?",true);

        public Answer answer
        {
            get { return _answer; }

            set
            {
                _answer = value;
                OnPropertyChanged("AnSwEr");
            }
        }

        public void Update()
        {
            answer.Text += "x";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
