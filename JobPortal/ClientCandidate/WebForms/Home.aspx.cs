using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientCandidate.WebForms
{
    public partial class Home : System.Web.UI.Page
    {
        private JobService.IJobService service;
        protected void Page_Load(object sender, EventArgs e)
        {
            service = (JobService.IJobService)Session["service_2"];
            JobService.Job[] jobs = service.GetAllJobs();
            grid_view_jobs.DataSource = jobs;
            grid_view_jobs.DataBind();
        }
    }
}