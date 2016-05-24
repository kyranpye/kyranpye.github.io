using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PiccyPic.Web
{
    public partial class SignIn : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            butLogIn.Click += butLogin_Click;
        }

        void butLogin_Click(object sender, EventArgs e)
        {
            PiccyPicKP.BO.User user = DB.UserGet(txtEmail.Text);

            if (user == null)
            {
                // Error user dosn't exist!
                pnlError.Visible = true;
                lblError.Text = "Incorrect username.";
            }
            else if (user.Password != txtPassword.Text)
            {
                // Error wrong password
                pnlError.Visible = true;
                lblError.Text = "Incorrect password.";
            }
            else
            {
                Session["UserId"] = user.Id;

                // Gather statistics
                string browserName = Request.Browser.Browser;
                string browserVersion = Request.Browser.Version;
                int screenWidth = int.Parse(Request.Form["width"]);
                int screenHeight = int.Parse(Request.Form["height"]);

                Response.Write("Browser name = " + browserName);
                Response.Write("<br />Browser version = " + browserVersion);
                Response.Write("<br />Screen width = " + screenWidth);
                Response.Write("<br />Screen height = " + screenHeight);

                Response.Redirect("MyPics.aspx");
            }
        }
    }
}