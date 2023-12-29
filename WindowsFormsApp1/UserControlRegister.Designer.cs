namespace WindowsFormsApp1
{
    partial class UserControlRegister
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
            this.lbl回到登入頁面 = new System.Windows.Forms.Label();
            this.btn註冊 = new System.Windows.Forms.Button();
            this.txt註冊Password = new System.Windows.Forms.TextBox();
            this.txt註冊UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt註冊email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl回到登入頁面
            // 
            this.lbl回到登入頁面.AutoSize = true;
            this.lbl回到登入頁面.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl回到登入頁面.ForeColor = System.Drawing.Color.Blue;
            this.lbl回到登入頁面.Location = new System.Drawing.Point(178, 303);
            this.lbl回到登入頁面.Name = "lbl回到登入頁面";
            this.lbl回到登入頁面.Size = new System.Drawing.Size(134, 18);
            this.lbl回到登入頁面.TabIndex = 19;
            this.lbl回到登入頁面.Text = "已有密碼，登入";
            this.lbl回到登入頁面.Click += new System.EventHandler(this.lbl回到登入頁面_Click);
            // 
            // btn註冊
            // 
            this.btn註冊.Location = new System.Drawing.Point(178, 362);
            this.btn註冊.Name = "btn註冊";
            this.btn註冊.Size = new System.Drawing.Size(184, 38);
            this.btn註冊.TabIndex = 17;
            this.btn註冊.Text = "註冊";
            this.btn註冊.UseVisualStyleBackColor = true;
            this.btn註冊.Click += new System.EventHandler(this.btn註冊_Click);
            // 
            // txt註冊Password
            // 
            this.txt註冊Password.Location = new System.Drawing.Point(181, 170);
            this.txt註冊Password.Name = "txt註冊Password";
            this.txt註冊Password.PasswordChar = '*';
            this.txt註冊Password.Size = new System.Drawing.Size(186, 29);
            this.txt註冊Password.TabIndex = 16;
            // 
            // txt註冊UserName
            // 
            this.txt註冊UserName.Location = new System.Drawing.Point(181, 102);
            this.txt註冊UserName.Name = "txt註冊UserName";
            this.txt註冊UserName.Size = new System.Drawing.Size(186, 29);
            this.txt註冊UserName.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "密碼:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "使用者名稱:";
            // 
            // txt註冊email
            // 
            this.txt註冊email.Location = new System.Drawing.Point(181, 237);
            this.txt註冊email.Name = "txt註冊email";
            this.txt註冊email.PasswordChar = '*';
            this.txt註冊email.Size = new System.Drawing.Size(186, 29);
            this.txt註冊email.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "信箱:";
            // 
            // UserControlRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 504);
            this.Controls.Add(this.txt註冊email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl回到登入頁面);
            this.Controls.Add(this.btn註冊);
            this.Controls.Add(this.txt註冊Password);
            this.Controls.Add(this.txt註冊UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserControlRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserControlRegister";
            this.Load += new System.EventHandler(this.UserControlRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl回到登入頁面;
        private System.Windows.Forms.Button btn註冊;
        private System.Windows.Forms.TextBox txt註冊Password;
        private System.Windows.Forms.TextBox txt註冊UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt註冊email;
        private System.Windows.Forms.Label label3;
    }
}