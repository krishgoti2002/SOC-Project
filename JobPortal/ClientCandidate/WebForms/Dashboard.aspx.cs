using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientCandidate.WebForms
{
    public partial class Dashboard : System.Web.UI.Page
    {
        private JobService.IJobService service;
        protected void Page_Load(object sender, EventArgs e)
        {
            service = (JobService.IJobService)Session["service_2"];
            label_name.Text = "Welcome " +  Session["name"].ToString();
            JobService.Job[] jobs = service.GetAllJobs();
            GridView1.DataSource = jobs;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Webforms/CreateJob.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int rowIndex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int id = Convert.ToInt32(GridView1.Rows[rowIndex].Cells[8].Text);
            service.RemoveJob(id);
            Response.Redirect("~/Webforms/Dashboard.aspx");
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            int rowIndex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int id = Convert.ToInt32(GridView1.Rows[rowIndex].Cells[8].Text);
            Session["edit_id_job"] = id;
            Response.Redirect("~/Webforms/EditJob.aspx");
        }
    }
}