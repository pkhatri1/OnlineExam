using OnlineExamApp.Core;
using OnlineExamApp.Model;
using OnlineExamAppService.ViewModel;
//using OnlineExamApp.ViewModel;
//using OnlineExamAppService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OnlineExamAppService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class OnlineExamAppService : IOnlineExamAppService
    {
        //List<QuestionOptions> _questionBank;
        //List<QuestionAnswers> _questionAnswers;
        //List<UserResponse> _examResponse;
        ////CandidateViewModel _candidate;

        public QuestionOptionsViewModel GetQuestion(int? questionId)
        {
            //Initialize();
            //return GetQuestionViewModel(questionId);

            //ExamManager examManager = new ExamManager();

            QuestionOptionsViewModel questionOptionsViewModel = new QuestionOptionsViewModel();

            List<IOptionViewModel> list = new List<IOptionViewModel>();

            list.Add(new OptionViewModel() { ID = 1, Text = "Option1" });
            list.Add(new OptionViewModel() { ID = 2, Text = "Option2" });
            list.Add(new OptionViewModel() { ID = 3, Text = "Option3" });
            list.Add(new OptionViewModel() { ID = 4, Text = "Option4" });

            questionOptionsViewModel.Question = new QuestionViewModel() { ID = 1, Text = "First Question" };
            questionOptionsViewModel.Options = list;

            //return examManager.GetQuestion(questionId);
            return questionOptionsViewModel;
        }

        
        ////public CompositeType GetDataUsingDataContract(CompositeType composite)
        ////{
        ////    if (composite == null)
        ////    {
        ////        throw new ArgumentNullException("composite");
        ////    }
        ////    if (composite.BoolValue)
        ////    {
        ////        composite.StringValue += "Suffix";
        ////    }
        ////    return composite;
        ////}

        //QuestionOptions GetQuestionModel(int? questionId)
        //{
        //    int iterator = 0;
        //    QuestionOptions questionOptions = null;

        //    if (questionId != null && questionId > 0)
        //    {
        //        foreach (QuestionOptions questionOption in _questionBank)
        //        {
        //            if (questionOption.Question.ID == questionId)
        //            {
        //                iterator++;
        //                break;
        //            }
        //            iterator++;
        //        }
        //    }

        //    if (iterator > _questionBank.Count - 1)
        //        questionOptions = _questionBank[_questionBank.Count - 1];
        //    else
        //        if (_questionBank[iterator] != null)
        //            questionOptions = _questionBank[iterator];
        //        else
        //            questionOptions = _questionBank[_questionBank.Count - 1];

        //    return questionOptions;
        //}

        //QuestionOptionsViewModel GetQuestionViewModel(int? questionId)
        //{
        //    QuestionOptions questionOptions = GetQuestionModel(questionId);

        //    QuestionOptionsViewModel questionOptionsViewModel = null;
        //    List<OptionViewModel> questionOptionsViewModelList = new List<OptionViewModel>();

        //    questionOptionsViewModel = new QuestionOptionsViewModel();
        //    questionOptionsViewModel.Question = new QuestionViewModel() { ID = questionOptions.Question.ID, Text = questionOptions.Question.Text };

        //    foreach (Option option in questionOptions.Options)
        //    {
        //        questionOptionsViewModelList.Add(new OptionViewModel() { ID = option.ID, Text = option.Text });
        //    }

        //    questionOptionsViewModel.Options = questionOptionsViewModelList;
        //    questionOptionsViewModel.IsMultiChoice = questionOptions.IsMultiChoice;

        //    return questionOptionsViewModel;
        //}

        //void Initialize()
        //{
        //    _questionBank = new List<QuestionOptions>();
        //    _questionAnswers = new List<QuestionAnswers>();

        //    Question question = new Question();

        //    question.ID = 1;
        //    question.Text = "Where are routes registered in ASP.NET MVC Application?";

        //    List<Option> options = new List<Option>();
        //    options.Add(new Option() { ID = 1, Text = "Controller" });
        //    options.Add(new Option() { ID = 2, Text = "Web.Config" });
        //    options.Add(new Option() { ID = 3, Text = "Global.asax" });
        //    options.Add(new Option() { ID = 4, Text = "All of the Above" });

        //    QuestionOptions questionOptions = new QuestionOptions();
        //    questionOptions.Question = question;
        //    questionOptions.Options = options;

        //    List<Option> answers = new List<Option>();
        //    answers.Add(new Option() { ID = 3, Text = "Global.asax" });

        //    QuestionAnswers questionAnswers = new QuestionAnswers();
        //    questionAnswers.Question = question;
        //    questionAnswers.Answers = answers;

        //    _questionBank.Add(questionOptions);
        //    _questionAnswers.Add(questionAnswers);


        //    question = new Question();

        //    question.ID = 2;
        //    question.Text = "What are digital signatures used for? (Choose all that apply.)";

        //    options = new List<Option>();
        //    options.Add(new Option() { ID = 1, Text = "Encryption" });
        //    options.Add(new Option() { ID = 2, Text = "Authorization" });
        //    options.Add(new Option() { ID = 3, Text = "Nonrepudiation" });
        //    options.Add(new Option() { ID = 4, Text = "Authentication" });

        //    questionOptions = new QuestionOptions();
        //    questionOptions.Question = question;
        //    questionOptions.Options = options;
        //    questionOptions.IsMultiChoice = true;

        //    answers = new List<Option>();
        //    answers.Add(new Option() { ID = 1, Text = "Encryption" });
        //    answers.Add(new Option() { ID = 2, Text = "Authorization" });
        //    answers.Add(new Option() { ID = 3, Text = "Nonrepudiation" });
        //    answers.Add(new Option() { ID = 4, Text = "Authentication" });

        //    questionAnswers = new QuestionAnswers();
        //    questionAnswers.Question = question;
        //    questionAnswers.Answers = answers;

        //    _questionBank.Add(questionOptions);
        //    _questionAnswers.Add(questionAnswers);


        //    question = new Question();

        //    question.ID = 3;
        //    question.Text = "You are creating an ASP.NET MVC 4 web application that will be accessed by a large number of traditional consumers. If you need to be able to access state information on the client side in JavaScript/jQuery, where can you store it? (Choose all that apply.)";

        //    options = new List<Option>();
        //    options.Add(new Option() { ID = 1, Text = "LocalStorage" });
        //    options.Add(new Option() { ID = 2, Text = "QueryString" });
        //    options.Add(new Option() { ID = 3, Text = "ViewState" });
        //    options.Add(new Option() { ID = 4, Text = "Cookies" });
        //    options.Add(new Option() { ID = 5, Text = "All of the Above" });

        //    questionOptions = new QuestionOptions();
        //    questionOptions.Question = question;
        //    questionOptions.Options = options;

        //    questionOptions.IsMultiChoice = true;

        //    answers = new List<Option>();
        //    answers.Add(new Option() { ID = 1, Text = "LocalStorage" });
        //    answers.Add(new Option() { ID = 4, Text = "Cookies" });

        //    questionAnswers = new QuestionAnswers();
        //    questionAnswers.Question = question;
        //    questionAnswers.Answers = answers;

        //    _questionBank.Add(questionOptions);
        //    _questionAnswers.Add(questionAnswers);

        //    question = new Question();

        //    question.ID = 4;
        //    question.Text = "Which of the following feature is a part of HTML 5?";

        //    options = new List<Option>();
        //    options.Add(new Option() { ID = 1, Text = "Canvas" });
        //    options.Add(new Option() { ID = 2, Text = "Audio And Video" });
        //    options.Add(new Option() { ID = 3, Text = "GeoLocation" });
        //    options.Add(new Option() { ID = 4, Text = "All of the Above" });

        //    questionOptions = new QuestionOptions();
        //    questionOptions.Question = question;
        //    questionOptions.Options = options;

        //    answers = new List<Option>();
        //    answers.Add(new Option() { ID = 4, Text = "All of the Above" });

        //    questionAnswers = new QuestionAnswers();
        //    questionAnswers.Question = question;
        //    questionAnswers.Answers = answers;

        //    _questionBank.Add(questionOptions);
        //    _questionAnswers.Add(questionAnswers);

        //    question = new Question();

        //    question.ID = 5;
        //    question.Text = "Which of the following browser supports HTML5 in its latest version?";

        //    options = new List<Option>();
        //    options.Add(new Option() { ID = 1, Text = "Mozilla Firefox" });
        //    options.Add(new Option() { ID = 2, Text = "Opera" });
        //    options.Add(new Option() { ID = 3, Text = "Both Of the Above" });
        //    options.Add(new Option() { ID = 4, Text = "None of the Above" });

        //    questionOptions = new QuestionOptions();
        //    questionOptions.Question = question;
        //    questionOptions.Options = options;

        //    answers = new List<Option>();
        //    answers.Add(new Option() { ID = 4, Text = "None of the Above" });

        //    questionAnswers = new QuestionAnswers();
        //    questionAnswers.Question = question;
        //    questionAnswers.Answers = answers;

        //    _questionBank.Add(questionOptions);
        //    _questionAnswers.Add(questionAnswers);
        //}
    }
}
