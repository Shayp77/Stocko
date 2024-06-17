using StockoApp.Controller;
using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockoApp.Views
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User currentuser = null;
            if (Session["user_session"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/Login.aspx");
                return;
            }

            if (Session["user_session"] == null)
            {
                string aid = Request.Cookies["user_cookie"].Value;

                if (int.TryParse(aid, out int nid))
                {
                    currentuser = UserController.findbyid(nid);
                    Session["user_session"] = currentuser;
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                    return;
                }
            }
            else
            {
                currentuser = Session["user_session"] as User;
            }
            UserController cons = new UserController();
            User currentUser = Session["user_session"] as User;
            int id = currentUser.UserID;
            if (!IsPostBack)
            {
                User user = cons.getbyid(id);
                if (user != null)
                {
                    usernameRegister.Text = user.Username;
                    emailRegister.Text = user.UserEmail;            
                    dobCalendar.SelectedDate = user.UserDOB;
                    dobCalendar.VisibleDate = user.UserDOB;

                }
            }
        }

        protected void updatepassword_Click(object sender, EventArgs e)
        {
            User currentUser = Session["user_session"] as User;
            int id = currentUser.UserID;
            UserController cons = new UserController();
            string password = passwordRegister.Text;
            string newpass = newpasswordrupdate.Text;
            string errmess = cons.validatepassword(currentUser, password, newpass);

            if (!string.IsNullOrEmpty(errmess))
            {
                passerr.Text = errmess;
                passerr.ForeColor = System.Drawing.Color.Red;
            }
            else
            {

                cons.updatepass(id, newpass);
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            string username = usernameRegister.Text;
            string email = emailRegister.Text;
            DateTime dateOfBirth = dobCalendar.SelectedDate;
            UserController cons = new UserController();

            string errmess = cons.validateprofile(username, email, dateOfBirth);


            if (!string.IsNullOrEmpty(errmess))
            {
                updateerror.Text = errmess;
                updateerror.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                User currentUser = Session["user_session"] as User;

                cons.updatebyid(currentUser, username, email, dateOfBirth);
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }
    }
}