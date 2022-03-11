using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientCandidate.WebForms
{
    public partial class Home : System.Web.UI.Page
    {
        private DummyService.ICandidateService service;
        protected void Page_Load(object sender, EventArgs e)
        {
            service = (DummyService.ICandidateService)Session["service"];
            DummyService.Candidate []candidates = service.GetAllCandidates();
            for(int i = 0; i<candidates.Count();i++)
            {
                Label2.Text += candidates[i].Name + " ";
            }
        }
    }
}