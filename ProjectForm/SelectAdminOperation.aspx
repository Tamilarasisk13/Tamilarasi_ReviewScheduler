<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SelectAdminOperation.aspx.cs" Inherits="ProjectForm.Operation" %>

<asp:Content ID="SelectOperationHead" runat="server" ContentPlaceHolderID="head"></asp:Content>
           
 <asp:Content ID="SelectOperationBody" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
 
            <h1><i>Select Operation </i>
            </h1>
            <table>              
                <tr >
             
                    <td >
                        <asp:RadioButton runat="server" ID="AddEmployee" Text="AddEmployee" Checked="true" /><br />
                        <asp:RadioButton ID="DeleteEmployee" runat="server" Text="Delete Employee" /><br />
                        <asp:RadioButton runat="server" ID="updateEmployee" Text="Update Employee" /><br />
                        <asp:RadioButton runat="server" ID="DisplayEmployee" Text="Display Employee" /><br />
                    </td>
                </tr>

                <tr>
                    <td >                      
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
       </asp:Content>