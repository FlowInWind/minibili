using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// 从其他类接受对数据库的操作请求，返回查询结果或命令执行结果
/// </summary>
namespace MiniBli
{
    public class sqlUse
    {
        //protected string table { get; set; }
        // protected string key { get; set; }
        protected string setting { get; set; }
        public sqlUse(string setting = "DefaultConnection")
        {
            this.setting = setting;
        }
        //向table表中，查询字段key的值为what的行，查询的结果存储于datatable对象中返回
        public DataTable doSearch(string table, string key, string what, string extra = "", string colmNames = "*")
        {
            //  string setting = "DefaultConnection";
            var connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings[setting];
            SqlConnection conn = new SqlConnection(connString.ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select {colmNames} from {table} where {key}=N'{what}' {extra}";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable doSearch(string sql)
        {
            //  string setting = "DefaultConnection";
            var connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings[setting];
            SqlConnection conn = new SqlConnection(connString.ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        //向User类型的table表中，删除字段key的值为what的行
        public int doDelete(string sql)
        {
            //  string setting = "DefaultConnection";
            var connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings[setting];
            SqlConnection conn = new SqlConnection(connString.ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
    }
}