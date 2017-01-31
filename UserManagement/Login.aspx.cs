using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;

namespace UserManagement
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void ValidateUser(object sender, AuthenticateEventArgs e)
        {
            if(LoginForm.UserName.ToLower() == "admin" && LoginForm.Password.ToLower() =="admin" )
            {
                FormsAuthentication.RedirectFromLoginPage(LoginForm.UserName, LoginForm.RememberMeSet);

            }
        }
    }
}