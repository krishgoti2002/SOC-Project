using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientCandidate.WebForms
{
    public partial class LoginRecruiter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null && Session["id"].ToString().Equals("0") && Session["name"].ToString().Equals("admin"))
                Response.Redirect("~/Webforms/Dashboard.aspx");
        }

        protected void button_login_Click(object sender, EventArgs e)
        {
            String email = textbox_email.Text;
            String password = textbox_password.Text;
            if (email == "admin@gmail.com" && password == "admin123")
            {
                Session["id"] = "0";
                Session["name"] = "admin";
                Response.Redirect("~/Webforms/Dashboard.aspx");   
            } else
            {
                error_label.Text = "Invalid Credential...";
            }
        }
    }
}