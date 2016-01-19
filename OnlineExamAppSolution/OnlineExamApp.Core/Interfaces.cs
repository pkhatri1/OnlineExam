using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamApp.Core
{
    public interface IQuestionOptionsViewModel
    {
        IQuestionViewModel Question { get; set; }
        List<IOptionViewModel> Options {get;set;}
        bool IsMultiChoice { get; set; }       
    }

    public interface IQuestionViewModel
    {
        int ID {get;set;}
        string Text { get; set; }        
    }

    public interface IOptionViewModel
    {
        int ID {get;set;}
        string Text {get;set;}
        bool IsSelected {get;set;}
        string Selected { get; set; }        
    }
}
