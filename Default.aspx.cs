using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MiniBli.sqlUse search = new MiniBli.sqlUse();
        string table = "AspNetUsers";
        string key = "IsAdmin";
        string what = "0";
        DataTable dt = search.doSearch(table, key, what);
        TextBox1.Text = dt.Rows[0]["IsAdmin"].ToString();
    }
}