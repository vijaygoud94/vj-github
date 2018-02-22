using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Changeprofile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            Chprofile x = new Chprofile();
            x.Username= Session["sess_username"].ToString();
            DataSet dset = x.userinfo();
            TextBox1.Text= Session["sess_username"].ToString();
            TextBox2.Text = dset.Tables[0].Rows[0]["password"].ToString();
            TextBox4.Text = dset.Tables[0].Rows[0]["email"].ToString();
            string country = dset.Tables[0].Rows[0]["country"].ToString();

            ListItem li = DropDownList1.Items.FindByText(country);
            int index = DropDownList1.Items.IndexOf(li);
            DropDownList1.SelectedIndex = index;


        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Chprofile x = new Chprofile();
        x.Username= Session["sess_username"].ToString();
        x.Password = TextBox2.Text;
        x.Email = TextBox4.Text;
        x.Country = DropDownList1.SelectedItem.Text;
        int counter = x.Cngprofile();
        if (counter.Equals(1))
        {
            Label5.Text = "<h1>profile Updated succesfully</h1>";
        }
    }
}