using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_UserManage : System.Web.UI.Page
{

    SqlConnection sqlcon;
    SqlCommand sqlcom;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["Admin"] != null)
        {

        }
        else
        {
            Response.Redirect("/Admin/Login.aspx");
        }
    }

    private void BindData()
    {
        string sqlstr = "select Id,Title,type,upuser,theupdate,info from Video";
        var connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["DefaultConnection"];
        sqlcon = new SqlConnection(connString.ConnectionString);
        SqlDataAdapter myda = new SqlDataAdapter(sqlstr, sqlcon);
        DataSet myds = new DataSet();
        sqlcon.Open();
        myda.Fill(myds);
        GridView1.DataSource = myds;
        GridView1.DataBind();
        sqlcon.Close();
    }


    protected void SearchVideo_Click(object sender, EventArgs e)
    {
        MiniBli.sqlUse search = new MiniBli.sqlUse();
        string table = "Video";
        string key = "";
        switch (DropDownList2.SelectedValue)
        {
            case "ID":
                key = "Id";
                break;
            case "标题":
                key = "Title";
                break;
            case "分类":
                key = "Type";
                break;
            case "上传者":
                key = "upuser";
                break;
            default:
                break;
        }
        string what = TextBox2.Text;
        DataTable dt = new DataTable();
        if (TextBox2.Text != "")
        {
            dt = search.doSearch(table, key, what, "", "Id,Title,type,upuser,theupdate,info");
        }
        else
        {
            dt = search.doSearch("select Id,Title,type,upuser,theupdate,info from Video");
        }
        DataSet ds = new DataSet();
        ds.Tables.Add(dt);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string what = GridView1.Rows[e.RowIndex].Cells[1].Text;
        MiniBli.sqlUse delete = new MiniBli.sqlUse();
        string table = "Video";
        string sql = $"delete from {table} where Id = '{what}' ";
        int i = delete.doDelete(sql);
        if (i != 0)
        {
            BindData();
        }
        Response.Write("<script>alert('删除成功！');</script>");
    }


}