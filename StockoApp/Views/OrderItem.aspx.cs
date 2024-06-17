using StockoApp.Controller;
using StockoApp.Handler;
using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockoApp.Views
{
    public partial class OrderItem : System.Web.UI.Page
    {
        public List<Item> item = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            User currentuser = null;
            if (Session["user_session"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/LoginPage.aspx");
                return;
            }

            if (Session["user_session"] == null)
            {
                string id = Request.Cookies["user_cookie"].Value;

                if (int.TryParse(id, out int nid))
                {
                    currentuser = UserController.findbyid(nid);
                    Session["user_session"] = currentuser;
                }
                else
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
                    return;
                }
            }
            else
            {
                currentuser = Session["user_session"] as User;
            }

            if (!IsPostBack)
            {
                int uid = currentuser.UserID;
                item = ItemController.getbyuserid(uid);
                ItemGV.DataSource = item;
                ItemGV.DataBind();
            }
        }

        protected void CheckoutButton_Click(object sender, EventArgs e)
        {
            User currentUser = Session["user_session"] as User;
            DateTime dt = DateTime.Now;
            int userid = currentUser.UserID;
            int tid = TransactionHController.generatetransactionid();
            TransactionHController th = new TransactionHController();
            th.InsertTransactionHeader(tid, userid, dt);
            List<Cart> cartitems = CartController.getallcart();
            foreach (var item in cartitems)
            {
                TransactionDController td = new TransactionDController();
                td.InsertTransactionDetail(tid, item.ItemID, item.Quantity);
            }
            OrderController.DeleteAllItemsFromCart();
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void cleartransaction_Click(object sender, EventArgs e)
        {
            OrderController.DeleteAllItemsFromCart();
        }


        protected void ItemGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Order")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = ItemGV.Rows[rowIndex];

                TextBox quantityTextBox = (TextBox)row.FindControl("QuantityTextBox");
                if (quantityTextBox != null)
                {
                    int quantity;
                    if (int.TryParse(quantityTextBox.Text, out quantity) && quantity > 0)
                    {
                        int itemid = Convert.ToInt32(ItemGV.DataKeys[rowIndex].Value);
                        User currentUser = Session["user_session"] as User;
                        if (currentUser != null)
                        {
                            int userId = currentUser.UserID;
                            CartController.InsertToCart(userId, itemid, quantity);

                            Response.Redirect("~/Views/OrderItem.aspx");
                        }
                        else
                        {
                            Debug.WriteLine("User is not logged in.");
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Invalid quantity entered.");
                    }
                }
                else
                {
                    Debug.WriteLine("QuantityTextBox not found.");
                }
            }
        }
    }
}