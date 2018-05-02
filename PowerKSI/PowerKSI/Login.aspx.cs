using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PowerKSI.BL;
using PowerKSI.Utils;

namespace PowerKSI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            tbxUsername.Focus();
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            DateTime lastLoginDate = DateTime.Now;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(tbxPassword.Text))
            {
                vs1.HeaderText = "Please enter username and password";
                return;
            }

            //users are faculty
            var users = UserGuiHelper.GetUserUsingUserNamePasswordAsDataTable(username, password);
            if (users.Rows.Count > 0)
            {
                var user = users.Rows[0];
                bool isAdmin = (bool)user["IsAdmin"];
                bool isInstructor = (bool) user["IsInstructor"];
                int userId = int.Parse(users.Rows[0]["Id"].ToString());
                string userName = users.Rows[0]["FullName"].ToString();

                if (isAdmin && isInstructor)
                {
                    SessionAdapter.SetAdminId(userId);
                    SessionAdapter.SetInstructorId(userId);
                    SessionAdapter.SetUserName(userName);
                    Response.Redirect("Student.aspx");
                }
                else if (isAdmin)
                {
                    SessionAdapter.SetAdminId(userId);
                    SessionAdapter.SetUserName(userName);
                    Response.Redirect("Student.aspx");
                }
                else if (isInstructor)
                {
                    SessionAdapter.SetInstructorId(userId);
                    SessionAdapter.SetUserName(userName);
                    Response.Redirect("Attendance.aspx");
                }
                else
                {  
                    
                }
            }
            else
            {
                ErrorMessage.Visible = true;
                FailureText.Text = "Username or password is incorrect! Please try again!";
            }

        }
    }
}