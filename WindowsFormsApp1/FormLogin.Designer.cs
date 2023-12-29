namespace WindowsFormsApp1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btn會員登入 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl會員註冊 = new System.Windows.Forms.Label();
            this.btn員工登入 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn會員登入
            // 
            this.btn會員登入.Location = new System.Drawing.Point(181, 401);
            this.btn會員登入.Name = "btn會員登入";
            this.btn會員登入.Size = new System.Drawing.Size(184, 38);
            this.btn會員登入.TabIndex = 10;
            this.btn會員登入.Text = "會員登入";
            this.btn會員登入.UseVisualStyleBackColor = true;
            this.btn會員登入.Click += new System.EventHandler(this.btn會員登入_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(182, 318);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(186, 29);
            this.txtPassword.TabIndex = 9;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(182, 250);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(186, 29);
            this.txtUserName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "密碼:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "使用者名稱:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbl會員註冊
            // 
            this.lbl會員註冊.AutoSize = true;
            this.lbl會員註冊.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl會員註冊.ForeColor = System.Drawing.Color.Blue;
            this.lbl會員註冊.Location = new System.Drawing.Point(182, 363);
            this.lbl會員註冊.Name = "lbl會員註冊";
            this.lbl會員註冊.Size = new System.Drawing.Size(80, 18);
            this.lbl會員註冊.TabIndex = 12;
            this.lbl會員註冊.Text = "會員註冊";
            this.lbl會員註冊.Click += new System.EventHandler(this.lbl會員註冊_Click);
            // 
            // btn員工登入
            // 
            this.btn員工登入.Location = new System.Drawing.Point(181, 445);
            this.btn員工登入.Name = "btn員工登入";
            this.btn員工登入.Size = new System.Drawing.Size(184, 38);
            this.btn員工登入.TabIndex = 13;
            this.btn員工登入.Text = "員工登入";
            this.btn員工登入.UseVisualStyleBackColor = true;
            this.btn員工登入.Click += new System.EventHandler(this.btn員工登入_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 504);
            this.Controls.Add(this.btn員工登入);
            this.Controls.Add(this.lbl會員註冊);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn會員登入);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Shop Management System | Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn會員登入;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbl會員註冊;
        private System.Windows.Forms.Button btn員工登入;
    }
}