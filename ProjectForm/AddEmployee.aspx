<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="ProjectForm.AdminOperation" %>

<asp:Content ID="AddEmployeeHead" runat="server" ContentPlaceHolderID="head"></asp:Content>
           
 <asp:Content ID="AddEmployeeBody" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
            <h2  >Add Employee
            </h2>
            <table>
                <tr>
                    <td>First Name
                    </td>
                    <td>
                        <asp:TextBox ID="firstName" runat="server" OnTextChanged="firstName_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstname" runat="server" ForeColor="Blue" ErrorMessage="Please enter firstname" ControlToValidate="firstName">                     
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Last Name
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="lastName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email Id
                    </td>
                    <td>
                        <asp:TextBox ID="emailId" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmailId" runat="server" ForeColor="Blue" ErrorMessage="Please enter Emailid " ControlToValidate="emailId">                     
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmailId" runat="server" ControlToValidate="emailId"
                            ErrorMessage="Please enter valid email" ForeColor="Blue" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"> 
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Gender</td>
                    <td class="auto-style1">                       
                                      <asp:RadioButton ID="RadioButtonMale"  runat="server" Text="Male" Checked="true" GroupName="Gender"/>
                                      <asp:RadioButton ID="RadioButtonFemale" runat="server" Text="Female" GroupName="Gender"/>                  
                    </td>
                </tr>
                <tr>
                    <td>Mobile Number
                    </td>
                    <td>
                        <asp:TextBox ID="mobileNumber" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorMobileNumber" runat="server" ForeColor="Blue" ErrorMessage="Please enter MobileNumber" ControlToValidate="mobileNumber">                     
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                            ControlToValidate="mobileNumber" ForeColor="Blue" ErrorMessage="Please enter valid Mobile number!"
                            ValidationExpression="^([6-9]{1})([0-9]{9})$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                 <tr>
                    <td>Date of birth
                    </td>
                    <td>
                        <asp:TextBox ID="txtdob" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Blue" ErrorMessage="Please enter DOB" ControlToValidate="txtdob">                     
                        </asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtdob" ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                      ForeColor="Blue"       runat="server" ErrorMessage="Please neter valid DOJ"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                 <tr>
                    <td>Date of joining
                    </td>
                    <td>
                        <asp:TextBox ID="doj" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorDoj" runat="server" ForeColor="Blue" ErrorMessage="Please enter DOJ" ControlToValidate="doj">                     
                        </asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="revDoj" ControlToValidate="doj" ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                      ForeColor="Blue"       runat="server" ErrorMessage="Please neter valid DOJ"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>User Name
                    </td>
                    <td>
                        <asp:TextBox ID="userName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" runat="server" ForeColor="Blue" ErrorMessage="Please enter username" ControlToValidate="userName">                     
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password
                    </td>
                    <td>        
                        <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ForeColor="Blue" ErrorMessage="Please enter Password" ControlToValidate="password">                     
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revPassword" runat="server" Display="Dynamic"
                            ControlToValidate="password" ForeColor="Blue" ErrorMessage="Invalid password!"
                            ValidationExpression="^((?=.{8,}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*|(?=.{8,}$)(?=.*\d)(?=.*[a-zA-Z])(?=.*[!\u0022#$%&'()*+,./:;<=>?@[\]\^_`{|}~-]).*)"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Conform password
                    </td>
                    <td>
                        <asp:TextBox ID="conformPassword" runat="server" TextMode="Password"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidatoronformPassword" runat="server" ForeColor="Blue" ErrorMessage="Please enrer conformPassword" ControlToValidate="conformPassword">                     
                        </asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server"
                            ControlToCompare="password" ControlToValidate="conformPassword" ForeColor="Blue" ErrorMessage="Conform password not matched">
                        </asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Designation
                    </td>

                    <td>
                        <asp:DropDownList ID="designation" runat="server">
                            <asp:ListItem>Scheduler </asp:ListItem>
                            <asp:ListItem>Reviewer </asp:ListItem>
                            <asp:ListItem>Reviewee</asp:ListItem>
                            <asp:ListItem>CEO </asp:ListItem>
                            <asp:ListItem>Manager </asp:ListItem>
                            <asp:ListItem>Team Leader</asp:ListItem>
                            <asp:ListItem>Business analyst </asp:ListItem>
                            <asp:ListItem>Tester </asp:ListItem>
                            <asp:ListItem>Developer </asp:ListItem>
                            <asp:ListItem>HR </asp:ListItem>
                        </asp:DropDownList>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorDesignation" runat="server" ForeColor="Blue" ErrorMessage="Please enter desigantion" ControlToValidate="designation">                     
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Role
                    </td>
                    <td class="auto-style1">
                      <%--  <asp:DropDownList ID="role" runat="server">
                            <asp:ListItem>User </asp:ListItem>
                            <asp:ListItem>Admin </asp:ListItem>
                        </asp:DropDownList>--%>
                                      <asp:RadioButton ID="UserButton"  runat="server" Text="User" Checked="true" GroupName="Role"/>
                                      <asp:RadioButton ID="AdminButton" runat="server" Text="Admin" GroupName="Role"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button" runat="server" Text="Submit" OnClick="Button_Click" />
                    </td>
                </tr>
            </table>
      </asp:Content>