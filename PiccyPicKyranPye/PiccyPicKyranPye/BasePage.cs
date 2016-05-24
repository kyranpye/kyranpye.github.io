using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiccyPic.Web
{
    public class BasePage : System.Web.UI.Page
    {
        public PiccyPicKP.DataLayer.Repository DB { get; private set; }

        public int LoggedInUserId
        {
            get
            {
                int result = -1;

                if (Session["UserId"] != null)
                {
                    result = (int)Session["UserId"];
                }

                return result;
            }
        }

        public bool IsLoggedIn
        {
            get
            {
                return LoggedInUserId > -1;
            }
        }

        public PiccyPicKP.BO.User LoggedInUser
        {
            get
            {
                PiccyPicKP.BO.User result = null;

                if (IsLoggedIn)
                {
                    result = DB.UserGet(LoggedInUserId);
                }

                return result;
            }
        }

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);

            DB = new PiccyPicKP.DataLayer.Repository();
        }

        protected override void OnUnload(EventArgs e)
        {
            base.OnUnload(e);

            DB.Dispose();
        }
    }
}