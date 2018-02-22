using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Failedattempts
/// </summary>
public class Failedattempts
{
    public Failedattempts()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private string m_username, m_password;

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
    public DataSet failed()
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataAdapter sda = null;
        DataSet dset = null;
        try
        {
            cn = new SqlConnection();
            cn.ConnectionString = "data source=.;initial catalog=vijay;integrated security=true";

            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText ="[USP_Failedattempts]";
            cmd.Parameters.AddWithValue("@username", Username);
            cmd.Parameters.AddWithValue("@password", Password);

            cn.Open();
            sda = new SqlDataAdapter(cmd);
            dset = new DataSet();
            sda.Fill(dset);



        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
        finally
        {

        }
        return (dset);
    }
}