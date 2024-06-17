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
    public partial class UpdateItemPage : System.Web.UI.Page
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
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    Item item = ItemController.finditembyid(id);
                    if (item != null)
                    {
                        ItemNameTB.Text = item.ItemName;
                        ItemPriceTB.Text = item.ItemPrice.ToString();
                        ItemTypeTB.Text = item.ItemTypeID.ToString();
                    }
                    else
                    {
                        Response.Redirect("~/Views/ManageItem.aspx");
                    }
                }
            }
        }

        
        protected void updateitem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            String name = ItemNameTB.Text;
            int price = Convert.ToInt32(ItemPriceTB.Text);
            int typeid = Convert.ToInt32(ItemTypeTB.Text);
            string errmess = ItemController.ItemValidation(name, price,
                typeid);


            if (!string.IsNullOrEmpty(errmess))
            {
                ErrorLbl.Text = errmess;
                ErrorLbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                ItemController.updateItem(id,name, price, typeid);
                Response.Redirect("~/Views/ManageItem.aspx");
            }
        }
    }

}