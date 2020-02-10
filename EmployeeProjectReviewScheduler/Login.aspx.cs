using System;
using EmployeeProjectReviewSchedulerBL;
namespace EmployeeProjectReviewScheduler
{
    public partial class Login : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_Click(object sender, EventArgs e)
        {
            string role=PassEmployeeDetails.Login(txtuserName.Text, txtpassword.Text);
            if (role == "Admin")
            {
                Response.Write("Login Successfully");
                Response.Redirect("GridViewForm.aspx");
            }
            else if (role == "User")
                Response.Write("Login Successfully");
            else
                Response.Write("Login Unsuccessfull");
        }
    }
}