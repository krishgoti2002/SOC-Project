using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientCandidate
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void logout_button_Click(object sender, EventArgs e)
        {
            if (Session["id"] != null && Session["name"] != null)
            {
                Session.Remove("id");
                Session.Remove("name");
                Response.Redirect("~/Webforms/LoginCandidate.aspx");
                link_button_logout.Text = "Done";
            }
        }
    }
}