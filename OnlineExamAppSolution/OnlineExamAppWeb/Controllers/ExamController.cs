using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineExamApp.ViewModel;
using OnlineExamApp.Core;

namespace OnlineExamApp.Controllers
{
    public class ExamController : Controller
    {
        Dictionary<int, List<int>> userResponse;        

        [HttpPost]
        public ActionResult StartTest(CandidateViewModel candidate)
        {
            ExamManager examManager = Session["ExamManager"] as ExamManager;

            if (examManager == null)
                examManager = new ExamManager();

            examManager.Candidate = candidate;
            Session["ExamManager"] = examManager;
                        
            return this.RedirectToAction("NextQuestion");
        }

        public ActionResult NextQuestion(int? questionId)
        {
            //ExamManager examManager = Session["ExamManager"] as ExamManager;
            //ViewBag.UserName = examManager.Candidate.Name;

            //IQuestionOptionsViewModel questionOptionsViewModel = examManager.GetQuestion(questionId);
            //return View(questionOptionsViewModel);     

            OnlineExamAppServiceReference.OnlineExamAppServiceClient onlineExamAppClient = new OnlineExamAppServiceReference.OnlineExamAppServiceClient();
            IQuestionOptionsViewModel questionOptionsViewModel = onlineExamAppClient.GetQuestion(questionId) as IQuestionOptionsViewModel;
            
            ViewBag.UserName = "Mudassar";

            return View(questionOptionsViewModel);     
        }        

        [HttpPost]
        public ActionResult SaveUserResponse(QuestionOptionsViewModel questionOptionsViewModel)
        {   
            ExamManager examManager = Session["ExamManager"] as ExamManager;
            examManager.UpdateResponse(questionOptionsViewModel);

            if (!examManager.IsLastQuestion(questionOptionsViewModel.Question.ID))
                return this.RedirectToAction("NextQuestion", new { questionId = questionOptionsViewModel.Question.ID });
            else
                return this.RedirectToAction("EvaluateExam");
        }

        public ActionResult EvaluateExam()
        {
            ExamManager examManager = Session["ExamManager"] as ExamManager;
            ExamResultViewModel examResult = examManager.EvaluateExam();

            return View(examResult);            
        }        
	}
}