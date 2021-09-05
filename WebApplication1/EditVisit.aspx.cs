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
    public partial class EditVisit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                int recordId = Convert.ToInt32(Request.Params["id"]);
                tbHidenId.Value = recordId.ToString();

            }catch (Exception ex)
            {
                Response.Redirect("~/WebForm1");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int status = Convert.ToInt32(ddStatus.SelectedValue);
            if (status == 0)
            {
                lblResult.Text = "Wybierz status";
            }
            else
            {
                string sql = $"UPDATE visits SET status = {status} WHERE id = {Convert.ToInt32(tbHidenId.Value)}";

                string cs = ConfigurationManager.ConnectionStrings["edoctorConnectionString"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);


                    cmd.ExecuteNonQuery();
                    Response.Redirect("~/WebForm1");

                }
            }
        }
    }
}