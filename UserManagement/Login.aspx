<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="UserManagement.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="panel-body">
   <h3> User Managment Form Login </h3>
</div>
    <div class="row">
        <div class="col-md-4">        
            <asp:Login ID = "LoginForm" runat = "server"  OnAuthenticate="ValidateUser" CssClass="form-group">
                <LayoutTemplate>
                  <h4>Log In</h4>
                  <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                  <asp:TextBox ID="UserName" runat="server" CssClass="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="LoginForm">*</asp:RequiredFieldValidator>
                  <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                  <asp:TextBox ID="Password"  runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="LoginForm">*</asp:RequiredFieldValidator>
                  <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me next time." />
                  <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                  <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" CssClass="btn btn-primary" ValidationGroup="LoginForm" />
               </LayoutTemplate>
            </asp:Login>
        </div>
    </div>
</asp:Content>
