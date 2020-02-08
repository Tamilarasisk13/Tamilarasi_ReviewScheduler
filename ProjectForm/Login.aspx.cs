using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace ProjectForm
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_Click(object sender, EventArgs e)
        {                                                                                                                      
            string connectionstring = ConfigurationManager.ConnectionStrings["SampleConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            SqlCommand sqlCommand = new SqlCommand("spLogin", sqlConnection);         
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@userName",txtuserName.Text);
            sqlCommand.Parameters.AddWithValue("@password", txtpassword.Text);
            sqlCommand.Parameters.Add("@role", SqlDbType.VarChar, 5);
            sqlCommand.Parameters["@role"].Direction = ParameterDirection.Output;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            string role = Convert.ToString(sqlCommand.Parameters["@role"].Value);
            Response.Write(role);
            sqlConnection.Close();
            if (role == "Admin")
            {
                Response.Write("Login Successfully");
                Response.Redirect("GridViewForm.aspx");             
            }
        }
    }
}