using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamAppService.ViewModel
{
    public class QuestionResultViewModel
    {
        string _question;
        bool _result;
        
        public string Question
        {
            get { return _question; }
            set { _question = value; }
        }

        public bool Result
        {
            get { return _result; }
            set { _result = value; }
        }
    }
}
