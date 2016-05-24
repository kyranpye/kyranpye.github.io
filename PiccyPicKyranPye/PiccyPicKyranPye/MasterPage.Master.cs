using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PiccyPic.Web
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BasePage page = Page as BasePage;
            if (page != null)
            {
                if (page.IsLoggedIn)
                {
                    pnlWelcome.Visible = true;
                    lblUsername.Text = page.LoggedInUser.Forename + " "
                        + page.LoggedInUser.Surname;
                    phLoggedInLinks.Visible = true;
                    phLoggedOutLinks.Visible = false;
                }
                else
                {
                    phLoggedInLinks.Visible = false;
                    phLoggedOutLinks.Visible = true;
                }
            }
        }
    }
}