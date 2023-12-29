using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBconnectionString = "";
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl員工.Text = $"使用者{ GlobalVar.員工名稱}您好";
            scsb.DataSource = @".";
            scsb.InitialCatalog = "csms";
            scsb.IntegratedSecurity = true;
            strDBconnectionString = scsb.ConnectionString;
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            int memberRoleId;
            using (SqlCommand getmemberRoleIdCmd = new SqlCommand("SELECT memberRole_Id FROM member WHERE member_Name = @memberName", con))
            {
                getmemberRoleIdCmd.Parameters.AddWithValue("@memberName", GlobalVar.員工名稱);
                memberRoleId = Convert.ToInt32(getmemberRoleIdCmd.ExecuteScalar());
            }
            con.Close();
            if(memberRoleId == 1)
            {
                btn訂單管理.Visible = true;
                btn人員管理.Visible = true;
            }
            else
            {
                btn訂單管理.Visible = false;
                btn人員管理.Visible = false;
            }
        }

        private void btn產品管理_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVar.產品管理.ShowDialog();
        }
        private void btn人員管理_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVar.會員管理.ShowDialog();
        }

        private void btn返回登入頁面_Click(object sender, EventArgs e)
        {
            Close();
            GlobalVar.登入.Show();
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalVar.訂單管理.ShowDialog();
        }
    }
}
