using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_AdLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Admin_Click(object sender, EventArgs e)
    {
        string key1 = AdUserName.Text;
        string key2 = AdPassword.Text;
        if (key1 == "Admin" && key2 == "Admin")
        {
            Response.Cookies["Admin"]["name"] = key1;
            Response.Cookies["Admin"].Expires = DateTime.Now.AddDays(1);
            Response.Redirect("Index.aspx");
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('用户名或密码错误！');</script>");
            AdUserName.Text = "";
            AdPassword.Text = "";
         }
       
    }
}