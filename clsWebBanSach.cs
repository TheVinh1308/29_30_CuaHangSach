using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _29_30_CuaHangSach
{
    class clsWebBanSach
    {
        SqlConnection con = new SqlConnection();

        void ketnoi()
        {
            con.ConnectionString = @"Data source =LAPTOP-05MS6OC1; Initial Catalog = quanlybansach; integrated Security = True";
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        void dongketnoi()
        {
            con.Close();
        }

        public clsWebBanSach()
        {
            ketnoi();
        }

        // dataSet chua nhieu bang
        // datatable chua 1 bang
        public DataSet layDuLieu(string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds); // fill load du lieu
            return ds;
        }

        // HAM UPDATE DATA
        public int capNhatDuLieu(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            return cmd.ExecuteNonQuery();
        }
    }
}
