using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Login_page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Failedattempts x = new Failedattempts();
        x.Username = TextBox1.Text;
        x.Password = TextBox2.Text;
        DataSet dset = x.failed();
        int status = Convert.ToInt32(dset.Tables[0].Rows[0]["Status"].ToString());
        switch (status)
        {
            case 1:
                Session["sess_username"] = TextBox1.Text;
                Session["sess_password"] = TextBox2.Text;
                Response.Redirect("HomePage.aspx");
                break;

            case -1:
                Label3.Text = "<h2>No such username exist</h2>";
                break;

            case -2:
                Label3.Text = "<h2>you've ben unsubscribed</h2>";
                break;

            case -3:
                Label3.Text = "<h2>Account Locked</h2>";
                break;

            case 0:
                int NOFA = Convert.ToInt32(dset.Tables[0].Rows[0]["NOFA"].ToString());
                if (NOFA.Equals(5))
                {
                    Label3.Text = "<h1>you have exceeded your limit</h1>";
                }
                else
                {
                    Label3.Text = "<h1>wrong password you are left with"+(5-NOFA)+"</h1>";
                }
                break;

        }
    }
      

       

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Signup page.aspx");
    }
}