﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace WebBanDongHo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["Online"] = 0;

        }
        protected void Session_Start()
        {
            Application.Lock();
            Application["Online"] = (int)Application["Online"] + 1;
            Application.UnLock();
        }
        protected void Session_End()
        {
            Application.Lock();
            Application["Online"] = (int)Application["Online"] - 1;
            Application.UnLock();
        }
        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            var taiKhoanCookie = Context.Request.Cookies[FormsAuthentication.FormsCookieName];
            if (taiKhoanCookie != null)
            {
                var authTicket = FormsAuthentication.Decrypt(taiKhoanCookie.Value);
                var quyen = authTicket.UserData.Split(new char[] { ',' });
                var userPrincipal = new GenericPrincipal(new GenericIdentity(authTicket.Name), quyen);
                Context.User = userPrincipal;
            }
        }
    }
}
