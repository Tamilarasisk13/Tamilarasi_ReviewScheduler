
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace ProjectForm
{
    public class UserRepositary
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["SampleConnection"].ConnectionString;
        public bool AddEmployee(Employee employee)
        {
          
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            using (SqlCommand sqlCommand = new SqlCommand("spInsertEmployee", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@firstName", employee.firstName);
                sqlCommand.Parameters.AddWithValue("@lastName", employee.lastName);
                sqlCommand.Parameters.AddWithValue("@emailId", employee.emailId);
                sqlCommand.Parameters.AddWithValue("@gender", employee.gender);
                sqlCommand.Parameters.AddWithValue("@mobileNumber", employee.mobileNumber);
                sqlCommand.Parameters.AddWithValue("@dob", employee.dob);
                sqlCommand.Parameters.AddWithValue("@doj", employee.doj);
                sqlCommand.Parameters.AddWithValue("@userName", employee.userName);
                sqlCommand.Parameters.AddWithValue("@password", employee.password);
                sqlCommand.Parameters.AddWithValue("@designation", employee.designation);
                sqlCommand.Parameters.AddWithValue("@role", employee.role);
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();
                if (rows > 0)
                    return true;
                else
                    return false;
            }
        }
        public bool DeleteEmployee(int id)
        {
          
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            using (SqlCommand sqlCommand = new SqlCommand("spDeleteEmployee", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
              
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@id", id);
                int rows = sqlCommand.ExecuteNonQuery();
                if (rows > 0)
                    return true;
                else
                    return false;
            }
        }
        public bool DisplayEmployee(System.Web.UI.WebControls.GridView GridViewId)
        {

            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            using (SqlCommand sqlCommand = new SqlCommand("spDisplayEmployee", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                GridViewId.DataSource = dataTable;
                GridViewId.DataBind();
                return true;
            }
        }
        public bool UpdateEmployee(Employee employee, int id)
        {

            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            using (SqlCommand sqlCommand = new SqlCommand("spUpdateEmployee", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@firstName",employee.firstName);
                sqlCommand.Parameters.AddWithValue("@lastName", employee.lastName);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@emailId", employee.emailId);
                sqlCommand.Parameters.AddWithValue("@gender", employee.gender);
                sqlCommand.Parameters.AddWithValue("@mobileNumber",employee. mobileNumber);
                sqlCommand.Parameters.AddWithValue("@dob", employee.dob);
                sqlCommand.Parameters.AddWithValue("@doj", employee.doj);
                sqlCommand.Parameters.AddWithValue("@userName", employee.userName);
                sqlCommand.Parameters.AddWithValue("@password", employee.password);
                sqlCommand.Parameters.AddWithValue("@designation", employee.designation);
                sqlCommand.Parameters.AddWithValue("@role", employee.role);
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();
                if (rows > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
