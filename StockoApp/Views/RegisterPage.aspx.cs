using StockoApp.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockoApp.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LoginPage.aspx");
        }

        protected void SubmitRegister_Click(object sender, EventArgs e)
        {
            UserController cons = new UserController();
            string username = usernameRegister.Text;
            string password = passwordRegister.Text;
            string confpass = confirmPasswordRegister.Text;
            string email = emailRegister.Text;
            DateTime dateOfBirth = dobCalendar.SelectedDate;
            string role = "User";
            string errmess = cons.ValidateRegistration(username, password, confpass, email, dateOfBirth);

            if (!string.IsNullOrEmpty(errmess))
            {
                registerError.Text = errmess;
                registerError.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                
                cons.doregister(username, email, dateOfBirth, password, role);
                Response.Redirect("~/Views/LoginPage.aspx");
            }
        }
    }
}