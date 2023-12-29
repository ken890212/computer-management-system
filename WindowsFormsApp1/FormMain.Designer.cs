namespace WindowsFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btn產品管理 = new System.Windows.Forms.Button();
            this.btn人員管理 = new System.Windows.Forms.Button();
            this.btn訂單管理 = new System.Windows.Forms.Button();
            this.btn返回登入頁面 = new System.Windows.Forms.PictureBox();
            this.lbl員工 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn返回登入頁面)).BeginInit();
            this.SuspendLayout();
            // 
            // btn產品管理
            // 
            this.btn產品管理.Location = new System.Drawing.Point(22, 181);
            this.btn產品管理.Name = "btn產品管理";
            this.btn產品管理.Size = new System.Drawing.Size(166, 81);
            this.btn產品管理.TabIndex = 1;
            this.btn產品管理.Text = "產品管理";
            this.btn產品管理.UseVisualStyleBackColor = true;
            this.btn產品管理.Click += new System.EventHandler(this.btn產品管理_Click);
            // 
            // btn人員管理
            // 
            this.btn人員管理.Location = new System.Drawing.Point(366, 181);
            this.btn人員管理.Name = "btn人員管理";
            this.btn人員管理.Size = new System.Drawing.Size(166, 81);
            this.btn人員管理.TabIndex = 2;
            this.btn人員管理.Text = "人員管理";
            this.btn人員管理.UseVisualStyleBackColor = true;
            this.btn人員管理.Visible = false;
            this.btn人員管理.Click += new System.EventHandler(this.btn人員管理_Click);
            // 
            // btn訂單管理
            // 
            this.btn訂單管理.Location = new System.Drawing.Point(194, 181);
            this.btn訂單管理.Name = "btn訂單管理";
            this.btn訂單管理.Size = new System.Drawing.Size(166, 81);
            this.btn訂單管理.TabIndex = 3;
            this.btn訂單管理.Text = "訂單管理";
            this.btn訂單管理.UseVisualStyleBackColor = true;
            this.btn訂單管理.Visible = false;
            this.btn訂單管理.Click += new System.EventHandler(this.btn訂單管理_Click);
            // 
            // btn返回登入頁面
            // 
            this.btn返回登入頁面.Image = ((System.Drawing.Image)(resources.GetObject("btn返回登入頁面.Image")));
            this.btn返回登入頁面.Location = new System.Drawing.Point(21, 21);
            this.btn返回登入頁面.Name = "btn返回登入頁面";
            this.btn返回登入頁面.Size = new System.Drawing.Size(57, 47);
            this.btn返回登入頁面.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn返回登入頁面.TabIndex = 65;
            this.btn返回登入頁面.TabStop = false;
            this.btn返回登入頁面.Click += new System.EventHandler(this.btn返回登入頁面_Click);
            // 
            // lbl員工
            // 
            this.lbl員工.AutoSize = true;
            this.lbl員工.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl員工.Location = new System.Drawing.Point(24, 116);
            this.lbl員工.Name = "lbl員工";
            this.lbl員工.Size = new System.Drawing.Size(64, 24);
            this.lbl員工.TabIndex = 66;
            this.lbl員工.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 303);
            this.Controls.Add(this.lbl員工);
            this.Controls.Add(this.btn返回登入頁面);
            this.Controls.Add(this.btn訂單管理);
            this.Controls.Add(this.btn人員管理);
            this.Controls.Add(this.btn產品管理);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn返回登入頁面)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn產品管理;
        private System.Windows.Forms.Button btn人員管理;
        private System.Windows.Forms.Button btn訂單管理;
        private System.Windows.Forms.PictureBox btn返回登入頁面;
        private System.Windows.Forms.Label lbl員工;
    }
}

