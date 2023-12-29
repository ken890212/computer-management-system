namespace WindowsFormsApp1
{
    partial class UserControlUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUsers));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tp會員管理 = new System.Windows.Forms.TabPage();
            this.cbox會員狀態 = new System.Windows.Forms.ComboBox();
            this.btn修改會員狀態 = new System.Windows.Forms.Button();
            this.btn回復搜尋 = new System.Windows.Forms.PictureBox();
            this.btn搜尋會員 = new System.Windows.Forms.PictureBox();
            this.txt欲搜尋會員 = new System.Windows.Forms.TextBox();
            this.dgv會員 = new System.Windows.Forms.DataGridView();
            this.tp員工管理 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox員工身份 = new System.Windows.Forms.ComboBox();
            this.btn修改員工身份 = new System.Windows.Forms.Button();
            this.btn回復搜尋員工 = new System.Windows.Forms.PictureBox();
            this.btn搜尋員工 = new System.Windows.Forms.PictureBox();
            this.txt欲搜尋員工 = new System.Windows.Forms.TextBox();
            this.dgv員工 = new System.Windows.Forms.DataGridView();
            this.txt員工密碼 = new System.Windows.Forms.TextBox();
            this.btn新增員工 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt員工名稱 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn返回首頁 = new System.Windows.Forms.PictureBox();
            this.tabControl2.SuspendLayout();
            this.tp會員管理.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn回復搜尋)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn搜尋會員)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員)).BeginInit();
            this.tp員工管理.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn回復搜尋員工)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn搜尋員工)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv員工)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn返回首頁)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tp會員管理);
            this.tabControl2.Controls.Add(this.tp員工管理);
            this.tabControl2.Location = new System.Drawing.Point(12, 53);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1154, 538);
            this.tabControl2.TabIndex = 1;
            // 
            // tp會員管理
            // 
            this.tp會員管理.Controls.Add(this.cbox會員狀態);
            this.tp會員管理.Controls.Add(this.btn修改會員狀態);
            this.tp會員管理.Controls.Add(this.btn回復搜尋);
            this.tp會員管理.Controls.Add(this.btn搜尋會員);
            this.tp會員管理.Controls.Add(this.txt欲搜尋會員);
            this.tp會員管理.Controls.Add(this.dgv會員);
            this.tp會員管理.Location = new System.Drawing.Point(4, 28);
            this.tp會員管理.Name = "tp會員管理";
            this.tp會員管理.Padding = new System.Windows.Forms.Padding(3);
            this.tp會員管理.Size = new System.Drawing.Size(1146, 506);
            this.tp會員管理.TabIndex = 1;
            this.tp會員管理.Text = "會員管理";
            this.tp會員管理.UseVisualStyleBackColor = true;
            // 
            // cbox會員狀態
            // 
            this.cbox會員狀態.FormattingEnabled = true;
            this.cbox會員狀態.Location = new System.Drawing.Point(22, 123);
            this.cbox會員狀態.Name = "cbox會員狀態";
            this.cbox會員狀態.Size = new System.Drawing.Size(171, 26);
            this.cbox會員狀態.TabIndex = 113;
            // 
            // btn修改會員狀態
            // 
            this.btn修改會員狀態.Location = new System.Drawing.Point(22, 155);
            this.btn修改會員狀態.Name = "btn修改會員狀態";
            this.btn修改會員狀態.Size = new System.Drawing.Size(171, 29);
            this.btn修改會員狀態.TabIndex = 112;
            this.btn修改會員狀態.Text = "修改會員狀態";
            this.btn修改會員狀態.UseVisualStyleBackColor = true;
            this.btn修改會員狀態.Click += new System.EventHandler(this.btn修改會員狀態_Click);
            // 
            // btn回復搜尋
            // 
            this.btn回復搜尋.Image = ((System.Drawing.Image)(resources.GetObject("btn回復搜尋.Image")));
            this.btn回復搜尋.Location = new System.Drawing.Point(835, 28);
            this.btn回復搜尋.Name = "btn回復搜尋";
            this.btn回復搜尋.Size = new System.Drawing.Size(34, 29);
            this.btn回復搜尋.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn回復搜尋.TabIndex = 111;
            this.btn回復搜尋.TabStop = false;
            this.btn回復搜尋.Click += new System.EventHandler(this.btn回復搜尋_Click);
            // 
            // btn搜尋會員
            // 
            this.btn搜尋會員.Image = ((System.Drawing.Image)(resources.GetObject("btn搜尋會員.Image")));
            this.btn搜尋會員.Location = new System.Drawing.Point(795, 28);
            this.btn搜尋會員.Name = "btn搜尋會員";
            this.btn搜尋會員.Size = new System.Drawing.Size(34, 29);
            this.btn搜尋會員.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn搜尋會員.TabIndex = 110;
            this.btn搜尋會員.TabStop = false;
            this.btn搜尋會員.Click += new System.EventHandler(this.btn搜尋會員_Click);
            // 
            // txt欲搜尋會員
            // 
            this.txt欲搜尋會員.Location = new System.Drawing.Point(517, 28);
            this.txt欲搜尋會員.Name = "txt欲搜尋會員";
            this.txt欲搜尋會員.Size = new System.Drawing.Size(272, 29);
            this.txt欲搜尋會員.TabIndex = 109;
            // 
            // dgv會員
            // 
            this.dgv會員.AllowUserToAddRows = false;
            this.dgv會員.AllowUserToDeleteRows = false;
            this.dgv會員.AllowUserToResizeColumns = false;
            this.dgv會員.AllowUserToResizeRows = false;
            this.dgv會員.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv會員.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv會員.Location = new System.Drawing.Point(216, 63);
            this.dgv會員.Name = "dgv會員";
            this.dgv會員.ReadOnly = true;
            this.dgv會員.RowHeadersVisible = false;
            this.dgv會員.RowHeadersWidth = 62;
            this.dgv會員.RowTemplate.Height = 31;
            this.dgv會員.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv會員.Size = new System.Drawing.Size(908, 349);
            this.dgv會員.TabIndex = 107;
            this.dgv會員.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv會員_CellClick);
            // 
            // tp員工管理
            // 
            this.tp員工管理.Controls.Add(this.label2);
            this.tp員工管理.Controls.Add(this.cbox員工身份);
            this.tp員工管理.Controls.Add(this.btn修改員工身份);
            this.tp員工管理.Controls.Add(this.btn回復搜尋員工);
            this.tp員工管理.Controls.Add(this.btn搜尋員工);
            this.tp員工管理.Controls.Add(this.txt欲搜尋員工);
            this.tp員工管理.Controls.Add(this.dgv員工);
            this.tp員工管理.Controls.Add(this.txt員工密碼);
            this.tp員工管理.Controls.Add(this.btn新增員工);
            this.tp員工管理.Controls.Add(this.label3);
            this.tp員工管理.Controls.Add(this.txt員工名稱);
            this.tp員工管理.Controls.Add(this.label1);
            this.tp員工管理.Location = new System.Drawing.Point(4, 28);
            this.tp員工管理.Name = "tp員工管理";
            this.tp員工管理.Padding = new System.Windows.Forms.Padding(3);
            this.tp員工管理.Size = new System.Drawing.Size(1146, 506);
            this.tp員工管理.TabIndex = 0;
            this.tp員工管理.Text = "員工管理";
            this.tp員工管理.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 116;
            this.label2.Text = "員工身份";
            // 
            // cbox員工身份
            // 
            this.cbox員工身份.FormattingEnabled = true;
            this.cbox員工身份.Location = new System.Drawing.Point(21, 228);
            this.cbox員工身份.Name = "cbox員工身份";
            this.cbox員工身份.Size = new System.Drawing.Size(155, 26);
            this.cbox員工身份.TabIndex = 115;
            // 
            // btn修改員工身份
            // 
            this.btn修改員工身份.Location = new System.Drawing.Point(21, 316);
            this.btn修改員工身份.Name = "btn修改員工身份";
            this.btn修改員工身份.Size = new System.Drawing.Size(155, 29);
            this.btn修改員工身份.TabIndex = 97;
            this.btn修改員工身份.Text = "修改員工身份";
            this.btn修改員工身份.UseVisualStyleBackColor = true;
            this.btn修改員工身份.Click += new System.EventHandler(this.btn修改員工身份_Click);
            // 
            // btn回復搜尋員工
            // 
            this.btn回復搜尋員工.Image = ((System.Drawing.Image)(resources.GetObject("btn回復搜尋員工.Image")));
            this.btn回復搜尋員工.Location = new System.Drawing.Point(783, 44);
            this.btn回復搜尋員工.Name = "btn回復搜尋員工";
            this.btn回復搜尋員工.Size = new System.Drawing.Size(34, 29);
            this.btn回復搜尋員工.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn回復搜尋員工.TabIndex = 96;
            this.btn回復搜尋員工.TabStop = false;
            this.btn回復搜尋員工.Click += new System.EventHandler(this.btn回復搜尋員工_Click);
            // 
            // btn搜尋員工
            // 
            this.btn搜尋員工.Image = ((System.Drawing.Image)(resources.GetObject("btn搜尋員工.Image")));
            this.btn搜尋員工.Location = new System.Drawing.Point(743, 44);
            this.btn搜尋員工.Name = "btn搜尋員工";
            this.btn搜尋員工.Size = new System.Drawing.Size(34, 29);
            this.btn搜尋員工.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn搜尋員工.TabIndex = 95;
            this.btn搜尋員工.TabStop = false;
            this.btn搜尋員工.Click += new System.EventHandler(this.btn搜尋員工_Click);
            // 
            // txt欲搜尋員工
            // 
            this.txt欲搜尋員工.Location = new System.Drawing.Point(465, 44);
            this.txt欲搜尋員工.Name = "txt欲搜尋員工";
            this.txt欲搜尋員工.Size = new System.Drawing.Size(272, 29);
            this.txt欲搜尋員工.TabIndex = 94;
            // 
            // dgv員工
            // 
            this.dgv員工.AllowUserToAddRows = false;
            this.dgv員工.AllowUserToDeleteRows = false;
            this.dgv員工.AllowUserToResizeColumns = false;
            this.dgv員工.AllowUserToResizeRows = false;
            this.dgv員工.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv員工.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv員工.Location = new System.Drawing.Point(207, 79);
            this.dgv員工.Name = "dgv員工";
            this.dgv員工.ReadOnly = true;
            this.dgv員工.RowHeadersVisible = false;
            this.dgv員工.RowHeadersWidth = 62;
            this.dgv員工.RowTemplate.Height = 31;
            this.dgv員工.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv員工.Size = new System.Drawing.Size(862, 349);
            this.dgv員工.TabIndex = 92;
            this.dgv員工.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv員工_CellClick);
            // 
            // txt員工密碼
            // 
            this.txt員工密碼.Location = new System.Drawing.Point(21, 163);
            this.txt員工密碼.Name = "txt員工密碼";
            this.txt員工密碼.Size = new System.Drawing.Size(155, 29);
            this.txt員工密碼.TabIndex = 89;
            // 
            // btn新增員工
            // 
            this.btn新增員工.Location = new System.Drawing.Point(21, 281);
            this.btn新增員工.Name = "btn新增員工";
            this.btn新增員工.Size = new System.Drawing.Size(155, 29);
            this.btn新增員工.TabIndex = 88;
            this.btn新增員工.Text = "新增員工";
            this.btn新增員工.UseVisualStyleBackColor = true;
            this.btn新增員工.Click += new System.EventHandler(this.btn新增員工_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 87;
            this.label3.Text = "員工密碼";
            // 
            // txt員工名稱
            // 
            this.txt員工名稱.Location = new System.Drawing.Point(21, 100);
            this.txt員工名稱.Name = "txt員工名稱";
            this.txt員工名稱.Size = new System.Drawing.Size(155, 29);
            this.txt員工名稱.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 84;
            this.label1.Text = "員工名稱";
            // 
            // btn返回首頁
            // 
            this.btn返回首頁.Image = ((System.Drawing.Image)(resources.GetObject("btn返回首頁.Image")));
            this.btn返回首頁.Location = new System.Drawing.Point(12, 12);
            this.btn返回首頁.Name = "btn返回首頁";
            this.btn返回首頁.Size = new System.Drawing.Size(46, 27);
            this.btn返回首頁.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn返回首頁.TabIndex = 67;
            this.btn返回首頁.TabStop = false;
            this.btn返回首頁.Click += new System.EventHandler(this.btn返回首頁_Click);
            // 
            // UserControlUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 594);
            this.Controls.Add(this.btn返回首頁);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserControlUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserControlUsers";
            this.Load += new System.EventHandler(this.UserControlUsers_Load);
            this.tabControl2.ResumeLayout(false);
            this.tp會員管理.ResumeLayout(false);
            this.tp會員管理.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn回復搜尋)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn搜尋會員)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員)).EndInit();
            this.tp員工管理.ResumeLayout(false);
            this.tp員工管理.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn回復搜尋員工)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn搜尋員工)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv員工)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn返回首頁)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tp員工管理;
        private System.Windows.Forms.Button btn修改員工身份;
        private System.Windows.Forms.PictureBox btn回復搜尋員工;
        private System.Windows.Forms.PictureBox btn搜尋員工;
        private System.Windows.Forms.TextBox txt欲搜尋員工;
        private System.Windows.Forms.DataGridView dgv員工;
        private System.Windows.Forms.TextBox txt員工密碼;
        private System.Windows.Forms.Button btn新增員工;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt員工名稱;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tp會員管理;
        private System.Windows.Forms.Button btn修改會員狀態;
        private System.Windows.Forms.PictureBox btn回復搜尋;
        private System.Windows.Forms.PictureBox btn搜尋會員;
        private System.Windows.Forms.TextBox txt欲搜尋會員;
        private System.Windows.Forms.DataGridView dgv會員;
        private System.Windows.Forms.PictureBox btn返回首頁;
        private System.Windows.Forms.ComboBox cbox會員狀態;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox員工身份;
    }
}