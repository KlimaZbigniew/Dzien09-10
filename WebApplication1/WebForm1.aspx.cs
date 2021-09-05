using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth_user"] == null)
            {
                Response.Redirect("~/Login");
            }
        }
        public string GetDoctor(int doctorId)
        {
            switch (doctorId)
            {
                case 1:
                    return "Lekarz 1";
                case 2:
                    return "Lekarz 2";
                case 3:
                    return "Lekarz 3";

                default:
                    return "---";
                    break;
            }
        }
    }
}