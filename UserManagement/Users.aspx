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
            <asp:HiddenField ID="userID" Value="" runat="server"/>
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
             <asp:ListItem >Select a value</asp:ListItem>
             <asp:ListItem>Rental</asp:ListItem>    
             </asp:DropDownList>

              <label for="group">Group</label>
             <asp:DropDownList id="group" class="form-control" runat="server">
             <asp:ListItem Value="select" Selected Text="Select a value" /> 
             <asp:ListItem Value ="Manager" Text="Corporate Management" />
             <asp:ListItem Value="Admin" Text="Admin" />
             <asp:ListItem Value="entry" Text="Entry User" />   
             </asp:DropDownList>
             <label for="timezone">Time Zone</label>
             <asp:DropDownList  id="timeZone" class="form-control" runat="server">
                 <asp:ListItem Value="select" Text="Select a value" Selected />
                 <asp:ListItem Value="est" Text ="EST" />
                  <asp:ListItem Value="pst" Text="PST" />        
             </asp:DropDownList>
             <asp:Button runat="server" Text="Submit" AutoPostBack="true" class="btn btn-primary btn-margin form-control" value="Submit" id="btnCreate" onclick="btnCreate_click" />
              <asp:Button runat="server" Text="Clear" CssClass="btn btn-danger btn-margin form-control" OnClick="Clear_Click" />
         </div>
       
        </div>
        <div class="col-md-4">
        <asp:GridView id="gvViewAllUsers" runat="server" AutoGenerateColumns="false" ShowFooter="false" CssClass="table table-hover table-striped"
            OnRowCommand ="gvViewAllUsers_RowCommand"
            OnRowDeleting ="gvViewAllUsers_RowDeleting"
            OnRowSelecting="gvViewAllUsers_RowSelecting"
            GridLines="None"> 
            <SelectedRowStyle CssClass="success" />
            <Columns>
         <asp:BoundField DataField="UserID" HeaderText="ID" ItemStyle-CssClass="Hidden" HeaderStyle-CssClass="Hidden"/>
        <asp:BoundField DataField="FirstName" HeaderText="First Name"  headerStyle-Wrap="false" />
        <asp:BoundField DataField="LastName" HeaderText="Last Name"  headerStyle-Wrap="false"/>
        <asp:BoundField DataField="Email" HeaderText="Email" />
        <asp:BoundField DataField="Property" HeaderText="Property" />
        <asp:BoundField DataField="Group_" HeaderText="Group" />
        <asp:BoundField DataField="TimeZone" HeaderText="TimeZone" /> 
                <asp:TemplateField HeaderText="Edit User">
                <ItemTemplate>
                    <asp:LinkButton ID="EditButton"
                         runat="server"
                         CommandName="EditUser" 
                         CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
                         CssClass="glyphicon glyphicon-edit"
                           
                            />
                </ItemTemplate>
            </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete User">
                <ItemTemplate>
                    <asp:LinkButton ID="DeleteButton"
                            runat="server"
                            CssClass="glyphicon glyphicon-trash"
                            CommandName="Delete"
                            />
                </ItemTemplate>
            </asp:TemplateField>
                </Columns>
        </asp:GridView>
        </div>
       
    </div>

</asp:Content>
