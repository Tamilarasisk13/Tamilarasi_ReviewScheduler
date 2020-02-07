using System;
using EmployeeRepositary;
namespace ProjectForm
{
    public partial class AdminOperation : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            string gender = string.Empty;
            if (RadioButtonMale.Checked == true)
               gender = "Male";
            else
               gender= "Female";
            string role=string.Empty;
            if (UserButton.Checked == true)
                role = "User";
            else
                role ="Admin";
            Repositary repositary = new Repositary();
            Employee employee = new Employee(firstName.Text, lastName.Text, emailId.Text, gender,mobileNumber.Text, Convert.ToDateTime(txtdob.Text), Convert.ToDateTime(doj.Text), userName.Text, password.Text, designation.Text, role);
            if (repositary.AddEmployee(employee) == true)
                Response.Write("Employee is added Successfully");
            else
                Response.Write("Employee is not added");
        }
        protected void User_CheckedChanged(object sender, EventArgs e)
        {

        }
        protected void Admin_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void User_CheckedChanged1(object sender, EventArgs e)
        {

        }

        protected void Admin_CheckedChanged1(object sender, EventArgs e)
        {

        }
    }
}