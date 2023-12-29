using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class GlobalVar
    {
        public static string strDBConnectionString = "";
        public static bool is登入成功 = false;
        public static string 使用者名稱 = "";
        public static string 員工名稱 = "";

        public static List<ArrayList> list訂購品項資料集合 = new List<ArrayList>();

        public static int 取得的users_Id = 0;
        public static int 取得的cpu_Id = 0;
        public static int 取得的mb_Id = 0;
        public static int 取得的ram_Id = 0;
        public static int 取得的ssd_Id = 0;
        public static int 取得的vga_Id = 0;
        public static int 取得的psu_Id = 0;
        public static int 取得的case_Id = 0;
        public static int 取得的order_Id = 0;


        public static double 小計CpuPrice = 0;
        public static double 小計MbPrice = 0;
        public static double 小計RamPrice = 0;
        public static double 小計SsdPrice = 0;
        public static double 小計VgaPrice = 0;
        public static double 小計PsuPrice = 0;
        public static double 小計CasePrice = 0;
        public static double 小計TotalPrice = 0;


        public static double 單價CpuPrice = 0;
        public static double 單價MbPrice = 0;
        public static double 單價RamPrice = 0;
        public static double 單價SsdPrice = 0;
        public static double 單價VgaPrice = 0;
        public static double 單價PsuPrice = 0;
        public static double 單價CasePrice = 0;

        public static UserControlOrder 電腦估價單 = new UserControlOrder();
        public static FormMain 首頁 = new FormMain();
        public static FormLogin 登入 = new FormLogin();
        public static UserControlRegister 註冊 = new UserControlRegister();
        public static UserControlProduct 產品管理 = new UserControlProduct();
        public static userControlCheckOut 確認訂單頁面 = new userControlCheckOut();
        public static UserControlUsers 會員管理 = new UserControlUsers();
        public static UserControlOrders 訂單管理 = new UserControlOrders();
     }
}
