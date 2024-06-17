using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockoApp.Layout
{
    public partial class NavBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");

        }

        protected void ItemManage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageItem.aspx");
        }

        protected void HistoryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionHistory.aspx");
        }


        protected void ProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ProfilePage.aspx");
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session["user_session"] = null;
            Session.Abandon();

            Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("~/Views/LoginPage.aspx");
        }

        protected void OrderItem_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/OrderItem.aspx");
        }
    }
}