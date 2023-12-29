using System;
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
    public partial class UserControlOrders : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        public UserControlOrders()
        {
            InitializeComponent();
        }

        private void UserControlOrders_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "csms";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
            產生訂單dgv();
            產生訂單明細dgv();
            cbox訂單狀態內容產生();

        }
        void 產生訂單dgv()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();

            string strSQL = "SELECT order_Id AS 訂單編號, users_Name AS 訂購人名稱, order_dateTime AS 訂購日期, order_address as 配送地址, order_Phone AS 訂購人電話, orderStatus_Name as 訂單狀態 FROM [order] INNER JOIN users ON [order].users_Id = users.users_Id  INNER JOIN orderStatus ON [order].orderStatus_Id = orderStatus.orderStatus_Id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgv訂單.DataSource = dt;
            reader.Close();
            con.Close();
        }
        void 產生訂單明細dgv()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();

            string strSQL = "Select [order].order_Id As 訂單編號, product_Name As 訂購產品, orderItems_totalPrice as 產品價格 from orderItems inner join [order] on [orderItems].order_Id = [order].order_Id Inner join product on orderItems.product_Id = product.product_Id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgv訂單明細.DataSource = dt;
            reader.Close();
            con.Close();
        }

        private void dgv訂單_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv訂單.SelectedCells.Count > 0)
            {
                string strSelectID = dgv訂單.Rows[e.RowIndex].Cells[0].Value.ToString();
                //string strSelectID = dgv會員.Rows[e.RowIndex].Cells["會員Id"].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "SELECT orderStatus_Name FROM [order] INNER JOIN orderStatus ON [order].orderStatus_Id = orderStatus.orderStatus_Id WHERE [order].order_Id = @orderId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@orderId", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    cbox訂單狀態.Text = reader["orderStatus_Name"].ToString();
                }
                reader.Close();
                con.Close();
            }
        }
        void cbox訂單狀態內容產生()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select orderStatus_Name from orderStatus;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            cbox訂單狀態.Items.Clear();
            while (reader.Read())
            {
                cbox訂單狀態.Items.Add(reader["orderStatus_Name"].ToString());
            }
            reader.Close();
            con.Close();
        }

        private void btn修改訂單狀態_Click(object sender, EventArgs e)
        {
            if (cbox訂單狀態.SelectedItem != null)
            {
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string selectedorderStatusName = cbox訂單狀態.SelectedItem.ToString();
                    int orderStatusId;
                    using (SqlCommand getorderStatusCmd = new SqlCommand("SELECT orderStatus_Id FROM orderStatus WHERE orderStatus_Name = @orderStatusName", con))
                    {
                        getorderStatusCmd.Parameters.AddWithValue("@orderStatusName", selectedorderStatusName);
                        orderStatusId = Convert.ToInt32(getorderStatusCmd.ExecuteScalar());
                    }

                    string updateQuery = "UPDATE [order] SET orderStatus_Id = @orderStatusId WHERE order_Id = @orderId";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@orderStatusId", orderStatusId);
                        updateCmd.Parameters.AddWithValue("@orderId", dgv訂單.SelectedRows[0].Cells[0].Value.ToString());
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show($"訂單狀態修改成功");
                        產生訂單dgv();
                        cbox訂單狀態.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }

        private void btn搜尋訂單_Click(object sender, EventArgs e)
        {
            if (txt欲搜尋訂單.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "SELECT order_Id AS 訂單編號, users_Name AS 訂購人名稱, order_dateTime AS 訂購日期, order_address as 配送地址, order_Phone AS 訂購人電話, orderStatus_Name as 訂單狀態 FROM [order] INNER JOIN users ON [order].users_Id = users.users_Id  INNER JOIN orderStatus ON [order].orderStatus_Id = orderStatus.orderStatus_Id where order_Id = @SearchId;";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", txt欲搜尋訂單.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    dgv訂單.DataSource = dt;
                }
                else
                {
                    dgv訂單.DataSource = null;
                    MessageBox.Show("查無此訂單");
                    產生訂單dgv();
                    txt欲搜尋訂單.Clear();
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn回復搜尋_Click(object sender, EventArgs e)
        {
            產生訂單dgv();
            txt欲搜尋訂單.Clear();
        }

        private void btn返回首頁_Click(object sender, EventArgs e)
        {
            Close();
            GlobalVar.首頁.Show();
        }
    }
}
