using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebAppP5
{
    
    public class Global : System.Web.HttpApplication
    {
        public static Int32 SessionCounter = 0;

        //string[] users = new string[100];

        protected void Application_Start(object sender, EventArgs e)
        {
            //code that run on application startup
            // Response.Write("Wecome to our website");
            Application["SessionCounter"] = 0;
           Application["TotalSessions"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //code that run when a new session is started
            SessionCounter = SessionCounter + 1;

            int c = Convert.ToInt32(Application["SessionCounter"]);
            if (c > 0)
            {
                int i = Convert.ToInt32(Application["SessionCounter"]) + 1;
                Application["SessionCounter"] = i;
                Application.UnLock();
            }
            else
            {
                Application["SessionCounter"] = 1;
            } 
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
           // int i = Convert.ToInt32(Application["SessionCounter"]) + 1;
            //Application["SessionCounter"] = i;
            /* string fullOrigionalpath = Request.Url.ToString();
        
            if (fullOrigionalpath.Contains("/Login/Books.aspx")) {
                Context.RewritePath("/Products.aspx?Category=Books");
            }
            else if (fullOrigionalpath.Contains("/Products/DVDs.aspx")) {
                Context.RewritePath("/Products.aspx?Category=DVDs");
            } */
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        { /*

            if (this.Context.Request.IsAuthenticated)
            {
                string str = null;
                //Checking if the user is admin or just a simple user 

                if ((HttpContext.Current.User.Identity.Name.ToLower() == "admin"))
                {
                    str = "admin";
                }

                else
                {
                    str = "user";
                }
                string[] roles = new string[2];
                roles[0] = str;
                Context.User = new System.Security.Principal.GenericPrincipal(this.Context.User.Identity, roles);
            }  */

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            /*Code that run when an unhadled error occurs
            Exception exc = Server.GetLastError();

            if (exc is HttpUnhandledException)
            {
                // Pass the error on to the error page.
                Server.Transfer("ErrorPage.aspx?handler=Application_Error%20-%20Global.asax", true);
            }*/
        }

        protected void Session_End(object sender, EventArgs e)
        {
            //Code that run when a session ends
            Int32 count = (Int32)Application["SessionCounter"];
          //  count--;
            Application["SessionCounter"] = count;
        }

        protected void Application_End(object sender, EventArgs e)
        {
            /*code that run on application shutdown
            Int32 totalSession = (Int32)Application["TotalSessions"];
            Response.Write("hr /> The website was last visited on: " + DateTime.Now.ToString());
            Response.Write("hr /> The total session opened is: " + totalSession);
            */
        }
    }
}