using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

using System.Data.SqlClient;
/// <summary>
/// Summary description for Unsubscribe
/// </summary>
public class Unsubscribe
{
    public Unsubscribe()
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



    public int unsubscribe()
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
            cmd.CommandText = "[USP_Unsubscribe]";
            cmd.Parameters.AddWithValue("@username", Username);

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