using System;
using EmployeeProjectReviewSchedulerBL;
using EmployeeProjectReviewSchedulerEntity;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EmployeeProjectReviewScheduler
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
            int id = Convert.ToInt16(GridViewId.DataKeys[e.RowIndex].Values["id"].ToString());          
            if (PassEmployeeDetails.DeleteEmployee(id)>0)
                BindEmployeeDetails();
            else
                Response.Write("Employee is not deleted");
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
           
                string firstName = (GridViewId.Rows[e.RowIndex].FindControl("txtfirstName") as TextBox).Text;
                string lastName = (GridViewId.Rows[e.RowIndex].FindControl("txtlastName") as TextBox).Text;
                string emailId =( GridViewId.Rows[e.RowIndex].FindControl("txtemailId") as TextBox).Text;
                string gender = (GridViewId.Rows[e.RowIndex].FindControl("txtgender") as TextBox).Text;
                string mobileNumber = (GridViewId.Rows[e.RowIndex].FindControl("txtmobileNumber") as TextBox).Text;
                string dob = (GridViewId.Rows[e.RowIndex].FindControl("txtdob") as TextBox).Text;
                string doj = (GridViewId.Rows[e.RowIndex].FindControl("txtdoj") as TextBox).Text;
                string userName =( GridViewId.Rows[e.RowIndex].FindControl("txtuserName") as TextBox).Text;
                string password = (GridViewId.Rows[e.RowIndex].FindControl("txtpassword") as TextBox).Text;
                string designation = (GridViewId.Rows[e.RowIndex].FindControl("txtdesignation") as TextBox).Text;
               string role =( GridViewId.Rows[e.RowIndex].FindControl("txtrole") as TextBox).Text;
                int id = Convert.ToInt16(GridViewId.DataKeys[e.RowIndex].Values["id"].ToString());
                Employee employee = new Employee(firstName, lastName, emailId, gender, mobileNumber, Convert.ToDateTime(dob), Convert.ToDateTime(doj), userName, password, designation, role);
            if (PassEmployeeDetails.UpdateEmployee(employee, id)>0)
            {
                GridViewId.EditIndex = -1;
                BindEmployeeDetails();
            }
            else
                Response.Write("Employee is not updated");
        }
        protected void InsertClick(object sender, EventArgs e)
        {          
                string firstName = (GridViewId.FooterRow.FindControl("firstNameId") as TextBox).Text;
                string lastName = (GridViewId.FooterRow.FindControl("lastNameId") as TextBox).Text;
                string emailId = (GridViewId.FooterRow.FindControl("emailIdId") as TextBox).Text;
                string gender = (GridViewId.FooterRow.FindControl("genderId") as TextBox).Text;
                string mobileNumber = (GridViewId.FooterRow.FindControl("mobileNumberId") as TextBox).Text;
                string dob = (GridViewId.FooterRow.FindControl("dobId") as TextBox).Text;
                string doj = (GridViewId.FooterRow.FindControl("dojId") as TextBox).Text;
                string userName = (GridViewId.FooterRow.FindControl("userNameId") as TextBox).Text;
                string password = (GridViewId.FooterRow.FindControl("passwordId") as TextBox).Text;
                string designation = (GridViewId.FooterRow.FindControl("designationId") as TextBox).Text;
                string role = (GridViewId.FooterRow.FindControl("roleId") as TextBox).Text;
                Employee employee = new Employee(firstName, lastName, emailId, gender, mobileNumber, Convert.ToDateTime(dob), Convert.ToDateTime(doj), userName, password, designation, role);
                if (PassEmployeeDetails.AddEmployee(employee) > 0)
                {
                    GridViewId.EditIndex = -1;
                    BindEmployeeDetails();
                }
            
        }       
    }
}