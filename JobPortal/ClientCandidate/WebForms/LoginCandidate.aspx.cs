using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClientCandidate;

namespace ClientCandidate.WebForms
{
    public partial class LoginCandidate : System.Web.UI.Page
    {
        private CandidateService.ICandidateService service;
        protected void Page_Load(object sender, EventArgs e)
        {
            service = (CandidateService.ICandidateService)Session["service_1"];
            if(Session["id"] != null && Session["name"] != null)
                Response.Redirect("~/Webforms/Home.aspx");
        }

        protected void button_login_Click(object sender, EventArgs e)
        {
            string email = textbox_email.Text;
            string password = textbox_password.Text;
            CandidateService.Candidate []candidates = service.GetAllCandidates();
            for(int i = 0; i < candidates.Length ;i++)
            {
                if(candidates[i].Email.Equals(email) && candidates[i].Password.Equals(password))
                {
                    Session["id"] = candidates[i].Id;
                    Session["name"] = candidates[i].Name;
                    Response.Redirect("~/Webforms/Home.aspx");
                }
            }
            error_label.Text = "Invalid Credential...";
        }
    }
}