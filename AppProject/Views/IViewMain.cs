using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProject.Views
{
    public interface IViewMain
    {
        string chosenQuestionText { get; set;}
        List<string> questionsText { get; set; }

        event Action chosenQestionEvent;
    }
}
