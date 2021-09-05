using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.App_Code;

namespace WebApplication1
{
    public partial class RegisterVisit1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth_user"] == null)
            {
                Response.Redirect("~/Login");
            }
        }

        protected void cbVIP_CheckedChanged(object sender, EventArgs e)
        {
            tbVIPNumber.Visible = cbVIP.Checked;
            tbVIPNumber.Text = tbVIPNumber.Visible ? tbVIPNumber.Text : string.Empty;
        }

        protected void Validate_PESEL(object source, ServerValidateEventArgs args)
        {
            //if (args.Value.Length ==11)
            args.IsValid = (args.Value.Length == 11);
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                VisitData data = new VisitData()
                {
                    FirstName = tbFName.Text,
                    LastName = tbFName.Text,
                    PESEL = tbPESEL.Text,
                    Email = tbEmail.Text,
                    CardNumber = tbVIPNumber.Text,
                    DateVisit = Calendar1.SelectedDate,
                    DoctorId = Convert.ToInt32(ddDoctor.SelectedValue)


                };

                Session["RegForm"] = data;
                Response.Redirect("~/RegisterVisit2");
            }
        }
    }
}