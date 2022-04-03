using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ClientCandidate
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        void Application_End(object sender, EventArgs e)
        {
        }
        void Session_Start(object sender, EventArgs e)
        {
            Session["service_1"] = new CandidateService.CandidateServiceClient();
            Session["service_2"] = new JobService.JobServiceClient();
        }
        void Session_End(object sender, EventArgs e)
        {
            Session.Remove("service_1");
            Session.Remove("service_2");
        }
    }
}