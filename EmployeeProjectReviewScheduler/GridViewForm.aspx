﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="GridViewForm.aspx.cs" Inherits="EmployeeProjectReviewScheduler.GridViewForm" %>

<asp:Content ID="GridviewHead" runat="server" ContentPlaceHolderID="head"></asp:Content>

<asp:Content ID="GridviewBody" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        <table>
            <tr>
                <td>
                    <asp:GridView ID="GridViewId" runat="server" AutoGenerateColumns="False" AutoGenerateDeleteButton="True"
                        AutoGenerateEditButton="True" DataKeyNames="id" OnRowCancelingEdit="GridView1_RowCancelingEdit"
                        OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing"
                        OnRowUpdating="GridView1_RowUpdating" ShowFooter="true">
                        <Columns>

                            <asp:TemplateField HeaderText="S.No" ItemStyle-Width="100">
                                <ItemTemplate>
                                    <asp:Label ID="lblRowNumber" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:Button ID="InsertId" runat="server" Text="Insert" OnClick="InsertClick"></asp:Button>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="FirstName">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtfirstName" MaxLength="30" runat="server" Text='<%# Bind("Firstname") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblfirstName" runat="server" Text='<%# Bind("Firstname") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    
                                    <asp:TextBox ID="firstNameId" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="firstNameId" ErrorMessage="Firstname is required"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="LastName">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtlastName" MaxLength="30" runat="server" Text='<%# Bind("Lastname") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbllastName" runat="server" Text='<%# Bind("Lastname") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>                                   
                                    <asp:TextBox ID="lastNameId" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="lastNameId" ErrorMessage="Lastname is required"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="id">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtid" MaxLength="5" runat="server" Text='<%# Bind("Id") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="txtid" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                                </ItemTemplate>

                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="emailId">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtemailId" MaxLength="40" runat="server" Text='<%# Bind("EmailId") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblemailId" runat="server" Text='<%# Bind("EmailId") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="emailIdId" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="emailIdId" ErrorMessage="EmailId is required"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="gender">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtgender" MaxLength="10" runat="server" Text='<%# Bind("Gender") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="txtgender" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="genderId" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="genderId" ErrorMessage="Gender is required"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="mobileNumber">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtmobileNumber" MaxLength="10" runat="server" Text='<%# Bind("MobileNumber") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="txtmobileNumber" runat="server" Text='<%# Bind("MobileNumber") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="mobileNumberId" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="mobileNumberId" ErrorMessage="Mobile Number is required"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>


                            <asp:TemplateField HeaderText="dob">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtdob" MaxLength="15" runat="server" Text='<%# Bind("Dob") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="txtdob" runat="server" Text='<%# Bind("Dob") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="dobId" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="dobId" ErrorMessage="DOB is required"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="doj">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtdoj" runat="server" MaxLength="15" Text='<%# Bind("Doj") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="txtdoj" runat="server" Text='<%# Bind("Doj") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="dojId" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="dojId" ErrorMessage="DOJ is required"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="userName">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtuserName" MaxLength="30" runat="server" Text='<%# Bind("UserName") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbluserName" runat="server" Text='<%# Bind("UserName") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="userNameId" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="userNameId" ErrorMessage="Username is required"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>


                            <asp:TemplateField HeaderText="password">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtpassword" MaxLength="15" runat="server" Text='<%# Bind("Password") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblpassword" runat="server" Text='<%# Bind("Password") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="passwordId" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="passwordId" ErrorMessage="Password is required"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="designation">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtdesignation" runat="server" Text='<%# Bind("Designation") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lbldesignation" runat="server" Text='<%# Bind("Designation") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="designationId" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="designationId" ErrorMessage="Designation is required"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="role">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtrole" MaxLength="5" runat="server" Text='<%# Bind("Role") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblrole" runat="server" Text='<%# Bind("Role") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="roleId" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="roleId" ErrorMessage="Role is required"></asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
