﻿using AdminForm.BLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AdminForm.DLayers
{
    internal class Proc
    {
        DBMain Main = new DBMain(1);
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
            string sql = $"exec Sp_DelReservation {ID}";
            return Main.ExecuteNoTable(sql);
        }
        public bool AddBaL(string ID, int Money)
        {
            string sql = $"update Customer set Balance = Balance + {Money} where User_ID = '{ID}'";
            return Main.ExecuteNoTable(sql);
        }
        public bool AddComp(string ID,string name,string email,string phone, string addr)
        {
            string sql = $"exec Sp_AddNewCompany '{ID}','{name}','{email}', '{phone}', '{addr}'";
            return Main.ExecuteNoTable(sql);
        }
        public bool AddRom(string ID, int seats, string res, string audio)
        {
            string sql = $"exec Sp_AddNewRoom '{ID}', {seats},'{res}','{audio}'";
            return Main.ExecuteNoTable(sql);
        }
    }
}
