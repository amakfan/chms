using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc.Models;

namespace mvc.Controllers
{
    public class InterviewController : Controller
    {
        public IActionResult Index()
        {
            Respondent r = new Respondent();
            RespondentViewModel vm = new RespondentViewModel();
           
            //dynamic collection = r.GetType().GetProperty(nameof(r.Medications)).GetValue(r);
            CallBlock medCallBlock = new CallBlock("CNFRM");
            vm.Medications = new ArrayCallBlock<Medication>("FakeIdArray", r.Medications, medCallBlock);
            
            return View(vm);

        }

        [HttpPost]
        public IActionResult NextQuestion(string mId, string qId)
        {
            Respondent r = new Respondent();

            ArrayCallBlock<Medication> acb = new ArrayCallBlock<Medication>("", r.Medications, new CallBlock("CNFRM"), mId, qId);

            Question next = (Question)acb.GetNextElement();
            ICollectionItem medication = acb.GetCurrentItem();

            return PartialView("_Question", new QuestionViewModel() { Question = next, Medication = medication});



        }
    }
    
}
