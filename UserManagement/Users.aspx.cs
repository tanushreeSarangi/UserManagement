using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserManagement.DAL;


namespace UserManagement
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
         

            ViewState.Clear();
            UserDAL.GetUserDB(gvViewAllUsers);
            
         }


        public void ClearForm()
        {
            FirstName.Text = string.Empty;
            lastName.Text = string.Empty;
            email.Text = string.Empty;
            confPassowrd.Attributes.Remove("disabled");
            tempPassword.Attributes.Remove("disabled");
            btnCreate.Text = "Submit";
            confPassowrd.Text = string.Empty;
            userID.Value = string.Empty;
            tempPassword.Text = string.Empty;
            group.SelectedIndex = 0;
            property.SelectedIndex = 0;
            timeZone.SelectedIndex = 0;

        }
        protected void gvViewAllUsers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            return;
        }
        protected void gvViewAllUsers_RowSelecting(object sender, GridViewSelectEventArgs e)
        {
            return;
        }

        public void btnCreate_click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userID.Value))
            {
                User newUser = new User();
                newUser.FirstName = FirstName.Text;
                newUser.LastName = lastName.Text;
                newUser.Email = email.Text;
                newUser.Password = confPassowrd.Text;
                newUser.TempPwd = tempPassword.Text;
                newUser.Property = property.SelectedValue;
                newUser.Group = group.SelectedValue;
                newUser.Timezone = timeZone.SelectedValue;
                UserDAL.CreateUserDB(newUser);
            }
            else
            {
                UpdateUser(int.Parse(userID.Value));
            }
            ClearForm();
         
        }

        public void UpdateUser(int userID)
        {
            User newUser = new User();
            newUser.FirstName = FirstName.Text;
            newUser.LastName = lastName.Text;
            newUser.Email = email.Text;
            newUser.Property = property.SelectedValue;
            newUser.Group = group.SelectedValue;
            newUser.Timezone = timeZone.SelectedValue;
            UserDAL.UpdateUserDB(newUser,userID);
            UserDAL.GetUserDB(gvViewAllUsers);
            gvViewAllUsers.DataBind();

        }

        public void DeleteUser(int userID)
        {
            
            UserDAL.DeleteUserDB(userID);
        }

        protected void gvViewAllUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)gvViewAllUsers.Rows[e.RowIndex];
            int userID = int.Parse(row.Cells[0].Text);
            DeleteUser(userID);

           
        }

        private void EditUser() { }

        protected void gvViewAllUsers_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = gvViewAllUsers.Rows[index];

            if (e.CommandName == "EditUser")
            {
                btnCreate.Text = "Update";
                confPassowrd.Attributes.Add("disabled","disabled");
                tempPassword.Attributes.Add("disabled","disabled");
                userID.Value = row.Cells[0].Text;
                FirstName.Text = row.Cells[1].Text;
                lastName.Text = row.Cells[2].Text;
                email.Text = row.Cells[3].Text;
                property.SelectedValue = row.Cells[4].Text;
                group.SelectedValue = row.Cells[5].Text;
                timeZone.SelectedValue = row.Cells[6].Text;
                

            }

        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }


    
}