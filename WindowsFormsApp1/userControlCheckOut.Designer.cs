namespace WindowsFormsApp1
{
    partial class userControlCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userControlCheckOut));
            this.txt訂購人地址 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt訂購人電話 = new System.Windows.Forms.TextBox();
            this.btn確認訂購 = new System.Windows.Forms.Button();
            this.btn返回估價單頁面 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn返回估價單頁面)).BeginInit();
            this.SuspendLayout();
            // 
            // txt訂購人地址
            // 
            this.txt訂購人地址.Location = new System.Drawing.Point(105, 138);
            this.txt訂購人地址.Name = "txt訂購人地址";
            this.txt訂購人地址.Size = new System.Drawing.Size(192, 29);
            this.txt訂購人地址.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "訂購人地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "訂購人電話";
            // 
            // txt訂購人電話
            // 
            this.txt訂購人電話.Location = new System.Drawing.Point(105, 212);
            this.txt訂購人電話.Name = "txt訂購人電話";
            this.txt訂購人電話.Size = new System.Drawing.Size(189, 29);
            this.txt訂購人電話.TabIndex = 2;
            // 
            // btn確認訂購
            // 
            this.btn確認訂購.Location = new System.Drawing.Point(127, 256);
            this.btn確認訂購.Name = "btn確認訂購";
            this.btn確認訂購.Size = new System.Drawing.Size(143, 40);
            this.btn確認訂購.TabIndex = 63;
            this.btn確認訂購.Text = "確認訂購";
            this.btn確認訂購.UseVisualStyleBackColor = true;
            this.btn確認訂購.Click += new System.EventHandler(this.btn確認訂購_Click);
            // 
            // btn返回估價單頁面
            // 
            this.btn返回估價單頁面.Image = ((System.Drawing.Image)(resources.GetObject("btn返回估價單頁面.Image")));
            this.btn返回估價單頁面.Location = new System.Drawing.Point(12, 12);
            this.btn返回估價單頁面.Name = "btn返回估價單頁面";
            this.btn返回估價單頁面.Size = new System.Drawing.Size(60, 43);
            this.btn返回估價單頁面.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn返回估價單頁面.TabIndex = 64;
            this.btn返回估價單頁面.TabStop = false;
            this.btn返回估價單頁面.Click += new System.EventHandler(this.btn返回估價單頁面_Click);
            // 
            // userControlCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 428);
            this.Controls.Add(this.btn返回估價單頁面);
            this.Controls.Add(this.btn確認訂購);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt訂購人電話);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt訂購人地址);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userControlCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userControlCheckOut";
            this.Load += new System.EventHandler(this.userControlCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn返回估價單頁面)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt訂購人地址;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt訂購人電話;
        private System.Windows.Forms.Button btn確認訂購;
        private System.Windows.Forms.PictureBox btn返回估價單頁面;
    }
}