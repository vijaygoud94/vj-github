using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for login
/// </summary>
public class login
{
    private string m_username,m_password;
  

   

    public string Password
    {
        get
        {
            return m_password;
        }

        set
        {
            m_password = value;
        }
    }

    public string Username
    {
        get
        {
            return m_username;
        }

        set
        {
            m_username = value;
        }
    }

    public int Login()
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        int counter = 0;

        try
        {
            cn = new SqlConnection();
            cn.ConnectionString = "data source=.;initial catalog= vijay; integrated security=true";
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[USP_Login]";
            cmd.Parameters.AddWithValue("@username", Username);
            cmd.Parameters.AddWithValue("@password", Password);
            cn.Open();
            counter = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
        finally
        {
            if (cn != null)
            {
                cn.Close();
                cn.Dispose();
                cn = null;
            }

        }
        return (counter);
    }

}