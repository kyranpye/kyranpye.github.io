using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace PiccyPic.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            if (ex != null)
            {
                string errorMessage = DateTime.Now.ToString() + " - ";
                errorMessage += Session["UserId"] + " ";
                errorMessage += ex.Message + " ";
                errorMessage += Request.RawUrl + Environment.NewLine;
                errorMessage += ex.StackTrace;
                errorMessage += Environment.NewLine + Environment.NewLine;
                 
                File.AppendAllText(Server.MapPath("~/App_Data/ErrorLog.txt"),
                    errorMessage);
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}