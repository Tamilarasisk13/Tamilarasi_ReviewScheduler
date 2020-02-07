using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectForm
{
    public partial class Operation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (AddEmployee.Checked)
            {
                //Response.Write(AddEmployee.Checked);
                Response.Redirect("AddEmployee.aspx");
            }
            if (DeleteEmployee.Checked)
            {
                Response.Redirect("GridViewForm.aspx");
            }
        }

        protected void Admin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}