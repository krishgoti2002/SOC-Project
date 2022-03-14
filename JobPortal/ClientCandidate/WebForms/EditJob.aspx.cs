using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientCandidate.WebForms
{
    public partial class EditJob : System.Web.UI.Page
    {
        private DummyService2.IJobService service;

        protected void Page_Load(object sender, EventArgs e)
        {
            service = (DummyService2.IJobService)Session["service2"];
            if (!IsPostBack)
            {
                var job = service.GetJob((int)Session["edit_id_job"]);
                textbox_title.Text = job.Title;
                textbox_city.Text = job.City;
                textbox_state.Text = job.State;
                textbox_email.Text = job.Email;
                textbox_mobile.Text = job.MobileNo;
                textbox_company_name.Text = job.Company;
                textbox_deadline.Text = job.Date.ToString("dd-MM-yyyy");
                description.Text = job.Description;
                textbox_exp.Text = job.Experience;
            }
        }

        protected void button_register_Click(object sender, EventArgs e)
        {
            DummyService2.Job newJob = new DummyService2.Job()
            {
                Title = textbox_title.Text,
                City = textbox_city.Text,
                State = textbox_state.Text,
                Email = textbox_email.Text,
                MobileNo = textbox_mobile.Text,
                Company = textbox_company_name.Text,
                Date = DateTime.Parse(textbox_deadline.Text),
                Description = description.Text,
                Experience = textbox_exp.Text,
                Id = (int)Session["edit_id_job"]

            };
            service.UpdateJob(newJob);
            Session.Remove("edit_id_job");
            Response.Redirect("~/Webforms/Dashboard.aspx");

        }
    }
}