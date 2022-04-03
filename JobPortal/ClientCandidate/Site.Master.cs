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
            if (Session["id"] == null && Session["name"] == null)
            {
                link_button_logout.Visible = false;
                link_profile.Visible = false;
            }
            else
            {
                link_button_logout.Visible = true;
                if (!Session["name"].ToString().Equals("admin"))
                    link_profile.Visible = true;

            }
        }
        protected void logout_button_Click(object sender, EventArgs e)
        {
            if (Session["id"] != null && Session["name"] != null)
            {
                Session.Remove("id");
                Session.Remove("name");
                Response.Redirect("~/Webforms/Welcome.aspx");
                link_button_logout.Text = "Done";
            }
        }
    }
}