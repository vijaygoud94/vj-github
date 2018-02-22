using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Label1.Text = "<h1>Hello " + Session["sess_username"].ToString()+ "Welcome back </h1>" ;
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Login page.aspx");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Change password.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Unsubscribe x = new Unsubscribe();
        x.Username = Session["sess_username"].ToString();
        int counter = x.unsubscribe();
        if (counter.Equals(1))
        {
            Response.Redirect("Signup Page.aspx");
        }
        else
        {
            Label1.Text = "<h1>There is an error while unsubscribing</h1>";
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Changeprofile.aspx");
    }
}