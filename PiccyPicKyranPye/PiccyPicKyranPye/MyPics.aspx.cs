﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PiccyPic.Web
{
    public partial class MyPics : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsLoggedIn)
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}