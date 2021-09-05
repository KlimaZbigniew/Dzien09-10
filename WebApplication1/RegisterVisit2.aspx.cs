using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.App_Code;

namespace WebApplication1
{
    public partial class RegisterVisit2 : System.Web.UI.Page
    {
        VisitData data = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                data = (VisitData)Session["RegForm"];
                lblInfo.Text = $"{ data.FirstName} { data.LastName}";
            }catch (Exception ex)
            {
               /// Response.Redirect("~/RegisterVisit1");
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string filename;
            bool isOK = true;

            if (fuImage.HasFile)
            {
                if (fuImage.PostedFile.ContentType.Equals("image/png"))
                {
                    if (fuImage.PostedFile.ContentLength<500_000)
                    {
                        //Własciwy upload
                         filename = Guid.NewGuid().ToString("N") + "-" + fuImage.FileName;
                        fuImage.SaveAs(Server.MapPath("~/Uploads/") + filename);
                    }else
                    {
                        lblResult.Text = "Plik za duży";
                        isOK = false;
                    }
                }else
                {
                    lblResult.Text = "Niewłaściwy typ pliku.";
                    isOK = false;
                }
            }


            if (isOK)
            {

                //Zapis do DB
            }
        }
    }
}