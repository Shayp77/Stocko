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
    public partial class InsertType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user_session"] == null && Response.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/LoginPage.aspx");
            }
            else
            {
                User user = new User();
                if (Session["user_session"] == null)
                {
                    int userID = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                    user = UserController.findbyid(userID);
                    Session["user_session"] = user;
                }
                else
                {
                    user = (User)Session["user_session"];
                }
                if (user == null)
                {
                   
                    Response.Redirect("~/Views/LoginPage.aspx");
                }
            }
        }


        protected void itemtypeinser_Click(object sender, EventArgs e)
        {
            int id = ItemController.generateTypeID();
            String name = itemtypenametb.Text;

            string errmess = ItemController.ItemTypeValidation(name);


            if (!string.IsNullOrEmpty(errmess))
            {
                ErrorLbl.Text = errmess;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                ItemController.inserttype(id, name);

                Response.Redirect("~/Views/ManageItem.aspx");
            }
        }
    }
}