<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="UserManagement._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="panel panel-default">
     <div class="panel-body">
        User Managment Form 
      </div>
   </div>
    <div class="row">
        
        <div class="col-md-4">
          
         <div class="form-group">
             
          <label for=" firstNamelbl">First Name</label>
             <asp:TextBox ID ="FirstName" CssClass="form-control" runat="server"  />
        

             <label for="lastName">Last Name</label>
             <asp:TextBox ID="lastName" class="form-control" runat="server"/>

             <label for=" email">Email</label>
             <asp:TextBox ID="email" class="form-control" runat="server"/>

             <label for="tempPassword">Temporary Password</label>
             <asp:TextBox ID = "tempPassword" class="form-control" runat="server"/>

           <label for="confPassowrd">Confirm Password</label>
           <asp:TextBox ID="confPassowrd" class="form-control" runat="server"/>

           <label for="Property">Property</label>
             <asp:DropDownList id="property" class="form-control" runat="server">
             <asp:ListItem >---Select---</asp:ListItem>
             <asp:ListItem>Rental</asp:ListItem>    
             </asp:DropDownList>

              <label for="group">Group</label>
             <asp:DropDownList id="group" class="form-control" runat="server">
             <asp:ListItem >---Select---</asp:ListItem> 
             <asp:ListItem >Admin</asp:ListItem>
             <asp:ListItem >Manager</asp:ListItem>
             <asp:ListItem >User</asp:ListItem>   
             </asp:DropDownList>
         
             <label for="timezone">Time Zone</label>
             <asp:DropDownList  id="timeZone" class="form-control" runat="server">
                 <asp:ListItem >---Select---</asp:ListItem>
                 <asp:ListItem >EST</asp:ListItem>
                  <asp:ListItem >PST</asp:ListItem>        
             </asp:DropDownList>
             <asp:Button runat="server" class="btn btn-primary form-control" value="Submit" id="btnCreate" onclick="btnCreate_click" />
            
         </div>
       
        </div>
        <div class="col-md-4">
        <asp:GridView id="gvViewAllUsers" runat="server" AutoGenerateColumns="false" ShowFooter="false" CssClass="table table-hover table-striped"
            GridLines="None"> 
         <asp:BoundField DataField="UserID" HeaderText="ID" Visible="false" />
        
        <asp:BoundField DataField="FirstName" HeaderText="First Name" />
        <asp:BoundField DataField="LastName" HeaderText="Last Name" />
        <asp:BoundField DataField="Email" HeaderText="Email" />
        <asp:BoundField DataField="Property" HeaderText="Property" />
        <asp:BoundField DataField="Group_" HeaderText="Group" />
        <asp:BoundField DataField="TimeZone" HeaderText="TimeZone<asp:BoundField DataField="Username" HeaderText="Username" />" />
        </asp:GridView>
        </div>
       
    </div>

</asp:Content>
