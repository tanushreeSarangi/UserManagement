using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserManagement.DAL;


namespace UserManagement
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            UserDAL.GetUserDB();



         }



       
        public void btnCreate_click(object sender, EventArgs e)
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

        public void btnUpdate_click(object sender, EventArgs e)
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
            int userID = -1;
            UserDAL.UpdateUserDB(newUser,userID);
            
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            int userID = -1;
            UserDAL.DeleteUserDB(userID);
        }
    }


    
}