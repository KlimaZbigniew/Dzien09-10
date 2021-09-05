using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        protected void gridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Delete"))
            {
                int rowId = Convert.ToInt32(e.CommandArgument);
                string cs = ConfigurationManager.ConnectionStrings["edoctorConnectionString"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    string sql = $"DELETE FROM visits WHERE id = {rowId}";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //gridView.DataBind();
                    Response.Redirect("~/WebForm1");

                }
            }
        }
    }
}