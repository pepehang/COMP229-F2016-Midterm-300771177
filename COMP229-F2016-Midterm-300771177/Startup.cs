﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(COMP229_F2016_Midterm_300771177.Startup))]

namespace COMP229_F2016_Midterm_300771177
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login.aspx")
            });
        }
    }
}
