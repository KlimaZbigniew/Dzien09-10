using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationExample
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        List<City> cities = new List<City>();
        protected void Page_Load(object sender, EventArgs e)
        {
            cities.Add(new City(1, "Gdańsk"));
            cities.Add(new City(2, "Kraków"));
            cities.Add(new City(3, "Pcim"));

            DropDownList1.DataSource = cities;
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();


            if (IsPostBack)
            {
                //Odczyt checkbox
                Label1.Text = $"Pojedynczy checkBox: {CheckBox1.Checked} <BR/>";

                foreach (ListItem item in CheckBoxList1.Items)
                {
                    if (item.Selected)
                        Label1.Text += $"checkBoxList = {item.Value} <BR/>";
                }

                Label1.Text += $"DropdownList1: {DropDownList2.SelectedValue} <BR/>";
                Label1.Text += $"DropdownList2: {DropDownList1.SelectedValue} <BR/>";

                Label1.Text += $"Radiobuton list: {RadioButtonList1.SelectedValue} <BR/>";

                foreach (var indeks in ListBox1.GetSelectedIndices())
                {
                    Label1.Text += $"Listbox: {ListBox1.Items[indeks].Value} <BR/>";
                }

                

            }


        }
    }
}