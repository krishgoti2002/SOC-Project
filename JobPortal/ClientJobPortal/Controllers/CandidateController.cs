using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientJobPortal.Controllers
{
    public class CandidateController : Controller
    {
        private DummyService.ICandidateService dummyService = new DummyService.CandidateServiceClient();
      
        [HttpGet]
        public ActionResult Add()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Create()
        {

            return View();
        }
    }
}