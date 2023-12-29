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
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class UserControlOrder : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBconnectionString = "";

        public UserControlOrder()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            txt會員姓名.Text = $"親愛的:{GlobalVar.使用者名稱}會員您好";
            scsb.DataSource = @".";
            scsb.InitialCatalog = "csms";
            scsb.IntegratedSecurity = true;
            strDBconnectionString = scsb.ConnectionString;

            cboxCPU處理器.Text = "---請選擇一樣產品---";
            cboxMB主機板.Text = "---請選擇一樣產品---";
            cboxRAM記憶體.Text = "---請選擇一樣產品---";
            cboxSSD硬碟.Text = "---請選擇一樣產品---";
            cboxVGA顯示卡.Text = "---請選擇一樣產品---";
            cboxPSU電源供應.Text = "---請選擇一樣產品---";
            cboxCASE機殼.Text = "---請選擇一樣產品---";

            cboxCpu數量.Items.Add(1);
            cboxCpu數量.Items.Add(2);
            cboxCpu數量.Items.Add(3);
            cboxCpu數量.Items.Add(4);
            cboxCpu數量.Items.Add(5);
            cboxCpu數量.SelectedIndex = 0;

            cboxMb數量.Items.Add(1);
            cboxMb數量.Items.Add(2);
            cboxMb數量.Items.Add(3);
            cboxMb數量.Items.Add(4);
            cboxMb數量.Items.Add(5);
            cboxMb數量.SelectedIndex = 0;

            cboxRam數量.Items.Add(1);
            cboxRam數量.Items.Add(2);
            cboxRam數量.Items.Add(3);
            cboxRam數量.Items.Add(4);
            cboxRam數量.Items.Add(5);
            cboxRam數量.SelectedIndex = 0;

            cboxSsd數量.Items.Add(1);
            cboxSsd數量.Items.Add(2);
            cboxSsd數量.Items.Add(3);
            cboxSsd數量.Items.Add(4);
            cboxSsd數量.Items.Add(5);
            cboxSsd數量.SelectedIndex = 0;

            cboxVga數量.Items.Add(1);
            cboxVga數量.Items.Add(2);
            cboxVga數量.Items.Add(3);
            cboxVga數量.Items.Add(4);
            cboxVga數量.Items.Add(5);
            cboxVga數量.SelectedIndex = 0;

            cboxPsu數量.Items.Add(1);
            cboxPsu數量.Items.Add(2);
            cboxPsu數量.Items.Add(3);
            cboxPsu數量.Items.Add(4);
            cboxPsu數量.Items.Add(5);
            cboxPsu數量.SelectedIndex = 0;

            cboxCase數量.Items.Add(1);
            cboxCase數量.Items.Add(2);
            cboxCase數量.Items.Add(3);
            cboxCase數量.Items.Add(4);
            cboxCase數量.Items.Add(5);
            cboxCase數量.SelectedIndex = 0;

            cbox產品內容產生();
        }

        void cbox產品內容產生()
        {
            SqlConnection conCpu = new SqlConnection(strDBconnectionString);
            SqlConnection conMb = new SqlConnection(strDBconnectionString);
            SqlConnection conRam = new SqlConnection(strDBconnectionString);
            SqlConnection conSsd = new SqlConnection(strDBconnectionString);
            SqlConnection conVga = new SqlConnection(strDBconnectionString);
            SqlConnection conPsu = new SqlConnection(strDBconnectionString);
            SqlConnection conCase = new SqlConnection(strDBconnectionString);
            conCpu.Open();
            conMb.Open();
            conRam.Open();
            conSsd.Open();
            conVga.Open();
            conPsu.Open();
            conCase.Open();
            string strSQLCpu = "SELECT CONCAT(brand.brand_Name, ' ', product.product_Name, ' ', '售價:$', CAST(product.product_Price AS NVARCHAR(MAX))) as [cpu] FROM product INNER JOIN brand ON product.brand_Id = brand.brand_Id WHERE product.category_Id = '1';";
            string strSQLMb = "SELECT CONCAT(brand.brand_Name, ' ', product.product_Name, ' ', '售價:$', CAST(product.product_Price AS NVARCHAR(MAX))) as [mb] FROM product INNER JOIN brand ON product.brand_Id = brand.brand_Id WHERE product.category_Id = '2';";
            string strSQLRam = "SELECT CONCAT(brand.brand_Name, ' ', product.product_Name, ' ', '售價:$', CAST(product.product_Price AS NVARCHAR(MAX))) as [ram] FROM product INNER JOIN brand ON product.brand_Id = brand.brand_Id WHERE product.category_Id = '5';";
            string strSQLSsd = "SELECT CONCAT(brand.brand_Name, ' ', product.product_Name, ' ', '售價:$', CAST(product.product_Price AS NVARCHAR(MAX))) as [ssd] FROM product INNER JOIN brand ON product.brand_Id = brand.brand_Id WHERE product.category_Id = '6';";
            string strSQLVga = "SELECT CONCAT(brand.brand_Name, ' ', product.product_Name, ' ', '售價:$', CAST(product.product_Price AS NVARCHAR(MAX))) as [vga] FROM product INNER JOIN brand ON product.brand_Id = brand.brand_Id WHERE product.category_Id = '7';";
            string strSQLPsu = "SELECT CONCAT(brand.brand_Name, ' ', product.product_Name, ' ', '售價:$', CAST(product.product_Price AS NVARCHAR(MAX))) as [psu] FROM product INNER JOIN brand ON product.brand_Id = brand.brand_Id WHERE product.category_Id = '8';";
            string strSQLCase = "SELECT CONCAT(brand.brand_Name, ' ', product.product_Name, ' ', '售價:$', CAST(product.product_Price AS NVARCHAR(MAX))) as [case] FROM product INNER JOIN brand ON product.brand_Id = brand.brand_Id WHERE product.category_Id = '9';";

            SqlCommand cmdCpu = new SqlCommand(strSQLCpu, conCpu);
            SqlCommand cmdMb = new SqlCommand(strSQLMb, conMb);
            SqlCommand cmdRam = new SqlCommand(strSQLRam, conRam);
            SqlCommand cmdSsd = new SqlCommand(strSQLSsd, conSsd);
            SqlCommand cmdVga = new SqlCommand(strSQLVga, conVga);
            SqlCommand cmdPsu = new SqlCommand(strSQLPsu, conPsu);
            SqlCommand cmdCase = new SqlCommand(strSQLCase, conCase);

            SqlDataReader readerCpu = cmdCpu.ExecuteReader();
            SqlDataReader readerMb = cmdMb.ExecuteReader();
            SqlDataReader readerRam = cmdRam.ExecuteReader();
            SqlDataReader readerSsd = cmdSsd.ExecuteReader();
            SqlDataReader readerVga = cmdVga.ExecuteReader();
            SqlDataReader readerPsu = cmdPsu.ExecuteReader();
            SqlDataReader readerCase = cmdCase.ExecuteReader();

            while (readerCpu.Read())
            {
                cboxCPU處理器.Items.Add(readerCpu["cpu"].ToString());
            }
            while (readerMb.Read())
            {
                cboxMB主機板.Items.Add(readerMb["mb"].ToString());
            }
            while (readerRam.Read())
            {
                cboxRAM記憶體.Items.Add(readerRam["ram"]).ToString();
            }
            while (readerSsd.Read())
            {
                cboxSSD硬碟.Items.Add(readerSsd["ssd"]).ToString();
            }
            while (readerVga.Read())
            {
                cboxVGA顯示卡.Items.Add(readerVga["vga"]).ToString();
            }
            while (readerPsu.Read())
            {
                cboxPSU電源供應.Items.Add(readerPsu["psu"]).ToString();
            }
            while (readerCase.Read())
            {
                cboxCASE機殼.Items.Add(readerCase["case"]).ToString();
            }
            readerCpu.Close();
            readerMb.Close();
            readerRam.Close();
            readerSsd.Close();
            readerVga.Close();
            readerPsu.Close();
            readerCase.Close();
            conCpu.Close();
            conMb.Close();
            conRam.Close();
            conSsd.Close();
            conVga.Close();
            conPsu.Close();
            conCase.Close();
        }

        void 單價小計cpu()
        {
            lblCpu小計.Text = $"{GlobalVar.小計CpuPrice.ToString()}元";
            lblCpu單價.Text = $"{GlobalVar.單價CpuPrice.ToString()}元";
        }
        void 單價小計Mb()
        {
            lblMb單價.Text = $"{GlobalVar.單價MbPrice.ToString()}元";
            lblMb小計.Text = $"{GlobalVar.小計MbPrice.ToString()}元";
        }
        void 單價小計Ram()
        {
            lblRam單價.Text = $"{GlobalVar.單價RamPrice.ToString()}元";
            lblRam小計.Text = $"{GlobalVar.小計RamPrice.ToString()}元";
        }
        void 單價小計Ssd()
        {
            lblSsd單價.Text = $"{GlobalVar.單價SsdPrice.ToString()}元";
            lblSsd小計.Text = $"{GlobalVar.小計SsdPrice.ToString()}元";
        }
        void 單價小計Vga()
        {
            lblVga單價.Text = $"{GlobalVar.單價VgaPrice.ToString()}元";
            lblVga小計.Text = $"{GlobalVar.小計VgaPrice.ToString()}元";
        }
        void 單價小計Psu()
        {
            lblPsu單價.Text = $"{GlobalVar.單價PsuPrice.ToString()}元";
            lblPsu小計.Text = $"{GlobalVar.小計PsuPrice.ToString()}元";
        }
        void 單價小計Case()
        {
            lblCase單價.Text = $"{GlobalVar.單價CasePrice.ToString()}元";
            lblCase小計.Text = $"{GlobalVar.小計CasePrice.ToString()}元";
        }

        private void cboxCPU處理器_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 取得使用者選取的商品資訊
            string productInfo = cboxCPU處理器.SelectedItem.ToString();
            // 取得商品名稱
            string productName = productInfo.Split(' ')[1];
            // 取得商品價格
            double CpuproductPrice = 0;
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "SELECT product_Price FROM product WHERE product_Name = @productName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@productName", productName);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                CpuproductPrice = Convert.ToDouble(reader["product_Price"]);
            }
            reader.Close();
            con.Close();

            GlobalVar.單價CpuPrice = CpuproductPrice;
            GlobalVar.小計CpuPrice = CpuproductPrice * (int)cboxCpu數量.SelectedItem;
            計算總價();
            單價小計cpu();
        }

        private void cboxMB主機板_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productInfo = cboxMB主機板.SelectedItem.ToString();
            string productName = productInfo.Split(' ')[1];
            double MbproductPrice = 0;
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "SELECT product_Price FROM product WHERE product_Name = @productName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@productName", productName);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MbproductPrice = Convert.ToDouble(reader["product_Price"]);
            }
            reader.Close();
            con.Close();
            GlobalVar.單價MbPrice = MbproductPrice;
            GlobalVar.小計MbPrice = MbproductPrice * (int)cboxMb數量.SelectedItem;
            計算總價();
            單價小計Mb();
        }

        private void cboxRAM記憶體_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productInfo = cboxRAM記憶體.SelectedItem.ToString();
            string productName = productInfo.Split(' ')[1];
            double RamproductPrice = 0;
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "SELECT product_Price FROM product WHERE product_Name = @productName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@productName", productName);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                RamproductPrice = Convert.ToDouble(reader["product_Price"]);
            }
            reader.Close();
            con.Close();
            GlobalVar.單價RamPrice = RamproductPrice;
            GlobalVar.小計RamPrice = RamproductPrice * (int)cboxRam數量.SelectedItem;
            計算總價();
            單價小計Ram();
        }

        private void cboxSSD硬碟_SelectedIndexChanged(object sender, EventArgs e)
        {

            string productInfo = cboxSSD硬碟.SelectedItem.ToString();
            string productName = productInfo.Split(' ')[1];
            double SsdproductPrice = 0;
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "SELECT product_Price FROM product WHERE product_Name = @productName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@productName", productName);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                SsdproductPrice = Convert.ToDouble(reader["product_Price"]);
            }
            reader.Close();
            con.Close();
            GlobalVar.單價SsdPrice = SsdproductPrice;
            GlobalVar.小計SsdPrice = SsdproductPrice * (int)cboxSsd數量.SelectedItem;
            計算總價();
            單價小計Ssd();
        }

        private void cboxVGA顯示卡_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productInfo = cboxVGA顯示卡.SelectedItem.ToString();
            string productName = productInfo.Split(' ')[1];
            double VgaproductPrice = 0;
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "SELECT product_Price FROM product WHERE product_Name = @productName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@productName", productName);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                VgaproductPrice = Convert.ToDouble(reader["product_Price"]);
            }
            reader.Close();
            con.Close();
            GlobalVar.單價VgaPrice = VgaproductPrice;
            GlobalVar.小計VgaPrice = VgaproductPrice * (int)cboxVga數量.SelectedItem;
            計算總價();
            單價小計Vga();
        }

        private void cboxPSU電源供應_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productInfo = cboxPSU電源供應.SelectedItem.ToString();
            string productName = productInfo.Split(' ')[1];
            double PsuproductPrice = 0;
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "SELECT product_Price FROM product WHERE product_Name = @productName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@productName", productName);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                PsuproductPrice = Convert.ToDouble(reader["product_Price"]);
            }
            reader.Close();
            con.Close();
            GlobalVar.單價PsuPrice = PsuproductPrice;
            GlobalVar.小計PsuPrice = PsuproductPrice * (int)cboxPsu數量.SelectedItem;
            計算總價();
            單價小計Psu();
        }

        private void cboxCASE機殼_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productInfo = cboxCASE機殼.SelectedItem.ToString();
            string productName = productInfo.Split(' ')[1];
            double CaseproductPrice = 0;
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "SELECT product_Price FROM product WHERE product_Name = @productName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@productName", productName);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                CaseproductPrice = Convert.ToDouble(reader["product_Price"]);
            }
            reader.Close();
            con.Close();

            GlobalVar.單價CasePrice = CaseproductPrice;
            GlobalVar.小計CasePrice = CaseproductPrice * (int)cboxCase數量.SelectedItem;
            計算總價();
            單價小計Case();
        }
        void 計算總價()
        {
            lbl品項總價.Text = $"總價:{GlobalVar.小計CpuPrice + GlobalVar.小計MbPrice + GlobalVar.小計RamPrice + GlobalVar.小計SsdPrice + GlobalVar.小計VgaPrice + GlobalVar.小計PsuPrice + GlobalVar.小計CasePrice}元";
        }
        private void btn清空估價單_Click(object sender, EventArgs e)
        {
            cboxCPU處理器.Text = "---請選擇一樣產品---";
            cboxMB主機板.Text = "---請選擇一樣產品---";
            cboxRAM記憶體.Text = "---請選擇一樣產品---";
            cboxSSD硬碟.Text = "---請選擇一樣產品---";
            cboxVGA顯示卡.Text = "---請選擇一樣產品---";
            cboxPSU電源供應.Text = "---請選擇一樣產品---";
            cboxCASE機殼.Text = "---請選擇一樣產品---";
            cboxCpu數量.SelectedIndex = 0;
            cboxMb數量.SelectedIndex = 0;
            cboxRam數量.SelectedIndex = 0;
            cboxSsd數量.SelectedIndex = 0;
            cboxVga數量.SelectedIndex = 0;
            cboxPsu數量.SelectedIndex = 0;
            cboxCase數量.SelectedIndex = 0;
            lbl品項總價.Text = $"總價:0元";
            lblCpu小計.Text = $"0元";
            lblCpu單價.Text = $"0元";
            lblMb單價.Text = $"0元";
            lblMb小計.Text = $"0元";
            lblRam單價.Text = $"0元";
            lblRam小計.Text = $"0元";
            lblSsd單價.Text = $"0元";
            lblSsd小計.Text = $"0元";
            lblVga單價.Text = $"0元";
            lblVga小計.Text = $"0元";
            lblPsu單價.Text = $"0元";
            lblPsu小計.Text = $"0元";
            lblCase單價.Text = $"0元";
            lblCase小計.Text = $"0元";
        }

        private void cboxCpu數量_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVar.小計CpuPrice = GlobalVar.單價CpuPrice * (int)cboxCpu數量.SelectedItem;
            計算總價();
            單價小計cpu();
        }

        private void cboxMb數量_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVar.小計MbPrice = GlobalVar.單價MbPrice * (int)cboxMb數量.SelectedItem;
            計算總價();
            單價小計Mb();
        }

        private void cboxRam數量_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVar.小計RamPrice = GlobalVar.單價RamPrice * (int)cboxRam數量.SelectedItem;
            計算總價();
            單價小計Ram();
        }

        private void cboxSsd數量_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVar.小計SsdPrice = GlobalVar.單價SsdPrice * (int)cboxSsd數量.SelectedItem;
            計算總價();
            單價小計Ssd();
        }

        private void cboxVga數量_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVar.小計VgaPrice = GlobalVar.單價VgaPrice * (int)cboxVga數量.SelectedItem;
            計算總價();
            單價小計Vga();
        }

        private void cboxPsu數量_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVar.小計PsuPrice = GlobalVar.單價PsuPrice * (int)cboxPsu數量.SelectedItem;
            計算總價();
            單價小計Psu();
        }

        private void cboxCase數量_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVar.小計CasePrice = GlobalVar.單價CasePrice * (int)cboxCase數量.SelectedItem;
            計算總價();
            單價小計Case();
        }

        private void btn返回首頁_Click(object sender, EventArgs e)
        {
            Close();
            GlobalVar.登入.Show();
        }

        private void btn下單_Click(object sender, EventArgs e)
        {
            //抓取UserId放入GlobalVar
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();

            int usersId;
            using (SqlCommand getusersIdCmd = new SqlCommand("SELECT users_Id FROM users WHERE users_Name = @usersName", con))
            {
                getusersIdCmd.Parameters.AddWithValue("@usersName", GlobalVar.使用者名稱);
                usersId = Convert.ToInt32(getusersIdCmd.ExecuteScalar());
                GlobalVar.取得的users_Id = usersId;
            }

            if (cboxCPU處理器.SelectedItem != null)
            {
                string selectedProductName = cboxCPU處理器.SelectedItem.ToString();
                string productName = selectedProductName.Split(' ')[1];
                int cpuProductId;
                using (SqlCommand getproductIdCmd = new SqlCommand("SELECT product_Id FROM product WHERE product_Name = @productName", con))
                {
                    getproductIdCmd.Parameters.AddWithValue("@productName", productName);   
                    cpuProductId = Convert.ToInt32(getproductIdCmd.ExecuteScalar());
                    GlobalVar.取得的cpu_Id = cpuProductId;
                    //MessageBox.Show("CPU ID: " + GlobalVar.取得的cpu_Id);
                }
            }

            if (cboxMB主機板.SelectedItem != null)
            {
                string selectedProductName = cboxMB主機板.SelectedItem.ToString();
                string productName = selectedProductName.Split(' ')[1];
                int ProductId;
                using (SqlCommand getproductIdCmd = new SqlCommand("SELECT product_Id FROM product WHERE product_Name = @productName", con))
                {
                    getproductIdCmd.Parameters.AddWithValue("@productName", productName);
                    ProductId = Convert.ToInt32(getproductIdCmd.ExecuteScalar());
                    GlobalVar.取得的mb_Id = ProductId;
                }
            }

            if (cboxRAM記憶體.SelectedItem != null)
            {
                string selectedProductName = cboxRAM記憶體.SelectedItem.ToString();
                string productName = selectedProductName.Split(' ')[1];
                int ProductId;
                using (SqlCommand getproductIdCmd = new SqlCommand("SELECT product_Id FROM product WHERE product_Name = @productName", con))
                {
                    getproductIdCmd.Parameters.AddWithValue("@productName", productName);
                    ProductId = Convert.ToInt32(getproductIdCmd.ExecuteScalar());
                    GlobalVar.取得的ram_Id = ProductId;
                }
            }

            if (cboxSSD硬碟.SelectedItem != null)
            {
                string selectedProductName = cboxSSD硬碟.SelectedItem.ToString();
                string productName = selectedProductName.Split(' ')[1];
                int ProductId;
                using (SqlCommand getproductIdCmd = new SqlCommand("SELECT product_Id FROM product WHERE product_Name = @productName", con))
                {
                    getproductIdCmd.Parameters.AddWithValue("@productName", productName);
                    ProductId = Convert.ToInt32(getproductIdCmd.ExecuteScalar());
                    GlobalVar.取得的ssd_Id = ProductId;
                }
            }

            if (cboxVGA顯示卡.SelectedItem != null)
            {
                string selectedProductName = cboxVGA顯示卡.SelectedItem.ToString();
                string productName = selectedProductName.Split(' ')[1];
                int ProductId;
                using (SqlCommand getproductIdCmd = new SqlCommand("SELECT product_Id FROM product WHERE product_Name = @productName", con))
                {
                    getproductIdCmd.Parameters.AddWithValue("@productName", productName);
                    ProductId = Convert.ToInt32(getproductIdCmd.ExecuteScalar());
                    GlobalVar.取得的vga_Id = ProductId;
                }
            }

            if (cboxPSU電源供應.SelectedItem != null)
            {
                string selectedProductName = cboxPSU電源供應.SelectedItem.ToString();
                string productName = selectedProductName.Split(' ')[1];
                int ProductId;
                using (SqlCommand getproductIdCmd = new SqlCommand("SELECT product_Id FROM product WHERE product_Name = @productName", con))
                {
                    getproductIdCmd.Parameters.AddWithValue("@productName", productName);
                    ProductId = Convert.ToInt32(getproductIdCmd.ExecuteScalar());
                    GlobalVar.取得的psu_Id = ProductId;
                }
            }

            if (cboxCASE機殼.SelectedItem != null)
            {
                string selectedProductName = cboxCASE機殼.SelectedItem.ToString();
                string productName = selectedProductName.Split(' ')[1];
                int ProductId;
                using (SqlCommand getproductIdCmd = new SqlCommand("SELECT product_Id FROM product WHERE product_Name = @productName", con))
                {
                    getproductIdCmd.Parameters.AddWithValue("@productName", productName);
                    ProductId = Convert.ToInt32(getproductIdCmd.ExecuteScalar());
                    GlobalVar.取得的case_Id = ProductId;
                }
            }
            this.Hide();
            cboxCPU處理器.Text = "---請選擇一樣產品---";
            cboxMB主機板.Text = "---請選擇一樣產品---";
            cboxRAM記憶體.Text = "---請選擇一樣產品---";
            cboxSSD硬碟.Text = "---請選擇一樣產品---";
            cboxVGA顯示卡.Text = "---請選擇一樣產品---";
            cboxPSU電源供應.Text = "---請選擇一樣產品---";
            cboxCASE機殼.Text = "---請選擇一樣產品---";
            cboxCpu數量.SelectedIndex = 0;
            cboxMb數量.SelectedIndex = 0;
            cboxRam數量.SelectedIndex = 0;
            cboxSsd數量.SelectedIndex = 0;
            cboxVga數量.SelectedIndex = 0;
            cboxPsu數量.SelectedIndex = 0;
            cboxCase數量.SelectedIndex = 0;
            lbl品項總價.Text = $"總價:0元";
            lblCpu小計.Text = $"0元";
            lblCpu單價.Text = $"0元";
            lblMb單價.Text = $"0元";
            lblMb小計.Text = $"0元";
            lblRam單價.Text = $"0元";
            lblRam小計.Text = $"0元";
            lblSsd單價.Text = $"0元";
            lblSsd小計.Text = $"0元";
            lblVga單價.Text = $"0元";
            lblVga小計.Text = $"0元";
            lblPsu單價.Text = $"0元";
            lblPsu小計.Text = $"0元";
            lblCase單價.Text = $"0元";
            lblCase小計.Text = $"0元";
            GlobalVar.確認訂單頁面.ShowDialog();
        }
    }
}
