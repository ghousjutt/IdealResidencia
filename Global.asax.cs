using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace IdealResidencia
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

        }
        //protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        //{
        //    ////Fires upon attempting to authenticate the use
        //    if (!(HttpContext.Current.User == null))
        //    {
        //        if (HttpContext.Current.User.Identity.IsAuthenticated)
        //        {
        //            if (HttpContext.Current.User.Identity.GetType() == typeof(FormsIdentity))
        //            {
        //                FormsIdentity fi = (FormsIdentity)HttpContext.Current.User.Identity;
        //                FormsAuthenticationTicket fat = fi.Ticket;

        //                string[] astrRoles = new string[] { fat.UserData };

        //                HttpContext.Current.User = new GenericPrincipal(fi, astrRoles);
        //                // Segment API wirte key
        //                //Segment.Analytics.Initialize(ConfigurationManager.AppSettings["SegmentWriteKey"]);
        //            }
        //        }
        //    }
        //}
    }
}
