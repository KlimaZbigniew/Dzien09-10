using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack)
            //{
            //    lblResult.Text = $"Twoje imię: {tbName.Text}";
            //    Response.SetCookie(new HttpCookie("name", tbName.Text));
            //}
            
            lbText1.Text = "Nagłówki HTTP: <br/>";
            foreach (var key in Request.Headers.AllKeys)
            {
                lbText1.Text += $"{key} - { Request.Headers[key]}<br/> ";
            }

            lbText1.Text += $"Metoda HTTP: {Request.HttpMethod}<br/>";
            lbText1.Text += $"Query string: {Request.QueryString}<br/>";

            lbText1.Text += "Ciasteczka: <br/>";
            foreach (var key in Request.Cookies.AllKeys)
            {
                lbText1.Text += $"{key} - { Request.Cookies[key].Value}<br/> ";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"Twoje imię: {tbName.Text}";
            Response.SetCookie(new HttpCookie("name", tbName.Text));
        }
    }
}