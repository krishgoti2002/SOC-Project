using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientCandidate.WebForms
{
    public partial class CreateJob : System.Web.UI.Page
    {
        private JobService.IJobService service;

        protected void Page_Load(object sender, EventArgs e)
        {
            service = (JobService.IJobService)Session["service_2"];
        }

        protected void button_register_Click(object sender, EventArgs e)
        {
            JobService.Job newJob = new JobService.Job()
            {
                Title = textbox_title.Text,
                City = textbox_city.Text,
                State = textbox_state.Text,
                Email = textbox_email.Text,
                MobileNo = textbox_mobile.Text,
                Company = textbox_company_name.Text,
                Date = DateTime.Parse(textbox_deadline.Text),
                Description= description.Text,
                Experience= textbox_exp.Text,
           
            };
            service.AddJob(newJob);
            Response.Redirect("~/Webforms/Dashboard.aspx");

        }
    }
}