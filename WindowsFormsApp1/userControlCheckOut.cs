using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class userControlCheckOut : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBconnectionString = "";

        public userControlCheckOut()
        {
            InitializeComponent();
        }

        private void userControlCheckOut_Load(object sender, EventArgs e)
        {
            txt訂購人地址.Text = "";
            txt訂購人電話.Text = "";

            scsb.DataSource = @".";
            scsb.InitialCatalog = "csms";
            scsb.IntegratedSecurity = true;
            strDBconnectionString = scsb.ConnectionString;
        }

        private void btn確認訂購_Click(object sender, EventArgs e)
        {
            if (txt訂購人地址.Text != "" && txt訂購人電話.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                //string strSQL = "insert into order(user_Id , order_dateTime, order_address, order_phone, orderStatus_Id) VALUES (@UserId, @DateTime, @Address, @Phone, '1')";
                string strSQL = "INSERT INTO [order] ([users_Id], order_dateTime, order_address, order_phone, orderStatus_Id) VALUES (@UsersId, @DateTime, @Address, @Phone, '1'); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@UsersId", GlobalVar.取得的users_Id);
                cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);
                cmd.Parameters.AddWithValue("@Address", txt訂購人地址.Text);
                cmd.Parameters.AddWithValue("@Phone", txt訂購人電話.Text);

                int orderId = Convert.ToInt32(cmd.ExecuteScalar());
                GlobalVar.取得的order_Id = orderId;
                con.Close();

                if (GlobalVar.取得的cpu_Id != 0)
                {
                    //SqlConnection con = new SqlConnection(strDBconnectionString);
                    con.Open();
                    string insertQuery = "insert into orderItems (order_Id , product_Id , orderItems_totalPrice) VALUES (@OrderId, @ProductId, @Price)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@OrderId", GlobalVar.取得的order_Id);
                    insertCmd.Parameters.AddWithValue("@ProductId", GlobalVar.取得的cpu_Id);
                    insertCmd.Parameters.AddWithValue("@Price", GlobalVar.小計CpuPrice);
                    insertCmd.ExecuteNonQuery();
                    con.Close();
                }

                if (GlobalVar.取得的mb_Id != 0)
                {
                    //SqlConnection con = new SqlConnection(strDBconnectionString);
                    con.Open();
                    string insertQuery = "insert into orderItems (order_Id , product_Id , orderItems_totalPrice) VALUES (@OrderId, @ProductId, @Price)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@OrderId", GlobalVar.取得的order_Id);
                    insertCmd.Parameters.AddWithValue("@ProductId", GlobalVar.取得的mb_Id);
                    insertCmd.Parameters.AddWithValue("@Price", GlobalVar.小計MbPrice);
                    insertCmd.ExecuteNonQuery();
                    con.Close();
                }
                if (GlobalVar.取得的ram_Id != 0)
                {
                    //SqlConnection con = new SqlConnection(strDBconnectionString);
                    con.Open();
                    string insertQuery = "insert into orderItems (order_Id , product_Id , orderItems_totalPrice) VALUES (@OrderId, @ProductId, @Price)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@OrderId", GlobalVar.取得的order_Id);
                    insertCmd.Parameters.AddWithValue("@ProductId", GlobalVar.取得的ram_Id);
                    insertCmd.Parameters.AddWithValue("@Price", GlobalVar.小計RamPrice);
                    insertCmd.ExecuteNonQuery();
                    con.Close();
                }
                if (GlobalVar.取得的ssd_Id != 0)
                {
                    //SqlConnection con = new SqlConnection(strDBconnectionString);
                    con.Open();
                    string insertQuery = "insert into orderItems (order_Id , product_Id , orderItems_totalPrice) VALUES (@OrderId, @ProductId, @Price)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@OrderId", GlobalVar.取得的order_Id);
                    insertCmd.Parameters.AddWithValue("@ProductId", GlobalVar.取得的ssd_Id);
                    insertCmd.Parameters.AddWithValue("@Price", GlobalVar.小計SsdPrice);
                    insertCmd.ExecuteNonQuery();
                    con.Close();
                }
                if (GlobalVar.取得的vga_Id != 0)
                {
                    //SqlConnection con = new SqlConnection(strDBconnectionString);
                    con.Open();
                    string insertQuery = "insert into orderItems (order_Id , product_Id , orderItems_totalPrice) VALUES (@OrderId, @ProductId, @Price)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@OrderId", GlobalVar.取得的order_Id);
                    insertCmd.Parameters.AddWithValue("@ProductId", GlobalVar.取得的vga_Id);
                    insertCmd.Parameters.AddWithValue("@Price", GlobalVar.小計VgaPrice);
                    insertCmd.ExecuteNonQuery();
                    con.Close();
                }
                if (GlobalVar.取得的psu_Id != 0)
                {
                    //SqlConnection con = new SqlConnection(strDBconnectionString);
                    con.Open();
                    string insertQuery = "insert into orderItems (order_Id , product_Id , orderItems_totalPrice) VALUES (@OrderId, @ProductId, @Price)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@OrderId", GlobalVar.取得的order_Id);
                    insertCmd.Parameters.AddWithValue("@ProductId", GlobalVar.取得的psu_Id);
                    insertCmd.Parameters.AddWithValue("@Price", GlobalVar.小計PsuPrice);
                    insertCmd.ExecuteNonQuery();
                    con.Close();
                }
                if (GlobalVar.取得的case_Id != 0)
                {
                    //SqlConnection con = new SqlConnection(strDBconnectionString);
                    con.Open();
                    string insertQuery = "insert into orderItems (order_Id , product_Id , orderItems_totalPrice) VALUES (@OrderId, @ProductId, @Price)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@OrderId", GlobalVar.取得的order_Id);
                    insertCmd.Parameters.AddWithValue("@ProductId", GlobalVar.取得的case_Id);
                    insertCmd.Parameters.AddWithValue("@Price", GlobalVar.小計CasePrice);
                    insertCmd.ExecuteNonQuery();
                    con.Close();
                }
                //con.Open();
                //string strpriceSQL = "INSERT INTO [order](order_totalPrice) VALUES (@totalPrice);";
                //SqlCommand pricecmd = new SqlCommand(strpriceSQL, con);
                //pricecmd.Parameters.AddWithValue("@totalPrice", GlobalVar.小計CpuPrice + GlobalVar.小計MbPrice + GlobalVar.小計RamPrice + GlobalVar.小計SsdPrice + GlobalVar.小計VgaPrice + GlobalVar.小計PsuPrice + GlobalVar.小計CasePrice);
                //con.Close();
                MessageBox.Show("訂購成功!");
                Close();
                GlobalVar.電腦估價單.Show();
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }

        private void btn返回估價單頁面_Click(object sender, EventArgs e)
        {
            this.Close();
            GlobalVar.電腦估價單.Show();
        }
    }
}
