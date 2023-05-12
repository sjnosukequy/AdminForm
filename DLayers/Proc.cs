using AdminForm.BLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AdminForm.DLayers
{
    internal class Proc
    {
        DBMain Main = new DBMain();
        public bool AddRES(string User, string ShowID, int Seat)
        {
            string sql = $"exec Sp_AddReservation '{User}', '{ShowID}', '{Seat}";
            return Main.ExecuteNoTable(sql);
        }
        public bool AddShowTime(string ShowTimeID, string MovieID, string Date, string Start, string RoomID)
        {
            string sql = $"EXEC Sp_AddNewShowTime '{ShowTimeID}', '{MovieID}', '{Date}', '{Start}', '{RoomID}'";
            return Main.ExecuteNoTable(sql);
        }
        public bool AddMov(string ID, string Name, int Cost, string Time, string Actor, string Direc, string ComID)
        {
            string sql = $"EXEC Sp_AddNewMovie '{ID}', N'{Name}', '{Cost}', '{Time}', N'{Actor}', N'{Direc}', '{ComID}'";
            return Main.ExecuteNoTable(sql);
        }
        public bool AddCus(string ID, string Pass, string Name, string Email, string Addr, int Phone)
        {
            string sql = $"exec Sp_AddNewCustomer N'{ID}',N'{Pass}',N'{Name}',N'{Email}',N'{Addr}',{Phone}";
            return Main.ExecuteNoTable(sql);
        }
        public bool DelRES(int ID)
        {
            string sql = $"exec Sp_DelReservation '{ID}'";
            return Main.ExecuteNoTable(sql);
        }
    }
}
