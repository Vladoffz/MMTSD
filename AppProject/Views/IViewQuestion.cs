using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProject.Views
{
    interface IViewQuestion
    {
        string questionString { get; set; }
        List<string> answerStrings { get; set; }
    }
}
