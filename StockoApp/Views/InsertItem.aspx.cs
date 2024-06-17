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
    public partial class InsertItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_session"] == null)
            {
                if (Request.Cookies["user_cookie"] == null)
                {
                    Response.Redirect("~/Views/Login.aspx");
                    return;
                }

                string userCookieValue = Request.Cookies["user_cookie"].Value;
                if (int.TryParse(userCookieValue, out int userID))
                {
                    Session["user_session"] = UserController.findbyid(userID);
                }
                else
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                    return;
                }
            }

            User user = (User)Session["user_session"];
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageItem.aspx");

        }

        protected void insertiteme_Click(object sender, EventArgs e)
        {
            string name = itemnamtb.Text;
            int price = Convert.ToInt32(pricetb.Text);
            int type = Convert.ToInt32(typetb.Text);
            string errmess = ItemController.ItemValidation(name, price, type);
            User curr = Session["user_session"] as User;
            int id = curr.UserID;

            if (errmess != "")
            {
                ErrLbl.Text = errmess;
                ErrLbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                ItemController.insertItem(name, price, type, id);
                Response.Redirect("~/Views/ManageItem.aspx");
            }
        }
    }
}