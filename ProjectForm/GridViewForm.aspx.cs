using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace ProjectForm
{
    public partial class GridViewForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindEmployeeDetails();
            }
        }
        public void BindEmployeeDetails()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["SampleConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            using (SqlCommand sqlCommand = new SqlCommand("spDisplayEmployee", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                GridViewId.DataSource = dataTable;
                GridViewId.DataBind();
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["SampleConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            using (SqlCommand sqlCommand = new SqlCommand("spDeleteEmployee", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                int id = Convert.ToInt16(GridViewId.DataKeys[e.RowIndex].Values["id"].ToString());
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@id", id);
                int i = sqlCommand.ExecuteNonQuery();
                BindEmployeeDetails();
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewId.EditIndex = e.NewEditIndex;
            BindEmployeeDetails();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewId.EditIndex = -1;
            BindEmployeeDetails();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["SampleConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            using (SqlCommand sqlCommand = new SqlCommand("spUpdateEmployee", sqlConnection))
            {

                TextBox firstName = GridViewId.Rows[e.RowIndex].FindControl("txtfirstName") as TextBox;
                TextBox lastName = GridViewId.Rows[e.RowIndex].FindControl("txtlastName") as TextBox;
                TextBox emailId = GridViewId.Rows[e.RowIndex].FindControl("txtemailId") as TextBox;
                TextBox gender = GridViewId.Rows[e.RowIndex].FindControl("txtgender") as TextBox;
                TextBox mobileNumber = GridViewId.Rows[e.RowIndex].FindControl("txtmobileNumber") as TextBox;
                TextBox dob = GridViewId.Rows[e.RowIndex].FindControl("txtdob") as TextBox;
                TextBox doj = GridViewId.Rows[e.RowIndex].FindControl("txtdoj") as TextBox;
                TextBox userName = GridViewId.Rows[e.RowIndex].FindControl("txtuserName") as TextBox;
                TextBox password = GridViewId.Rows[e.RowIndex].FindControl("txtpassword") as TextBox;
                TextBox designation = GridViewId.Rows[e.RowIndex].FindControl("txtdesignation") as TextBox;
                TextBox role = GridViewId.Rows[e.RowIndex].FindControl("txtrole") as TextBox;
                int id = Convert.ToInt16(GridViewId.DataKeys[e.RowIndex].Values["id"].ToString());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@firstName", firstName.Text);
                sqlCommand.Parameters.AddWithValue("@lastName", lastName.Text);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@emailId", emailId.Text);
                sqlCommand.Parameters.AddWithValue("@gender", gender.Text);
                sqlCommand.Parameters.AddWithValue("@mobileNumber", mobileNumber.Text);
                sqlCommand.Parameters.AddWithValue("@name", dob.Text);
                sqlCommand.Parameters.AddWithValue("@city", doj.Text);
                sqlCommand.Parameters.AddWithValue("@id", userName.Text);
                sqlCommand.Parameters.AddWithValue("@name", password.Text);
                sqlCommand.Parameters.AddWithValue("@city", designation.Text);
                sqlCommand.Parameters.AddWithValue("@id", role.Text);
                sqlConnection.Open();
                int i = sqlCommand.ExecuteNonQuery();
                GridViewId.EditIndex = -1;
                BindEmployeeDetails();
            }
        }
        protected void InsertClick(object sender, EventArgs e)
        {
            TextBox firstName = GridViewId.FooterRow.FindControl("txtfirstName") as TextBox;
            TextBox lastName = GridViewId.FooterRow.FindControl("txtlastName") as TextBox;            
            TextBox emailId = GridViewId.FooterRow.FindControl("txtemailId") as TextBox;
            TextBox gender = GridViewId.FooterRow.FindControl("txtgender") as TextBox;
            TextBox mobileNumber = GridViewId.FooterRow.FindControl("txtmobileNumber") as TextBox;
            TextBox dob = GridViewId.FooterRow.FindControl("txtdob") as TextBox;
            TextBox doj = GridViewId.FooterRow.FindControl("txtdoj") as TextBox;
            TextBox userName = GridViewId.FooterRow.FindControl("txtuserName") as TextBox;
            TextBox password= GridViewId.FooterRow.FindControl("txtpassword") as TextBox;
            TextBox designation = GridViewId.FooterRow.FindControl("txtdesigantion") as TextBox;
            TextBox role = GridViewId.FooterRow.FindControl("txtpassword") as TextBox;           
            UserRepositary userRepositary = new UserRepositary();           
            Employee employee = new Employee(firstName.Text, lastName.Text,emailId.Text, gender.Text, mobileNumber.Text, Convert.ToDateTime(dob.Text), Convert.ToDateTime(doj.Text), userName.Text, password.Text, designation.Text, role.Text);
           
            userRepositary.AddEmployee(employee);
            GridViewId.EditIndex = -1;
            BindEmployeeDetails();
        }
    }
}