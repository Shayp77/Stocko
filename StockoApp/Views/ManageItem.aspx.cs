using StockoApp.Controller;
using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockoApp.Views
{
    public partial class ManageItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_session"] == null)
            {
                if (Request.Cookies["user_cookie"] == null)
                {
                    Response.Redirect("~/Views/LoginPage.aspx");
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

            User user = Session["user_session"] as User;
            int id = user.UserID;          

            if (!IsPostBack)
            {
                GridView1.DataSource = ItemController.getbyuserid(id);
                GridView1.DataBind();

                Type.DataSource = ItemController.getAllItemType();
                Type.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            User user = Session["user_session"] as User;
            ItemController.RemoveItembyid(id);
            int uid = user.UserID;
            GridView1.DataSource = ItemController.getbyuserid(uid);
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text);
            String mid = id.ToString();
            Response.Redirect("~/Views/UpdateItemPage.aspx?id=" + mid);
        }

        protected void Type_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = Type.Rows[e.NewEditIndex];
            String id = row.Cells[0].Text;
            Response.Redirect("~/Views/UpdateItemType.aspx?id=" + id);
        }

        protected void Type_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = Type.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            ItemController.removeitemtypebyid(id);
            Type.DataSource = ItemController.getAllItemType();
            Type.DataBind();
        }

        protected void iteminsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertItem.aspx");

        }

        protected void typeinsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertType.aspx");

        }
    }
}