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
    public partial class UserControlRegister : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";

        public UserControlRegister()
        {
            InitializeComponent();
        }

        private void UserControlRegister_Load(object sender, EventArgs e)
        {
            txt註冊email.Text = "";
            txt註冊Password.Text = "";
            txt註冊UserName.Text = "";
            scsb.DataSource = @".";
            scsb.InitialCatalog = "csms";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            if (txt註冊UserName.Text != "" && txt註冊Password.Text != "" && txt註冊Password.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "INSERT INTO users (users_Name, users_Password, users_Email, usersRole_Id) VALUES(@UserName, @PassWord, @UserEmail,'1');";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@UserName", txt註冊UserName.Text);
                cmd.Parameters.AddWithValue("@PassWord", txt註冊Password.Text);
                cmd.Parameters.AddWithValue("@UserEmail", txt註冊email.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"會員註冊成功");
                this.Close();
                GlobalVar.登入.Show();
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }

        private void lbl回到登入頁面_Click(object sender, EventArgs e)
        {
            this.Close();
            GlobalVar.登入.Show();
        }
    }
}
