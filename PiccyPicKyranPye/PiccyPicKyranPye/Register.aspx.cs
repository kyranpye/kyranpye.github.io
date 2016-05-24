using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PiccyPic.Web
{
    public partial class Register : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            butRegister.Click += butRegister_Click;
        }

        void butRegister_Click(object sender, EventArgs e)
        {
           PiccyPicKP.BO.User user = new PiccyPicKP.BO.User(txtForename.Text,
                txtSurname.Text,
                txtEmail.Text,
                txtPassword.Text);

            if (DB.UserGet(txtEmail.Text) == null)
            {
                DB.UserAdd(user);
                DB.Save();

                Response.Redirect("Default.aspx");  
            }
            else
            {
                pnlError.Visible = Visible;
                lblError.Text = "This user account is already registered";
            }
        }
    }
}