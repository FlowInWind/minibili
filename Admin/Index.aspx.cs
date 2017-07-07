using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_UserManage_Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Admin"] != null)
        {

        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        if (Request.Cookies["Admin"] != null)
        {
            Response.Cookies["Admin"].Expires = DateTime.Now.AddDays(-1);
        }
        Response.Redirect("Login.aspx");
    }
}