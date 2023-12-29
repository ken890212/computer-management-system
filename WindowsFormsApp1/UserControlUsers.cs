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
    public partial class UserControlUsers : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";

        public UserControlUsers()
        {
            InitializeComponent();

        }

        private void UserControlUsers_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "csms";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;

            產生會員dgv();
            產生員工dgv();
            cbox會員狀態內容產生();
            cbox員工身份內容產生();
        }

        #region --會員--
        void 產生會員dgv()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();

            string strSQL = "SELECT users.users_Id AS 會員Id, users.users_Name AS 會員名稱, users.users_Email AS 會員信箱, usersRole_Name AS 會員身份 FROM users INNER JOIN usersRole ON users.usersRole_Id = usersRole.usersRole_Id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgv會員.DataSource = dt;
            dgv會員.Columns["會員Id"].Visible = false;
            reader.Close();
            con.Close();
        }
        void cbox會員狀態內容產生()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select usersRole_Name from usersRole;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            cbox會員狀態.Items.Clear();
            while (reader.Read())
            {
                cbox會員狀態.Items.Add(reader["usersRole_Name"].ToString());
            }
            reader.Close();
            con.Close();
        }
        private void dgv會員_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv會員.SelectedCells.Count > 0)
            {
                string strSelectID = dgv會員.Rows[e.RowIndex].Cells[0].Value.ToString();
                //string strSelectID = dgv會員.Rows[e.RowIndex].Cells["會員Id"].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "SELECT usersRole.usersRole_Name FROM users INNER JOIN usersRole ON users.usersRole_Id = usersRole.usersRole_Id WHERE users.users_Id = @usersId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@usersId", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    cbox會員狀態.Text = reader["usersRole_Name"].ToString();
                }
                reader.Close();
                con.Close();
            }
        }
        private void btn修改會員狀態_Click(object sender, EventArgs e)
        {
            if (cbox會員狀態.SelectedItem != null)
            {
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string selectedusersRoleName = cbox會員狀態.SelectedItem.ToString();
                    int usersRoleId;
                    using (SqlCommand getusersRoleCmd = new SqlCommand("SELECT usersRole_Id FROM usersRole WHERE usersRole_Name = @usersRoleName", con))
                    {
                        getusersRoleCmd.Parameters.AddWithValue("@usersRoleName", selectedusersRoleName);
                        usersRoleId = Convert.ToInt32(getusersRoleCmd.ExecuteScalar());
                    }

                    string updateQuery = "UPDATE users SET usersRole_Id = @usersRoleId WHERE users_Id = @usersId";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@usersRoleId", usersRoleId);
                        updateCmd.Parameters.AddWithValue("@usersId", dgv會員.SelectedRows[0].Cells[0].Value.ToString());
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show($"會員狀態修改成功");
                        產生會員dgv();
                        cbox會員狀態.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }
        private void btn搜尋會員_Click(object sender, EventArgs e)
        {
            if (txt欲搜尋會員.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "SELECT users.users_Id AS 會員Id, users.users_Name AS 會員名稱, users.users_Email AS 會員信箱, usersRole_Name AS 會員身份 FROM users INNER JOIN usersRole ON users.usersRole_Id = usersRole.usersRole_Id where users_Name Like @SearchName;";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", $"%{txt欲搜尋會員.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    dgv會員.DataSource = dt;
                }
                else
                {
                    dgv會員.DataSource = null;
                    MessageBox.Show("查無此會員");
                    產生會員dgv();
                    txt欲搜尋會員.Clear();
                }
                reader.Close();
                con.Close();
            }
        }
        private void btn回復搜尋_Click(object sender, EventArgs e)
        {
            產生會員dgv();
            txt欲搜尋會員.Clear();
        }

        #endregion

        #region --員工--

        void 產生員工dgv()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            //string strSQL = "SELECT users.users_Id AS 會員Id, users.users_Name AS 會員名稱, users.users_Email AS 會員信箱, usersRole_Name AS 會員身份 FROM users INNER JOIN usersRole ON users.usersRole_Id = usersRole.usersRole_Id;";

            string strSQL = "SELECT member_Id AS 員工Id, member_Name AS 員工名稱, memberRole_Name AS 員工身份 FROM member INNER JOIN memberRole ON member.memberRole_Id = memberRole.memberRole_Id;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgv員工.DataSource = dt;
            dgv員工.Columns["員工Id"].Visible = false;
            reader.Close();
            con.Close();
        }
        private void btn新增員工_Click(object sender, EventArgs e)
        {
            if (txt員工名稱.Text != "" && txt員工密碼.Text != "" && cbox員工身份.SelectedItem != null)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string selectedMemberRoleName = cbox員工身份.SelectedItem.ToString();
                int MemberRoleId;
                using (SqlCommand getMemberRoleCmd = new SqlCommand("SELECT memberRole_Id FROM memberRole WHERE memberRole_Name = @MemberRoleName", con))
                {
                    getMemberRoleCmd.Parameters.AddWithValue("@MemberRoleName", selectedMemberRoleName);
                    MemberRoleId = Convert.ToInt32(getMemberRoleCmd.ExecuteScalar());
                }
                string strSQL = "INSERT INTO member (member_Name, member_Password, memberRole_Id) VALUES(@MemberName, @PassWord, @MemberRole_Id);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@MemberName", txt員工名稱.Text);
                cmd.Parameters.AddWithValue("@PassWord", txt員工密碼.Text);
                cmd.Parameters.AddWithValue("@MemberRole_Id", MemberRoleId);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"員工新增成功");
                產生員工dgv();
                txt員工名稱.Clear();
                txt員工密碼.Clear();
                cbox員工身份.Text = "";
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }

        void cbox員工身份內容產生()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select memberRole_Name from memberRole;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            cbox員工身份.Items.Clear();
            while (reader.Read())
            {
                cbox員工身份.Items.Add(reader["memberRole_Name"].ToString());
            }
            reader.Close();
            con.Close();
        }

        private void dgv員工_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv員工.SelectedCells.Count > 0)
            {
                string strSelectID = dgv員工.Rows[e.RowIndex].Cells[0].Value.ToString();
                //string strSelectID = dgv會員.Rows[e.RowIndex].Cells["會員Id"].Value.ToString();
                int selectID = 0;
                Int32.TryParse(strSelectID, out selectID);

                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "SELECT memberRole.memberRole_Name FROM member INNER JOIN memberRole ON member.memberRole_Id = memberRole.memberRole_Id WHERE member.member_Id = @memberId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@memberId", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    cbox員工身份.Text = reader["memberRole_Name"].ToString();
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn修改員工身份_Click(object sender, EventArgs e)
        {
            if (cbox員工身份.SelectedItem != null)
            {
                using (SqlConnection con = new SqlConnection(strDBConnectionString))
                {
                    con.Open();
                    string selectedMemberRoleName = cbox員工身份.SelectedItem.ToString();
                    int memberRoleId;
                    using (SqlCommand getMemberRoleCmd = new SqlCommand("SELECT memberRole_Id FROM memberRole WHERE memberRole_Name = @MemberRoleName", con))
                    {
                        getMemberRoleCmd.Parameters.AddWithValue("@MemberRoleName", selectedMemberRoleName);
                        memberRoleId = Convert.ToInt32(getMemberRoleCmd.ExecuteScalar());
                    }
                    string updateQuery = "UPDATE member SET memberRole_Id = @memberRoleId WHERE member_Id = @memberId";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@memberRoleId", memberRoleId);
                        updateCmd.Parameters.AddWithValue("@memberId", dgv員工.SelectedRows[0].Cells[0].Value.ToString());
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show($"會員狀態修改成功");
                        產生員工dgv();
                        cbox員工身份.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }

        private void btn搜尋員工_Click(object sender, EventArgs e)
        {
            if (txt欲搜尋員工.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "SELECT member.member_Id AS 員工Id, member.member_Name AS 員工名稱, memberRole_Name AS 員工身份 FROM member INNER JOIN memberRole ON member.memberRole_Id = memberRole.memberRole_Id where member_Name Like @SearchName;";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", $"%{txt欲搜尋員工.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    dgv員工.DataSource = dt;
                }
                else
                {
                    dgv員工.DataSource = null;
                    MessageBox.Show("查無此員工");
                    產生員工dgv();
                    txt欲搜尋員工.Clear();
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn回復搜尋員工_Click(object sender, EventArgs e)
        {
            產生員工dgv();
            txt欲搜尋員工.Clear();
        }

        #endregion

        private void btn返回首頁_Click(object sender, EventArgs e)
        {
            Close();
            GlobalVar.首頁.Show();
        }
    }
}
