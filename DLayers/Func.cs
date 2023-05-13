using AdminForm.BLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminForm.DLayers
{
    public class Func
    {
        DBMain Main = new DBMain();
        public DataSet UserCommented(string ID)
        {
            string sql = $"select * from Fn_UserCommented('{ID}')";
            return Main.TableQuerry(sql);   
        }
        public DataSet Userinfo(string ID)
        {
            string sql = $"select * from Fn_UserInformation('{ID}')";
            return Main.TableQuerry(sql);
        }
        public DataSet MovieRating(string ShowID)
        {
            string sql = $"select * from Fn_MovieRating('{ShowID}')";
            return Main.TableQuerry(sql);
        }
        public DataSet ActorMovie(string Name)
        {
            string sql = $"select * from Fn_ShowTimebyActor('{Name}')";
            return Main.TableQuerry(sql);
        }
        public DataSet CompMovie(string Name)
        {
            string sql = $"select * from Fn_ShowTimebyCompany('{Name}')";
            return Main.TableQuerry(sql);
        }
        public DataSet ResMovie(string Name)
        {
            string sql = $"select * from Fn_ShowTimebyScreen('{Name}')";
            return Main.TableQuerry(sql);
        }
    }
}
