using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace UserManagement.DAL
{
    public class UserDAL
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public static int CreateUserDB(User userObj)
        {


          
            using (SqlConnection myConnection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand("AddUser_SP", myConnection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    myConnection.Open();
                    command.Parameters.Add(new SqlParameter("@FirstName", userObj.FirstName));
                    command.Parameters.Add(new SqlParameter("@LastName", userObj.LastName));
                    command.Parameters.Add(new SqlParameter("@Email", userObj.Email));
                    command.Parameters.Add(new SqlParameter("@TempPwd", userObj.TempPwd));
                    command.Parameters.Add(new SqlParameter("@Password", userObj.Password));
                    command.Parameters.Add(new SqlParameter("@Property", userObj.Property));
                    command.Parameters.Add(new SqlParameter("@Group_", userObj.Group));
                    command.Parameters.Add(new SqlParameter("@Timezone", userObj.Timezone));

                    return command.ExecuteNonQuery();


                }
            }

        }

        // method for editing the information of the users :
        public static int UpdateUserDB(User userObj, int userID)
        {


         
            using (SqlConnection myConnection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand("UpdateUser_SP", myConnection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    myConnection.Open();
                    command.Parameters.Add(new SqlParameter("@UserID", userID));
                    command.Parameters.Add(new SqlParameter("@FirstName", userObj.FirstName));
                    command.Parameters.Add(new SqlParameter("@LastName", userObj.LastName));
                    command.Parameters.Add(new SqlParameter("@Email", userObj.Email));
                    command.Parameters.Add(new SqlParameter("@TempPwd", userObj.TempPwd));
                    command.Parameters.Add(new SqlParameter("@Password", userObj.Password));
                    command.Parameters.Add(new SqlParameter("@Property", userObj.Property));
                    command.Parameters.Add(new SqlParameter("@Group_", userObj.Group));
                    command.Parameters.Add(new SqlParameter("@Timezone", userObj.Timezone));

                    return command.ExecuteNonQuery();


                }
            }

        }

        // method for deleting the users :
        public static int DeleteUserDB(int userID)
        {


            
            using (SqlConnection myConnection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand("DeleteUser_SP", myConnection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    myConnection.Open();
                    command.Parameters.Add(new SqlParameter("@UserID", userID));
                    return command.ExecuteNonQuery();


                }
            }

        }

        // method for viewing all the users :
        public static int GetUserDB()
        {
       
            using (SqlConnection myConnection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand("GetAllUsers_SP", myConnection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    myConnection.Open();
                    SqlDataAdapter sda1 = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    
                    sda1.Fill(dt);
                    gvViewAllUsers.DataSource = dt;
                    gvViewAllUsers.DataBind();
                    //command.Parameters.Add(new SqlParameter("@UserID", userID));
                    return command.ExecuteNonQuery();


                }
            }
        }


    }
}