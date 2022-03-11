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
        private DummyService.ICandidateService service;
        protected void Page_Load(object sender, EventArgs e)
        {
            service = (DummyService.ICandidateService)Session["service"];
        }

        protected void button_delete_Click(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                DummyService.Candidate candidate = service.RemoveCandidate(int.Parse(Session["id"] + ""));
                if (candidate != null)
                {
                    Session.Remove("id");
                    Session.Remove("name");
                    error_label.Text = "Account Deleted";
                    Response.Redirect("~/Webforms/LoginCandidate.aspx");
                }
            }
        }
    }
}