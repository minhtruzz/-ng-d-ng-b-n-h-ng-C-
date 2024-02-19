using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSLogin
    {
        DALLogin DALLogin = new DALLogin();
        public DataTable CheckLogin(string username, string password)
        {
            return DALLogin.CheckLogin(username,password);
        }
    }

}
