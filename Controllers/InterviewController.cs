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
    }
}
