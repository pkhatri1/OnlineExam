using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamApp.Model
{
    public class Candidate
    {
        int _id = 0;
        string _name = string.Empty;

        public int ID
        { 
            get { return _id; }
            set { _id = value; } 
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    public class Question
    {
        int _id = 0;
        string _text = string.Empty;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
    }

    public class Option
    {
        int _id = 0;
        string _text = string.Empty;
        bool _isSelected = false;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
    }

    public class QuestionOptions
    {
        Question _question;
        List<Option> _options;
        bool _isMultiChoice = false;

        public Question Question
        {
            get { return _question; }
            set { _question = value; }
        }

        public List<Option> Options
        {
            get { return _options; }
            set { _options = value; }
        }

        public bool IsMultiChoice
        {
            get { return _isMultiChoice; }
            set { _isMultiChoice = value; }
        }
    }

    public class QuestionAnswers
    {
        Question _question;
        List<Option> _answers;

        public Question Question
        {
            get { return _question; }
            set { _question = value; }
        }
        
        public List<Option> Answers
        {
            get { return _answers; }
            set { _answers = value; }
        }
    }

    public class QuestionBank
    {
        List<QuestionOptions> _questions;

        public List<QuestionOptions> Questions
        {
            get { return _questions; }
            set { _questions = value; }
        }
    }

    public class UserResponse
    {
        int _questionId = 0;
        Candidate _candidate;
        List<int> _answers;

        public int QuestionID
        {
            get { return _questionId; }
            set { _questionId = value; }
        }

        public Candidate Candidate
        {
            get { return _candidate; }
            set { _candidate = value; }
        }

        public List<int> Answers
        {
            get { return _answers; }
            set { _answers = value; }
        }
    }

    public class ExamResult
    {
        Candidate _candidate;
        List<QuestionResult> _result = new List<QuestionResult>();

        public Candidate Candidate
        {
            get { return _candidate; }
            set { _candidate = value; }
        }

        public List<QuestionResult> Result
        {
            get { return _result; }
            set { _result = value; }
        }
    }

    public class QuestionResult
    {
        Question _question;
        bool _result;
        string _userSelection = string.Empty;
        string _correctAnswer = string.Empty;

        public Question Question
        {
            get { return _question; }
            set { _question = value; }
        }

        public bool Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public string UserSelection
        {
            get { return _userSelection; }
            set { _userSelection = value; }
        }

        public string CorrectAnswer
        {
            get { return _correctAnswer; }
            set { _correctAnswer = value; }
        }
    }

    public class ExamEvaluator 
    {
        UserResponse _userResponse;
        QuestionAnswers _questionAnswers;

        public UserResponse UserResponse
        {
            get { return _userResponse; }
            set { _userResponse = value; }
        }

        public QuestionAnswers QuestionAnswers
        {
            get { return _questionAnswers; }
            set { _questionAnswers = value; }
        }

        public QuestionResult Evaluate()
        {
            bool result = false;

            QuestionResult questionResult = new QuestionResult();
            questionResult.Question = QuestionAnswers.Question;

            if (UserResponse.Answers.Count == QuestionAnswers.Answers.Count)
            {
                foreach (Option option in QuestionAnswers.Answers)
                {
                    result = UserResponse.Answers.Exists(ur => ur == option.ID);

                    if (!result)
                        break;  
                }                
            }

            questionResult.Result = result;
            return questionResult;
        }
    }

    public class Evaluator
    {
        int _id;
        string _name = string.Empty;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}