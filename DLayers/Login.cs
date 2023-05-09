using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminForm.BLayers;

namespace AdminForm.DLayers
{
    internal class Login
    {
        DBMain Main = new DBMain();
        public bool Check(string User, string Pass)
        {
            string sql = "select * from Fn_AdminLogin('" + User + "','" + Pass + "')";
            DataSet data = Main.TableQuerry(sql);
            if (data.Tables[0].Rows.Count == 1)
                return true;
            return false;
        }
    }
}
