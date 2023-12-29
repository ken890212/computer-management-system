using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
            scsb.DataSource = @".";
            scsb.InitialCatalog = "csms";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
        }
        
        private void btn會員登入_Click(object sender, EventArgs e)
        {

            if ((txtUserName.Text != "") && (txtPassword.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();

                int usersRoleId;
                using (SqlCommand getusersRoleIdCmd = new SqlCommand("SELECT usersRole_Id FROM users WHERE users_Name = @usersName", con))
                {
                    getusersRoleIdCmd.Parameters.AddWithValue("@usersName", txtUserName.Text);
                    usersRoleId = Convert.ToInt32(getusersRoleIdCmd.ExecuteScalar());
                }
                if (usersRoleId == 2)
                {
                    MessageBox.Show("您是黑名單!，無法登入");
                    return;
                }
                string strSQL = "select * from users where users_Name = @UserName and users_Password = @PassWord";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@PassWord", txtPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    GlobalVar.is登入成功 = true;
                    GlobalVar.使用者名稱 = txtUserName.Text;
                    MessageBox.Show("會員登入成功");
                    con.Close();
                    reader.Close();
                    this.Hide();
                    GlobalVar.電腦估價單.ShowDialog();
                }
                if (GlobalVar.is登入成功 == false)
                {
                    MessageBox.Show("登入失敗");

                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入登入資訊");
            }
            txtPassword.Clear();
            txtUserName.Clear();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVar.is登入成功 == true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void lbl會員註冊_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVar.註冊.ShowDialog();
        }

        private void btn員工登入_Click(object sender, EventArgs e)
        {
            if ((txtUserName.Text != "") && (txtPassword.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                int memberRoleId;
                using (SqlCommand getmemberRoleIdCmd = new SqlCommand("SELECT memberRole_Id FROM member WHERE member_Name = @memberName", con))
                {
                    getmemberRoleIdCmd.Parameters.AddWithValue("@memberName", txtUserName.Text);
                    memberRoleId = Convert.ToInt32(getmemberRoleIdCmd.ExecuteScalar());
                }
                if(memberRoleId == 3)
                {
                    MessageBox.Show("您已離職，無法登入");
                    return;
                }
                string strSQL = "select * from member where member_Name = @MemberName and member_Password = @MemberWord";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@MemberName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@MemberWord", txtPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (memberRoleId != 3)
                    {
                        GlobalVar.is登入成功 = true;
                        GlobalVar.員工名稱 = txtUserName.Text;
                        MessageBox.Show("員工登入成功");
                        con.Close();
                        reader.Close();
                        this.Hide();
                        GlobalVar.首頁.ShowDialog();
                    }
                }
                if (GlobalVar.is登入成功 == false)
                {
                    MessageBox.Show("登入失敗");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入登入資訊");
            }
            txtPassword.Clear();
            txtUserName.Clear();
        }
    }
}
