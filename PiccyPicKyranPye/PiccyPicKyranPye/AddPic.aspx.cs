using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//namespace PiccyPic.Web
//{
//    public partial class AddPic : BasePage
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            butAddPic.Click += butAddPic_Click;

//        }

//        void butAddPic_Click(object sender, EventArgs e)
//       {
//            PiccyPicKP.BO.Server newImage = new PiccyPicKP.BO.Server(txtName.Text, txtDescription.Text, LoggedInUser);
//            DB.ServerAdd(newImage);
//            DB.Save();
//        }
//    }
//}