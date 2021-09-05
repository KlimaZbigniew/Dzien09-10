using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        string cs = ConfigurationManager.ConnectionStrings["edoctorConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth_user"] == null)
            {
                Response.Redirect("~/Login");
            }

            try
            {
                data = (VisitData)Session["RegForm"];
                lblInfo.Text = $"{ data.FirstName} { data.LastName}";
            }
            catch (Exception ex)
            {
                Response.Redirect("~/RegisterVisit1");
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string filename = null;
            bool isOK = true;

            if (fuImage.HasFile)
            {
                if (fuImage.PostedFile.ContentType.Equals("image/png"))
                {
                    if (fuImage.PostedFile.ContentLength < 500_000)
                    {
                        //Własciwy upload
                        filename = Guid.NewGuid().ToString("N") + "-" + fuImage.FileName;
                        fuImage.SaveAs(Server.MapPath("~/Uploads/") + filename);
                    }
                    else
                    {
                        lblResult.Text = "Plik za duży";
                        isOK = false;
                    }
                }
                else
                {
                    lblResult.Text = "Niewłaściwy typ pliku.";
                    isOK = false;
                }
            }


            if (isOK)
            {

                //Zapis do DB
                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    string sql = "INSERT INTO visits (fname,lname, email,pesel,doctor, visit_date,  descr, image, card) " +
                                "VALUES (@fname,@lname, @mail,@pesel,@doctor, @visit_date, @descr, @image, @card)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@fname", data.FirstName);
                    cmd.Parameters.AddWithValue("@lname", data.LastName);
                    cmd.Parameters.AddWithValue("@mail", data.Email);
                    cmd.Parameters.AddWithValue("@pesel", data.PESEL);
                    cmd.Parameters.AddWithValue("@card", data.CardNumber);
                    cmd.Parameters.AddWithValue("@doctor", data.DoctorId);
                    cmd.Parameters.AddWithValue("@visit_date", data.DateVisit);
                    cmd.Parameters.AddWithValue("@descr", tbDesc.Text);
                    cmd.Parameters.AddWithValue("@image", filename);
                    cmd.ExecuteNonQuery();
                }
                Session.Remove("RegForm");
                Response.Redirect("~/WebForm1");

            }
        }
    }
}