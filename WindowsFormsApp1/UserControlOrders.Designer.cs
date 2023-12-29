namespace WindowsFormsApp1
{
    partial class UserControlOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlOrders));
            this.btn返回首頁 = new System.Windows.Forms.PictureBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tp會員管理 = new System.Windows.Forms.TabPage();
            this.cbox訂單狀態 = new System.Windows.Forms.ComboBox();
            this.btn修改訂單狀態 = new System.Windows.Forms.Button();
            this.btn回復搜尋 = new System.Windows.Forms.PictureBox();
            this.btn搜尋訂單 = new System.Windows.Forms.PictureBox();
            this.txt欲搜尋訂單 = new System.Windows.Forms.TextBox();
            this.dgv訂單 = new System.Windows.Forms.DataGridView();
            this.tp訂單明細 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv訂單明細 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn返回首頁)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tp會員管理.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn回復搜尋)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn搜尋訂單)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單)).BeginInit();
            this.tp訂單明細.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單明細)).BeginInit();
            this.SuspendLayout();
            // 
            // btn返回首頁
            // 
            this.btn返回首頁.Image = ((System.Drawing.Image)(resources.GetObject("btn返回首頁.Image")));
            this.btn返回首頁.Location = new System.Drawing.Point(12, 8);
            this.btn返回首頁.Name = "btn返回首頁";
            this.btn返回首頁.Size = new System.Drawing.Size(46, 27);
            this.btn返回首頁.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn返回首頁.TabIndex = 69;
            this.btn返回首頁.TabStop = false;
            this.btn返回首頁.Click += new System.EventHandler(this.btn返回首頁_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tp會員管理);
            this.tabControl2.Controls.Add(this.tp訂單明細);
            this.tabControl2.Location = new System.Drawing.Point(12, 49);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1154, 538);
            this.tabControl2.TabIndex = 68;
            // 
            // tp會員管理
            // 
            this.tp會員管理.Controls.Add(this.cbox訂單狀態);
            this.tp會員管理.Controls.Add(this.btn修改訂單狀態);
            this.tp會員管理.Controls.Add(this.btn回復搜尋);
            this.tp會員管理.Controls.Add(this.btn搜尋訂單);
            this.tp會員管理.Controls.Add(this.txt欲搜尋訂單);
            this.tp會員管理.Controls.Add(this.dgv訂單);
            this.tp會員管理.Location = new System.Drawing.Point(4, 28);
            this.tp會員管理.Name = "tp會員管理";
            this.tp會員管理.Padding = new System.Windows.Forms.Padding(3);
            this.tp會員管理.Size = new System.Drawing.Size(1146, 506);
            this.tp會員管理.TabIndex = 1;
            this.tp會員管理.Text = "訂單管理";
            this.tp會員管理.UseVisualStyleBackColor = true;
            // 
            // cbox訂單狀態
            // 
            this.cbox訂單狀態.FormattingEnabled = true;
            this.cbox訂單狀態.Location = new System.Drawing.Point(33, 416);
            this.cbox訂單狀態.Name = "cbox訂單狀態";
            this.cbox訂單狀態.Size = new System.Drawing.Size(171, 26);
            this.cbox訂單狀態.TabIndex = 113;
            // 
            // btn修改訂單狀態
            // 
            this.btn修改訂單狀態.Location = new System.Drawing.Point(33, 448);
            this.btn修改訂單狀態.Name = "btn修改訂單狀態";
            this.btn修改訂單狀態.Size = new System.Drawing.Size(171, 29);
            this.btn修改訂單狀態.TabIndex = 112;
            this.btn修改訂單狀態.Text = "修改訂單狀態";
            this.btn修改訂單狀態.UseVisualStyleBackColor = true;
            this.btn修改訂單狀態.Click += new System.EventHandler(this.btn修改訂單狀態_Click);
            // 
            // btn回復搜尋
            // 
            this.btn回復搜尋.Image = ((System.Drawing.Image)(resources.GetObject("btn回復搜尋.Image")));
            this.btn回復搜尋.Location = new System.Drawing.Point(735, 11);
            this.btn回復搜尋.Name = "btn回復搜尋";
            this.btn回復搜尋.Size = new System.Drawing.Size(34, 29);
            this.btn回復搜尋.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn回復搜尋.TabIndex = 111;
            this.btn回復搜尋.TabStop = false;
            this.btn回復搜尋.Click += new System.EventHandler(this.btn回復搜尋_Click);
            // 
            // btn搜尋訂單
            // 
            this.btn搜尋訂單.Image = ((System.Drawing.Image)(resources.GetObject("btn搜尋訂單.Image")));
            this.btn搜尋訂單.Location = new System.Drawing.Point(695, 11);
            this.btn搜尋訂單.Name = "btn搜尋訂單";
            this.btn搜尋訂單.Size = new System.Drawing.Size(34, 29);
            this.btn搜尋訂單.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn搜尋訂單.TabIndex = 110;
            this.btn搜尋訂單.TabStop = false;
            this.btn搜尋訂單.Click += new System.EventHandler(this.btn搜尋訂單_Click);
            // 
            // txt欲搜尋訂單
            // 
            this.txt欲搜尋訂單.Location = new System.Drawing.Point(417, 11);
            this.txt欲搜尋訂單.Name = "txt欲搜尋訂單";
            this.txt欲搜尋訂單.Size = new System.Drawing.Size(272, 29);
            this.txt欲搜尋訂單.TabIndex = 109;
            // 
            // dgv訂單
            // 
            this.dgv訂單.AllowUserToAddRows = false;
            this.dgv訂單.AllowUserToDeleteRows = false;
            this.dgv訂單.AllowUserToResizeColumns = false;
            this.dgv訂單.AllowUserToResizeRows = false;
            this.dgv訂單.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv訂單.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv訂單.Location = new System.Drawing.Point(33, 46);
            this.dgv訂單.Name = "dgv訂單";
            this.dgv訂單.ReadOnly = true;
            this.dgv訂單.RowHeadersVisible = false;
            this.dgv訂單.RowHeadersWidth = 62;
            this.dgv訂單.RowTemplate.Height = 31;
            this.dgv訂單.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv訂單.Size = new System.Drawing.Size(1084, 349);
            this.dgv訂單.TabIndex = 107;
            this.dgv訂單.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv訂單_CellClick);
            // 
            // tp訂單明細
            // 
            this.tp訂單明細.Controls.Add(this.label2);
            this.tp訂單明細.Controls.Add(this.dgv訂單明細);
            this.tp訂單明細.Controls.Add(this.label3);
            this.tp訂單明細.Controls.Add(this.label1);
            this.tp訂單明細.Location = new System.Drawing.Point(4, 28);
            this.tp訂單明細.Name = "tp訂單明細";
            this.tp訂單明細.Padding = new System.Windows.Forms.Padding(3);
            this.tp訂單明細.Size = new System.Drawing.Size(1146, 506);
            this.tp訂單明細.TabIndex = 0;
            this.tp訂單明細.Text = "訂單明細";
            this.tp訂單明細.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 116;
            // 
            // dgv訂單明細
            // 
            this.dgv訂單明細.AllowUserToAddRows = false;
            this.dgv訂單明細.AllowUserToDeleteRows = false;
            this.dgv訂單明細.AllowUserToResizeColumns = false;
            this.dgv訂單明細.AllowUserToResizeRows = false;
            this.dgv訂單明細.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv訂單明細.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv訂單明細.Location = new System.Drawing.Point(24, 57);
            this.dgv訂單明細.Name = "dgv訂單明細";
            this.dgv訂單明細.ReadOnly = true;
            this.dgv訂單明細.RowHeadersVisible = false;
            this.dgv訂單明細.RowHeadersWidth = 62;
            this.dgv訂單明細.RowTemplate.Height = 31;
            this.dgv訂單明細.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv訂單明細.Size = new System.Drawing.Size(1089, 349);
            this.dgv訂單明細.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 84;
            // 
            // UserControlOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 594);
            this.Controls.Add(this.btn返回首頁);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserControlOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserControlOrders";
            this.Load += new System.EventHandler(this.UserControlOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn返回首頁)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tp會員管理.ResumeLayout(false);
            this.tp會員管理.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn回復搜尋)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn搜尋訂單)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單)).EndInit();
            this.tp訂單明細.ResumeLayout(false);
            this.tp訂單明細.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單明細)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn返回首頁;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tp會員管理;
        private System.Windows.Forms.ComboBox cbox訂單狀態;
        private System.Windows.Forms.Button btn修改訂單狀態;
        private System.Windows.Forms.PictureBox btn回復搜尋;
        private System.Windows.Forms.PictureBox btn搜尋訂單;
        private System.Windows.Forms.TextBox txt欲搜尋訂單;
        private System.Windows.Forms.DataGridView dgv訂單;
        private System.Windows.Forms.TabPage tp訂單明細;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv訂單明細;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}