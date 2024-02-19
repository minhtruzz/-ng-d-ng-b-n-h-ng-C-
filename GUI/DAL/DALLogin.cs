using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace DAL
{
    public class DALLogin
    {
        public DataTable CheckLogin(string username, string password)
        {
            DataTable table = new DataTable();
            string query = "SELECT * FROM TaiKhoan Where TenTK='"+ username+"' and MatKhau='"+password+"'";
            string scon = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlycuahang;Integrated Security=True";
            SqlConnection connection = new SqlConnection(scon);
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                connection.Close();  
            }
            catch (Exception ex)
            {

            }
            return table;
        }
        
    }
}
