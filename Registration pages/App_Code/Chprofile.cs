using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Chprofile
/// </summary>
public class Chprofile
{
    public Chprofile()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private string m_username, m_password, m_country, m_email;


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

    public string Country
    {
        get
        {
            return m_country;
        }

        set
        {
            m_country = value;
        }
    }

    public string Email
    {
        get
        {
            return m_email;
        }

        set
        {
            m_email = value;

        }

    }


    public DataSet userinfo()
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataAdapter sda = null;
        DataSet dset = null;
       

        try
        {

            cn = new SqlConnection();
            cn.ConnectionString = "data source=.;initial catalog= vijay; integrated security=true";
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[USP_Userinfo]";
            cmd.Parameters.AddWithValue("@username", Username);
            sda = new SqlDataAdapter(cmd);
            dset = new DataSet("users");
            sda.Fill(dset, "users");

        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }

        return (dset);
    }





    public int Cngprofile()
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
            cmd.CommandText = "[USP_Changeprofile]";
            cmd.Parameters.AddWithValue("@username", Username);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.Parameters.AddWithValue("@country", Country);
            cmd.Parameters.AddWithValue("@email", Email);

            cn.Open();
            counter = cmd.ExecuteNonQuery();
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
        