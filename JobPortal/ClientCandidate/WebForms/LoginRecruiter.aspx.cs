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

        }

        protected void button_login_Click(object sender, EventArgs e)
        {
            String email = textbox_email.Text;
            String password = textbox_password.Text;
            if (email == "yash@gmail.com" && password == "123456")
            {
                Response.Redirect("~/Webforms/Dashboard.aspx");   
            } else
            {
                error_label.Text = "Invalid Credential...";
            }
        }
    }
}