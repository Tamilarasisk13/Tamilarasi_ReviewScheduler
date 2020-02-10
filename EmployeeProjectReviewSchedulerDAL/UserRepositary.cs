using System;
using System.Configuration;
using EmployeeProjectReviewSchedulerEntity;
using System.Data;
using System.Data.SqlClient;
namespace EmployeeProjectReviewSchedulerDAL
{
    public class UserRepositary
    {
        static string connectionstring = ConfigurationManager.ConnectionStrings["SampleConnection"].ConnectionString;
        public static string Login(string userName, string password)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("spLogin", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@userName", userName);
                sqlCommand.Parameters.AddWithValue("@password", password);
                sqlCommand.Parameters.Add("@role", SqlDbType.VarChar, 5);
                sqlCommand.Parameters["@role"].Direction = ParameterDirection.Output;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                string role = Convert.ToString(sqlCommand.Parameters["@role"].Value);
                return role;
            }
        }
            catch(Exception)
            {
                return "Error";
            }          
        }
        public static int AddEmployee(Employee employee)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            try
            {
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
                    return rows;
                }
            }
            catch (SqlException)
            {
                return -1;
            }
            catch (Exception)
            {
                return -2;
            }
        }
        public static int DeleteEmployee(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            using (SqlCommand sqlCommand = new SqlCommand("spDeleteEmployee", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@id", id);
                int rows = sqlCommand.ExecuteNonQuery();
                return rows;
            }
        }
        public static int UpdateEmployee(Employee employee, int id)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("spUpdateEmployee", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@firstName", employee.firstName);
                    sqlCommand.Parameters.AddWithValue("@lastName", employee.lastName);
                    sqlCommand.Parameters.AddWithValue("@id", id);
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
                    return rows;
                }
            }
            catch (SqlException)
            {
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        //public static bool DisplayEmployee(string id)
        //{
        //    SqlConnection sqlConnection = new SqlConnection(connectionstring);
        //    using (SqlCommand sqlCommand = new SqlCommand("spDisplayEmployee", sqlConnection))
        //    {
        //        sqlCommand.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //        DataTable dataTable = new DataTable();
        //        sqlDataAdapter.Fill(dataTable);
        //        GridViewId.DataSource = dataTable;
        //        GridViewId.DataBind();
        //        return true;
        //    }
        //}
    }
}
