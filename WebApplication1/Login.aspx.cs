using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string HashPass(string password)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));

                }
                return sb.ToString();
            }
        }

        string cs = ConfigurationManager.ConnectionStrings["edoctorConnectionString"].ConnectionString;
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //sparwdzanie loginu i hasła
            string user = tbLogin.Text.Trim();
            string pass = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(user))
            {
                lblResult.Text = "Padaj hasło i login:";
                return;
            }

            string hashPass = HashPass(pass);
            string sql = "SELECT * FROM users WHERE username = @user AND password = @pass";

            using (MySqlConnection conn = new MySqlConnection(cs))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = hashPass;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    lblResult.Text = "Nienany user/hasło";
                } else
                {
 
                   Session["auth_user"] = dt.Rows[0]["username"];
                    Response.Redirect("~/WebForm1");
                }


            }
        }
    }
}