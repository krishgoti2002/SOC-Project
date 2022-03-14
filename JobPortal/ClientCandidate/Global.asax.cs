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
            Session["service"] = new DummyService.CandidateServiceClient();
            Session["service2"] = new DummyService2.JobServiceClient();
        }
        void Session_End(object sender, EventArgs e)
        {
            Session.Remove("service");
            Session.Remove("service2");
        }
    }
}