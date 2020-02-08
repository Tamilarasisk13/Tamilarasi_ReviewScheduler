<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectForm.Login" %>

 <asp:Content ID="LoginHead" runat="server" ContentPlaceHolderID="head" >
         <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
 </asp:Content >
           
 <asp:Content ID="LoginBody" runat="server" ContentPlaceHolderID="ContentPlaceHolder1" class="LoginImage">
 
     <h1 style="color:darkslategrey" >         
               <i>  Login page</i>        
            </h1>
        <table  style="text-align: center">
            <tr>
                <td style="color:blue">
                    Username
                </td>
                <td>
                    <asp:TextBox ID="txtuserName"  Maxlength="30" runat="server"/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" runat="server" ForeColor="Blue" ErrorMessage="Username is required" ControlToValidate="txtuserName">                     
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                 <td style="color:blue">
                    Password
                </td>
                <td>
                    <asp:TextBox ID="txtpassword" runat="server"  Maxlength="15" TextMode="Password"/>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidatorpassword" runat="server" ForeColor="Blue" ErrorMessage="password is required" ControlToValidate="txtpassword">                     
                    </asp:RequiredFieldValidator>
                      <asp:RegularExpressionValidator ID="revPassword" runat="server" Display="Dynamic"
                            ControlToValidate="txtpassword" ForeColor="Blue" ErrorMessage="Invalid password!"
                            ValidationExpression="^((?=.{8,}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*|(?=.{8,}$)(?=.*\d)(?=.*[a-zA-Z])(?=.*[!\u0022#$%&'()*+,./:;<=>?@[\]\^_`{|}~-]).*)"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td "font-style:italic"  style="text-align: center" colspan="2">
                        <asp:Button ID="Button" runat="server" Text="Submit" OnClick="Button_Click" />
                </td>
            </tr>
        </table>
</asp:Content>
