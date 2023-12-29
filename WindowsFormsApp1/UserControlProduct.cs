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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;

namespace WindowsFormsApp1
{
    public partial class UserControlProduct : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";

        public UserControlProduct()
        {
            InitializeComponent();
        }

        private void UserControlProduct_Load(object sender, EventArgs e)
        {

            //登入視窗 記得要改回來
            //FormLogin myFormLogin = new FormLogin();
            //myFormLogin.ShowDialog();

            scsb.DataSource = @".";
            scsb.InitialCatalog = "csms";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;

            cbox產品類別.Text = ("--請選擇類別--");
            cbox產品品牌.Text = ("--請選擇品牌--");

            產生品牌dgv();
            產生類別dgv();
            產生產品dgv();
            cbox產品內容產生();
        }

        #region --品牌--

        void 產生品牌dgv()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();

            string strSQL = "select brand_Name as 品牌名稱 from brand";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv品牌.DataSource = dt;
                lbl品牌筆數.Text = $"共{dt.Rows.Count}筆";
            }
            else
            {
                MessageBox.Show("找不到資料");
            }
            reader.Close();
            con.Close();
        }

        private void btn新增品牌_Click(object sender, EventArgs e)
        {
            if (txt品牌名稱.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into brand values (@NewBrand);";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewBrand", txt品牌名稱.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"品牌新增成功");
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
            txt品牌名稱.Clear();
            產生品牌dgv();
            cbox產品內容產生();
        }

        private void btn刪除品牌_Click(object sender, EventArgs e)
        {
            if (dgv品牌.SelectedCells.Count > 0)
            {
                DialogResult R = MessageBox.Show("您確認要刪除此筆資料?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (R == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgv品牌.SelectedRows)
                    {
                        int selectedRowIndex = row.Index;
                        string brandName = row.Cells[0].Value.ToString();

                        SqlConnection con = new SqlConnection(strDBConnectionString);
                        con.Open();
                        string strSQL = "delete from brand where brand_Name = @BrandName";

                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@BrandName", brandName);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    產生品牌dgv();
                    cbox產品內容產生();
                }
            }
            else
            {
                MessageBox.Show("請先選擇要刪除的資料行");
            }
        }
        #endregion

        #region --類別--
        void 產生類別dgv()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();

            string strSQL = "select category_Name as 類別名稱 from category";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv類別.DataSource = dt;
                lbl類別筆數.Text = $"共{dt.Rows.Count}筆";
            }
            else
            {
                MessageBox.Show("找不到資料");
            }
            reader.Close();
            con.Close();
        }

        private void btn新增類別_Click(object sender, EventArgs e)
        {
            if (txt類別名稱.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into category values (@NewCategory);";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewCategory", txt類別名稱.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"類別新增成功");
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
            txt類別名稱.Clear();
            產生類別dgv();
            cbox產品內容產生();
        }

        private void btn刪除類別_Click(object sender, EventArgs e)
        {
            if (dgv類別.SelectedCells.Count > 0)
            {
                DialogResult R = MessageBox.Show("您確認要刪除此筆資料?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (R == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgv類別.SelectedRows)
                    {
                        string categoryName = row.Cells[0].Value.ToString();

                        SqlConnection con = new SqlConnection(strDBConnectionString);
                        con.Open();
                        string strSQL = "delete from category where category_Name = @CategoryName";

                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    產生類別dgv();
                    cbox產品內容產生();
                }
            }
            else
            {
                MessageBox.Show("請先選擇要刪除的資料行");
            }
        }
        #endregion

        #region --產品--

        void 產生產品dgv()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();

            string strSQL = "select product_Id as 產品Id , category_Name as 產品類別, brand_Name as 產品品牌, product_Name as 產品名稱, product_Quantity as 產品數量, product_Price as 產品售價 from product inner join category on product.category_Id = category.category_Id inner join brand on product.brand_Id = brand.brand_Id;";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv產品.DataSource = dt;
                dgv產品.Columns["產品Id"].Visible = false;
                lbl產品筆數.Text = $"共{dt.Rows.Count}筆";
            }
            else
            {
                MessageBox.Show("找不到資料");
            }
            reader.Close();
            con.Close();
        }

        void cbox產品內容產生()
        {
            SqlConnection con1 = new SqlConnection(strDBConnectionString);
            SqlConnection con2 = new SqlConnection(strDBConnectionString);
            con1.Open();
            con2.Open();

            string strSQL1 = "select category_Name from category;";
            string strSQL2 = "select brand_Name from brand;";

            SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
            SqlCommand cmd2 = new SqlCommand(strSQL2, con2);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            cbox產品類別.Items.Clear();
            cbox產品品牌.Items.Clear();


            while (reader1.Read())
            {
                cbox產品類別.Items.Add(reader1["category_Name"].ToString());
            }
            while (reader2.Read())
            {
                cbox產品品牌.Items.Add(reader2["brand_Name"].ToString());
            }

            reader1.Close();
            reader2.Close();
            con1.Close();
            con2.Close();
        }

        private void btn新增產品_Click(object sender, EventArgs e)
        {
            if (txt產品名稱.Text != "" && cbox產品類別.SelectedItem != null && cbox產品品牌.SelectedItem != null && txt產品數量.Text != "" && txt產品售價.Text != "")
            {
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();

                    // 取得選中的 category_Id
                    string selectedCategoryName = cbox產品類別.SelectedItem.ToString();
                    int categoryId;
                    using (SqlCommand getCategoryCmd = new SqlCommand("SELECT category_Id FROM category WHERE category_Name = @CategoryName", con))
                    {
                        getCategoryCmd.Parameters.AddWithValue("@CategoryName", selectedCategoryName);
                        categoryId = Convert.ToInt32(getCategoryCmd.ExecuteScalar());
                    }

                    // 取得選中的 brand_Id
                    string selectedBrandName = cbox產品品牌.SelectedItem.ToString();
                    int brandId;
                    using (SqlCommand getBrandCmd = new SqlCommand("SELECT brand_Id FROM brand WHERE brand_Name = @BrandName", con))
                    {
                        getBrandCmd.Parameters.AddWithValue("@BrandName", selectedBrandName);
                        brandId = Convert.ToInt32(getBrandCmd.ExecuteScalar());
                    }

                    // 插入到 product 資料表中
                    string insertQuery = "INSERT INTO product (product_Name, category_Id, brand_Id, product_Quantity, product_Price) VALUES (@NewProductName, @CategoryId, @BrandId, @NewProductQuantity, @NewProductPrice)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@NewProductName", txt產品名稱.Text);
                        insertCmd.Parameters.AddWithValue("@CategoryId", categoryId);
                        insertCmd.Parameters.AddWithValue("@BrandId", brandId);

                        int Quantity = 0;
                        Int32.TryParse(txt產品數量.Text, out Quantity);

                        insertCmd.Parameters.AddWithValue("@NewProductQuantity", Quantity);
                        insertCmd.Parameters.AddWithValue("@NewProductPrice", txt產品售價.Text);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show($"產品新增成功");
                    }
                }
                產生產品dgv();
                清空欄位();
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
                清空欄位();
            }
        }

        private void btn刪除產品_Click(object sender, EventArgs e)
        {
            if (dgv產品.SelectedCells.Count > 0)
            {
                DialogResult R = MessageBox.Show("您確認要刪除此筆資料?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (R == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "delete from product where product_id = @productId;";
                    string productId = dgv產品.SelectedRows[0].Cells[0].Value.ToString();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@productId", productId);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    產生產品dgv();
                    清空欄位();
                }
            }
            else
            {
                MessageBox.Show("請先選擇要刪除的資料行");
            }
        }

        private void btn搜尋產品_Click(object sender, EventArgs e)
        {
            if (txt欲搜尋產品.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "SELECT product_Name as 產品名稱, product_Quantity as 產品數量, category_Name as 產品類別, brand_Name as 產品品牌, product_Price as 產品售價 " +
                                    "FROM product " +
                                    "INNER JOIN category ON product.category_Id = category.category_Id " +
                                    "INNER JOIN brand ON product.brand_Id = brand.brand_Id " +
                                    "WHERE product_Name  LIKE @SearchName;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", $"%{txt欲搜尋產品.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    dgv產品.DataSource = dt;
                    lbl產品筆數.Text = $"共{dt.Rows.Count}筆";
                }
                else
                {
                    dgv產品.DataSource = null;
                    lbl產品筆數.Text = "共0筆";
                    MessageBox.Show("查無此產品");
                    產生產品dgv();
                    txt欲搜尋產品.Clear();
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn回復搜尋_Click(object sender, EventArgs e)
        {
            產生產品dgv();
            txt欲搜尋產品.Clear();
        }

        private void btn修改產品_Click(object sender, EventArgs e)
        {
            if (txt產品名稱.Text != "" && cbox產品類別.SelectedItem != null && cbox產品品牌.SelectedItem != null && txt產品數量.Text != "" && txt產品售價.Text != "")
            {
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();

                    string selectedCategoryName = cbox產品類別.SelectedItem.ToString();
                    int categoryId;
                    using (SqlCommand getCategoryCmd = new SqlCommand("SELECT category_Id FROM category WHERE category_Name = @CategoryName", con))
                    {
                        getCategoryCmd.Parameters.AddWithValue("@CategoryName", selectedCategoryName);
                        categoryId = Convert.ToInt32(getCategoryCmd.ExecuteScalar());
                    }

                    string selectedBrandName = cbox產品品牌.SelectedItem.ToString();
                    int brandId;
                    using (SqlCommand getBrandCmd = new SqlCommand("SELECT brand_Id FROM brand WHERE brand_Name = @BrandName", con))
                    {
                        getBrandCmd.Parameters.AddWithValue("@BrandName", selectedBrandName);
                        brandId = Convert.ToInt32(getBrandCmd.ExecuteScalar());
                    }

                    string updateQuery = "UPDATE product SET product_Name = @NewProductName, category_Id = @CategoryId, brand_Id = @BrandId, product_Quantity = @NewProductQuantity, product_Price = @NewProductPrice " +
                                         "WHERE product_Id = @ProductId";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@NewProductName", txt產品名稱.Text);
                        updateCmd.Parameters.AddWithValue("@CategoryId", categoryId);
                        updateCmd.Parameters.AddWithValue("@BrandId", brandId);
                        updateCmd.Parameters.AddWithValue("@NewProductQuantity", Convert.ToInt32(txt產品數量.Text));
                        updateCmd.Parameters.AddWithValue("@NewProductPrice", Convert.ToDouble(txt產品售價.Text));
                        updateCmd.Parameters.AddWithValue("@ProductId", dgv產品.SelectedRows[0].Cells[0].Value.ToString());
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show($"產品修改成功");
                    }
                }
                產生產品dgv();
                清空欄位();
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
                清空欄位();
            }
        }

        private void dgv產品_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv產品.SelectedCells.Count > 0)
            {
                string strSelectID = dgv產品.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select product.product_Name, product.product_Quantity, category.category_Name, brand.brand_Name, product.product_Price from product inner join category on product.category_Id = category.category_Id inner join brand on product.brand_Id = brand.brand_Id where product.product_Id = @productId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@productId", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    txt產品名稱.Text = reader["product_Name"].ToString();
                    cbox產品類別.Text = reader["category_Name"].ToString();
                    cbox產品品牌.Text = reader["brand_Name"].ToString();
                    txt產品數量.Text = reader["product_Quantity"].ToString();
                    txt產品售價.Text = reader["product_Price"].ToString();
                }
                reader.Close();
                con.Close();
            }

        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        void 清空欄位()
        {
            cbox產品類別.Text = ("--請選擇類別--");
            cbox產品品牌.Text = ("--請選擇品牌--");
            txt產品名稱.Clear();
            txt品牌名稱.Clear();
            txt產品數量.Clear();
            txt產品售價.Clear();
        }


        #endregion

        private void btn返回首頁_Click(object sender, EventArgs e)
        {
            this.Close();
            GlobalVar.首頁.Show();
        }
    }
}
