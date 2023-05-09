using AdminForm.BLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminForm.DLayers
{
    internal class Proc
    {
        DBMain Main = new DBMain();
        public bool AddRES(string User, string ShowID, int Seat)
        {
            string sql = "exec Sp_AddReservation '" + User + "','" + ShowID + "'," + Seat;
            return Main.ExecuteNoTable(sql);
        }
        public bool AddShowTime(string ShowTimeID, string MovieID, string Date, string Start, string End, string RoomID)
        {
            string sql = "EXEC Sp_AddNewShowTime @ShowTime_ID ='" + ShowTimeID
                + "', @Movie_ID = '" + MovieID
                + "', @Date = '" + Date
                + "', @Start_Time = '" + Start
                + "', @End_Time = '" + End
                + "', @Room_ID ='" + RoomID + "'";
            return Main.ExecuteNoTable(sql);
        }
        public bool AddMov(string ID, string Name, int Cost, string Time, string Actor, string Direc, string ComID)
        {
            string sql = "EXEC Sp_AddNewMovie  @Movie_ID = '" + ID
                + "', @Movie_Title = '" + Name
                + "', @Movie_Cost = " + Cost
                + " , @Runtime = '" + Time
                + "', @Main_Actor = '" + Actor
                + "', @Director = '" + Direc
                + "', @Company_ID = '" + ComID + "'";
            return Main.ExecuteNoTable(sql);
        }
        public bool DelRES(int ID)
        {
            string sql = "exec Sp_DelReservation "+ ID;
            return Main.ExecuteNoTable(sql);
        }
    }
}
