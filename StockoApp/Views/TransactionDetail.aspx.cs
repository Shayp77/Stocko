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
    public partial class TransactionDetail : System.Web.UI.Page
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
                    string id = Request.Cookies["user_cookie"].Value;

                    if (int.TryParse(id, out int nid))
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

                List<Models.TransactionDetail> the = null;
                TransactionDController td = new TransactionDController();
                string transactionId = Request.QueryString["TransactionID"];
                int tid = Convert.ToInt32(transactionId);

                    the = TransactionDController.FindByTransactionId(tid);
               
                if (!IsPostBack)
                {
                    TransactionHController th = new TransactionHController();
                    DetailUser.DataSource = the;
                    DetailUser.DataBind();

                
            }
        }
    }
}