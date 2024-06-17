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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User currentuser = null;
            if (Session["user_session"] != null && Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("~/Views/HomePage.aspx");
                return;
            }
            if (Session["user_session"] == null && Request.Cookies["user_cookie"] == null)
            {
                return;
            }
            if (Session["user_session"] != null)
            {
                Response.Redirect("~/Views/HomePage.aspx");

                return;
            }
            if (Session["user_session"] == null)
            {
                string id = Request.Cookies["user_cookie"].Value;

                if (int.TryParse(id, out int nid))
                {
                    currentuser = UserController.findbyid(nid);
                    Session["user_session"] = currentuser;
                    Response.Redirect("~/Views/HomePage.aspx");
                    return;
                }
            }
        }

        protected void SubmitLogin_Click(object sender, EventArgs e)
        {
            UserController cons = new UserController();
            string username = usernameLogin.Text;
            string password = passwordLogin.Text;
            Boolean rememeberme = rememberMeLogin.Checked;
            string errmess = cons.ValidateLogin(username, password);

            if (errmess != "")
            {
                errorLabel.Text = errmess;
                errorLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                User user = cons.getbyusername(username);
                Session["user_session"] = user;
                if (rememeberme)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.UserID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(12);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }

        protected void RegisterPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }
    }
}