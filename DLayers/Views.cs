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
            string sql = "select A.*, B.Screen_Resolution, B.Audio_Quality from ShowTime A join Room B on A.Room_ID = B.Room_ID";
            return Main.TableQuerry(sql);
        }
        public DataSet Movies()
        {
            string sql = "select B.*, A.Name from Company A inner join Movie B on A.Company_ID = B.Company_ID";
            return Main.TableQuerry(sql);
        }
        public DataSet Company()
        {
            string sql = "select * from Company";
            return Main.TableQuerry(sql);
        }
        public DataSet Res()
        {
            string sql = "select * from Reservation";
            return Main.TableQuerry(sql);
        }
        public DataSet Emp()
        {
            string sql = "select A.*, B.Password, B.Role from User_Information A inner join Admin B on A.User_ID = B.User_ID";
            return Main.TableQuerry(sql);
        }
        public DataSet KH()
        {
            string sql = "select A.*, B.Password, B.Balance, B.Point, B.isVIP from User_Information A inner join Customer B on A.User_ID = B.User_ID";
            return Main.TableQuerry(sql);
        }
        public DataSet Rev()
        {
            string sql = "select * from View_Comments";
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
