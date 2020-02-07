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
                //sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["SampleConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            using (SqlCommand sqlCommand = new SqlCommand("spDeleteEmployee", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                int id = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Values["id"].ToString());
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@id", id);
                int i = sqlCommand.ExecuteNonQuery();
                GridView1.DataBind();
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataBind();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataBind();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["SampleConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            using (SqlCommand sqlCommand = new SqlCommand("sp_updatedata", sqlConnection))
            {
                TextBox firstName = GridView1.Rows[e.RowIndex].FindControl("txtfirstName") as TextBox;
                TextBox lastName = GridView1.Rows[e.RowIndex].FindControl("txtlastName") as TextBox;
                TextBox emailId = GridView1.Rows[e.RowIndex].FindControl("txtemailId") as TextBox;
                TextBox gender = GridView1.Rows[e.RowIndex].FindControl("txtgender") as TextBox;
                TextBox mobileNumber = GridView1.Rows[e.RowIndex].FindControl("txtmobileNumber") as TextBox;
                TextBox dob = GridView1.Rows[e.RowIndex].FindControl("txtdob") as TextBox;
                TextBox doj = GridView1.Rows[e.RowIndex].FindControl("txtdoj") as TextBox;
                TextBox userName = GridView1.Rows[e.RowIndex].FindControl("txtuserName") as TextBox;
                TextBox password = GridView1.Rows[e.RowIndex].FindControl("txtpassword") as TextBox;
                TextBox designation = GridView1.Rows[e.RowIndex].FindControl("txtdesignation") as TextBox;
                TextBox role = GridView1.Rows[e.RowIndex].FindControl("txtrole") as TextBox;
                int id = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Values["@id"].ToString());
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ firstName", firstName.Text);
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
                GridView1.EditIndex = -1;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}