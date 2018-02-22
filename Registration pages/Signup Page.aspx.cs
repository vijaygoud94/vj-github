using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Signup_Page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        UserDetails x = new UserDetails();
        int counter = 0;
        try
        {
            x.Username = TextBox1.Text;
            x.Password = TextBox2.Text;
            x.Email = TextBox4.Text;
            x.Country = DropDownList1.SelectedItem.Text;
            counter = x.Createuser();

            if (counter.Equals(1))
            {
                Label5.Text = "<h2>Congracts bro</h2>";
            }
        }

        catch (Exception ex)
        {

            Label5.Text=ex.Message;
        }
    }
}