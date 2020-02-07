using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace EmployeeRepositary
{
    public class Repositary 
    {
        public bool AddEmployee(Employee employee)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["SampleConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            using (SqlCommand sqlCommand = new SqlCommand("spInsertEmployee", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@firstName", employee.firstName);
                sqlCommand.Parameters.AddWithValue("@lastName",employee.lastName);
                sqlCommand.Parameters.AddWithValue("@emailId",employee. emailId);
                sqlCommand.Parameters.AddWithValue("@gender", employee.gender);
                sqlCommand.Parameters.AddWithValue("@mobileNumber",employee. mobileNumber);
                sqlCommand.Parameters.AddWithValue("@dob", employee.dob);
                sqlCommand.Parameters.AddWithValue("@doj",employee. doj);
                sqlCommand.Parameters.AddWithValue("@userName",employee. userName);
                sqlCommand.Parameters.AddWithValue("@password",employee. password);              
                sqlCommand.Parameters.AddWithValue("@designation",employee. designation);
                sqlCommand.Parameters.AddWithValue("@role",employee. role);
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
