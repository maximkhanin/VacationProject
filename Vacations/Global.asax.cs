﻿using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using VacationsBLL.SimpleInjectorConfig;

namespace IdentitySample
{
    // Note: For instructions on enabling IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=301868
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            SimpleInjectorConfig.RegisterComponents();
        }

        //protected void Application_Error(object sender, EventArgs e)
        //{
        //    HttpContext httpContext = HttpContext.Current;
        //    if (httpContext != null)
        //    {
        //        RequestContext requestContext = ((MvcHandler)httpContext.CurrentHandler).RequestContext;
        //        Exception exception = Server.GetLastError();
        //    }
        //    Response.Clear();
        //    Context.Response.Redirect("~/Account/ErrorPage"); 
        //}
    }
}
