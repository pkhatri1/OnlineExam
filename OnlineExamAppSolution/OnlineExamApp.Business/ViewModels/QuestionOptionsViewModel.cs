using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineExamApp.Model;
using OnlineExamApp.Core;
using System.Runtime.Serialization;

namespace OnlineExamApp.ViewModel
{
    [DataContract]
    public class QuestionOptionsViewModel : IQuestionOptionsViewModel
    {
        IQuestionViewModel _question;
        List<IOptionViewModel> _options;
        bool _isMultiChoice = false;

        [DataMember]
        public IQuestionViewModel Question
        {
            get { return _question; }
            set { _question = value; }
        }

        [DataMember]
        public List<IOptionViewModel> Options
        {
            get { return _options; }
            set { _options = value; }
        }

        [DataMember]
        public bool IsMultiChoice
        {
            get { return _isMultiChoice; }
            set { _isMultiChoice = value; }
        }
    }
}