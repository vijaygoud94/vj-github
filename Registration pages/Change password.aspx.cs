using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Changepassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        Passwordchange x = new Passwordchange();
        string oldpassword = Session["sess_password"].ToString();
        string enteredpassword = TextBox1.Text;

        if (enteredpassword.Equals(oldpassword))
        {
            x.Password = TextBox2.Text;
            x.Username= Session["sess_username"].ToString();
            int counter = x.ChPassword();
            if (counter.Equals(1))
            {
                Session.Abandon();
                Response.Redirect("Login Page.aspx");
            }
            else
            {
                Label3.Text = "your pass coudnt be updated";
            }
        }
        else
        {
            Label3.Text = "old password is incorrect";
        }
       
    }
}