using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AdminForm.BLayers;

namespace AdminForm.DLayers
{
    public class Views
    {
        DBMain Main = new DBMain();
        public DataSet ShowTime()
        {
            string sql = "select * from ShowTime";
            return Main.TableQuerry(sql);
        }
        public DataSet Movies()
        {
            string sql = "select * from Movie";
            return Main.TableQuerry(sql);
        }
        public DataSet Res()
        {
            string sql = "select * from Reservation";
            return Main.TableQuerry(sql);
        }
        public DataSet Emp()
        {
            string sql = "select * from User_Information A inner join Admin B on A.User_ID = B.User_ID";
            return Main.TableQuerry(sql);
        }
        public DataSet KH()
        {
            string sql = "select * from User_Information A inner join Customer B on A.User_ID = B.User_ID";
            return Main.TableQuerry(sql);
        }
        public DataSet ISVIP()
        {
            string sql = "select * from View_isVIP";
            return Main.TableQuerry(sql);
        }
        public DataSet NoVIP()
        {
            string sql = "select * from View_isNotVIP";
            return Main.TableQuerry(sql);
        }
        public DataSet ShowingInDay()
        {
            string sql = "select * from View_ShowingInDay";
            return Main.TableQuerry(sql);
        }
        public DataSet ComingShow()
        {
            string sql = "select * from View_ComingShowing";
            return Main.TableQuerry(sql);
        }
        public DataSet ClosedShow()
        {
            string sql = "select * from View_ClosedShowing";
            return Main.TableQuerry(sql);
        }
        public DataSet ShowInDayAva()
        {
            string sql = "select * from View_ShowingInDayAvailable";
            return Main.TableQuerry(sql);
        }
        public DataSet ShowInDayOut()
        {
            string sql = "select * from View_ShowingInDayOut";
            return Main.TableQuerry(sql);
        }
        public DataSet highRatingShow()
        {
            string sql = "select * from View_HighRatingShowing";
            return Main.TableQuerry(sql);
        }
    }
}
