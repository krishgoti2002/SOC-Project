using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientCandidate.WebForms
{
    public partial class DeleteCandidate : System.Web.UI.Page
    {
        private CandidateService.ICandidateService service;
        protected void Page_Load(object sender, EventArgs e)
        {
            service = (CandidateService.ICandidateService)Session["service_1"];
        }

        protected void button_delete_Click(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                CandidateService.Candidate candidate = service.RemoveCandidate(int.Parse(Session["id"] + ""));
                if (candidate != null)
                {
                    Session.Remove("id");
                    Session.Remove("name");
                    Response.Redirect("~/Webforms/LoginCandidate.aspx");
                }
            }
        }
    }
}