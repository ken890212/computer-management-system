namespace WindowsFormsApp1
{
    partial class UserControlOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlOrder));
            this.label2 = new System.Windows.Forms.Label();
            this.txt會員姓名 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxCPU處理器 = new System.Windows.Forms.ComboBox();
            this.cboxMB主機板 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCase小計 = new System.Windows.Forms.Label();
            this.lblCase單價 = new System.Windows.Forms.Label();
            this.lblPsu小計 = new System.Windows.Forms.Label();
            this.lblPsu單價 = new System.Windows.Forms.Label();
            this.lblVga小計 = new System.Windows.Forms.Label();
            this.lblVga單價 = new System.Windows.Forms.Label();
            this.lblSsd小計 = new System.Windows.Forms.Label();
            this.lblSsd單價 = new System.Windows.Forms.Label();
            this.lblRam小計 = new System.Windows.Forms.Label();
            this.lblRam單價 = new System.Windows.Forms.Label();
            this.lblMb小計 = new System.Windows.Forms.Label();
            this.lblMb單價 = new System.Windows.Forms.Label();
            this.lblCpu小計 = new System.Windows.Forms.Label();
            this.lblCpu單價 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxCase數量 = new System.Windows.Forms.ComboBox();
            this.cboxPsu數量 = new System.Windows.Forms.ComboBox();
            this.cboxVga數量 = new System.Windows.Forms.ComboBox();
            this.cboxSsd數量 = new System.Windows.Forms.ComboBox();
            this.cboxRam數量 = new System.Windows.Forms.ComboBox();
            this.cboxMb數量 = new System.Windows.Forms.ComboBox();
            this.cboxCpu數量 = new System.Windows.Forms.ComboBox();
            this.cboxCASE機殼 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxVGA顯示卡 = new System.Windows.Forms.ComboBox();
            this.cboxPSU電源供應 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboxRAM記憶體 = new System.Windows.Forms.ComboBox();
            this.cboxSSD硬碟 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl品項總價 = new System.Windows.Forms.Label();
            this.btn清空估價單 = new System.Windows.Forms.Button();
            this.btn下單 = new System.Windows.Forms.Button();
            this.btn返回首頁 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn返回首頁)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(33, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPU處理器";
            // 
            // txt會員姓名
            // 
            this.txt會員姓名.AutoSize = true;
            this.txt會員姓名.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt會員姓名.Location = new System.Drawing.Point(54, 78);
            this.txt會員姓名.Name = "txt會員姓名";
            this.txt會員姓名.Size = new System.Drawing.Size(106, 24);
            this.txt會員姓名.TabIndex = 3;
            this.txt會員姓名.Text = "會員姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(487, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "電腦估價單";
            // 
            // cboxCPU處理器
            // 
            this.cboxCPU處理器.FormattingEnabled = true;
            this.cboxCPU處理器.Location = new System.Drawing.Point(38, 70);
            this.cboxCPU處理器.Name = "cboxCPU處理器";
            this.cboxCPU處理器.Size = new System.Drawing.Size(604, 26);
            this.cboxCPU處理器.TabIndex = 7;
            this.cboxCPU處理器.SelectedIndexChanged += new System.EventHandler(this.cboxCPU處理器_SelectedIndexChanged);
            // 
            // cboxMB主機板
            // 
            this.cboxMB主機板.FormattingEnabled = true;
            this.cboxMB主機板.Location = new System.Drawing.Point(38, 130);
            this.cboxMB主機板.Name = "cboxMB主機板";
            this.cboxMB主機板.Size = new System.Drawing.Size(604, 26);
            this.cboxMB主機板.TabIndex = 9;
            this.cboxMB主機板.SelectedIndexChanged += new System.EventHandler(this.cboxMB主機板_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(33, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "MB主機板";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCase小計);
            this.groupBox1.Controls.Add(this.lblCase單價);
            this.groupBox1.Controls.Add(this.lblPsu小計);
            this.groupBox1.Controls.Add(this.lblPsu單價);
            this.groupBox1.Controls.Add(this.lblVga小計);
            this.groupBox1.Controls.Add(this.lblVga單價);
            this.groupBox1.Controls.Add(this.lblSsd小計);
            this.groupBox1.Controls.Add(this.lblSsd單價);
            this.groupBox1.Controls.Add(this.lblRam小計);
            this.groupBox1.Controls.Add(this.lblRam單價);
            this.groupBox1.Controls.Add(this.lblMb小計);
            this.groupBox1.Controls.Add(this.lblMb單價);
            this.groupBox1.Controls.Add(this.lblCpu小計);
            this.groupBox1.Controls.Add(this.lblCpu單價);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboxCase數量);
            this.groupBox1.Controls.Add(this.cboxPsu數量);
            this.groupBox1.Controls.Add(this.cboxVga數量);
            this.groupBox1.Controls.Add(this.cboxSsd數量);
            this.groupBox1.Controls.Add(this.cboxRam數量);
            this.groupBox1.Controls.Add(this.cboxMb數量);
            this.groupBox1.Controls.Add(this.cboxCpu數量);
            this.groupBox1.Controls.Add(this.cboxCASE機殼);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboxVGA顯示卡);
            this.groupBox1.Controls.Add(this.cboxPSU電源供應);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboxRAM記憶體);
            this.groupBox1.Controls.Add(this.cboxSSD硬碟);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboxCPU處理器);
            this.groupBox1.Controls.Add(this.cboxMB主機板);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(58, 136);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(955, 482);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "電腦主機";
            // 
            // lblCase小計
            // 
            this.lblCase小計.AutoSize = true;
            this.lblCase小計.Location = new System.Drawing.Point(876, 433);
            this.lblCase小計.Name = "lblCase小計";
            this.lblCase小計.Size = new System.Drawing.Size(34, 18);
            this.lblCase小計.TabIndex = 58;
            this.lblCase小計.Text = "0元";
            // 
            // lblCase單價
            // 
            this.lblCase單價.AutoSize = true;
            this.lblCase單價.Location = new System.Drawing.Point(781, 433);
            this.lblCase單價.Name = "lblCase單價";
            this.lblCase單價.Size = new System.Drawing.Size(34, 18);
            this.lblCase單價.TabIndex = 57;
            this.lblCase單價.Text = "0元";
            // 
            // lblPsu小計
            // 
            this.lblPsu小計.AutoSize = true;
            this.lblPsu小計.Location = new System.Drawing.Point(876, 373);
            this.lblPsu小計.Name = "lblPsu小計";
            this.lblPsu小計.Size = new System.Drawing.Size(34, 18);
            this.lblPsu小計.TabIndex = 56;
            this.lblPsu小計.Text = "0元";
            // 
            // lblPsu單價
            // 
            this.lblPsu單價.AutoSize = true;
            this.lblPsu單價.Location = new System.Drawing.Point(781, 373);
            this.lblPsu單價.Name = "lblPsu單價";
            this.lblPsu單價.Size = new System.Drawing.Size(34, 18);
            this.lblPsu單價.TabIndex = 55;
            this.lblPsu單價.Text = "0元";
            // 
            // lblVga小計
            // 
            this.lblVga小計.AutoSize = true;
            this.lblVga小計.Location = new System.Drawing.Point(876, 313);
            this.lblVga小計.Name = "lblVga小計";
            this.lblVga小計.Size = new System.Drawing.Size(34, 18);
            this.lblVga小計.TabIndex = 54;
            this.lblVga小計.Text = "0元";
            // 
            // lblVga單價
            // 
            this.lblVga單價.AutoSize = true;
            this.lblVga單價.Location = new System.Drawing.Point(781, 313);
            this.lblVga單價.Name = "lblVga單價";
            this.lblVga單價.Size = new System.Drawing.Size(34, 18);
            this.lblVga單價.TabIndex = 53;
            this.lblVga單價.Text = "0元";
            // 
            // lblSsd小計
            // 
            this.lblSsd小計.AutoSize = true;
            this.lblSsd小計.Location = new System.Drawing.Point(876, 253);
            this.lblSsd小計.Name = "lblSsd小計";
            this.lblSsd小計.Size = new System.Drawing.Size(34, 18);
            this.lblSsd小計.TabIndex = 52;
            this.lblSsd小計.Text = "0元";
            // 
            // lblSsd單價
            // 
            this.lblSsd單價.AutoSize = true;
            this.lblSsd單價.Location = new System.Drawing.Point(781, 253);
            this.lblSsd單價.Name = "lblSsd單價";
            this.lblSsd單價.Size = new System.Drawing.Size(34, 18);
            this.lblSsd單價.TabIndex = 51;
            this.lblSsd單價.Text = "0元";
            // 
            // lblRam小計
            // 
            this.lblRam小計.AutoSize = true;
            this.lblRam小計.Location = new System.Drawing.Point(876, 193);
            this.lblRam小計.Name = "lblRam小計";
            this.lblRam小計.Size = new System.Drawing.Size(34, 18);
            this.lblRam小計.TabIndex = 50;
            this.lblRam小計.Text = "0元";
            // 
            // lblRam單價
            // 
            this.lblRam單價.AutoSize = true;
            this.lblRam單價.Location = new System.Drawing.Point(781, 193);
            this.lblRam單價.Name = "lblRam單價";
            this.lblRam單價.Size = new System.Drawing.Size(34, 18);
            this.lblRam單價.TabIndex = 49;
            this.lblRam單價.Text = "0元";
            // 
            // lblMb小計
            // 
            this.lblMb小計.AutoSize = true;
            this.lblMb小計.Location = new System.Drawing.Point(876, 133);
            this.lblMb小計.Name = "lblMb小計";
            this.lblMb小計.Size = new System.Drawing.Size(34, 18);
            this.lblMb小計.TabIndex = 48;
            this.lblMb小計.Text = "0元";
            // 
            // lblMb單價
            // 
            this.lblMb單價.AutoSize = true;
            this.lblMb單價.Location = new System.Drawing.Point(781, 133);
            this.lblMb單價.Name = "lblMb單價";
            this.lblMb單價.Size = new System.Drawing.Size(34, 18);
            this.lblMb單價.TabIndex = 47;
            this.lblMb單價.Text = "0元";
            // 
            // lblCpu小計
            // 
            this.lblCpu小計.AutoSize = true;
            this.lblCpu小計.Location = new System.Drawing.Point(876, 73);
            this.lblCpu小計.Name = "lblCpu小計";
            this.lblCpu小計.Size = new System.Drawing.Size(34, 18);
            this.lblCpu小計.TabIndex = 46;
            this.lblCpu小計.Text = "0元";
            // 
            // lblCpu單價
            // 
            this.lblCpu單價.AutoSize = true;
            this.lblCpu單價.Location = new System.Drawing.Point(781, 73);
            this.lblCpu單價.Name = "lblCpu單價";
            this.lblCpu單價.Size = new System.Drawing.Size(34, 18);
            this.lblCpu單價.TabIndex = 45;
            this.lblCpu單價.Text = "0元";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(876, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 44;
            this.label11.Text = "小計";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(781, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "單價";
            // 
            // cboxCase數量
            // 
            this.cboxCase數量.FormattingEnabled = true;
            this.cboxCase數量.Location = new System.Drawing.Point(648, 430);
            this.cboxCase數量.Name = "cboxCase數量";
            this.cboxCase數量.Size = new System.Drawing.Size(61, 26);
            this.cboxCase數量.TabIndex = 42;
            this.cboxCase數量.SelectedIndexChanged += new System.EventHandler(this.cboxCase數量_SelectedIndexChanged);
            // 
            // cboxPsu數量
            // 
            this.cboxPsu數量.FormattingEnabled = true;
            this.cboxPsu數量.Location = new System.Drawing.Point(648, 370);
            this.cboxPsu數量.Name = "cboxPsu數量";
            this.cboxPsu數量.Size = new System.Drawing.Size(61, 26);
            this.cboxPsu數量.TabIndex = 40;
            this.cboxPsu數量.SelectedIndexChanged += new System.EventHandler(this.cboxPsu數量_SelectedIndexChanged);
            // 
            // cboxVga數量
            // 
            this.cboxVga數量.FormattingEnabled = true;
            this.cboxVga數量.Location = new System.Drawing.Point(648, 310);
            this.cboxVga數量.Name = "cboxVga數量";
            this.cboxVga數量.Size = new System.Drawing.Size(61, 26);
            this.cboxVga數量.TabIndex = 38;
            this.cboxVga數量.SelectedIndexChanged += new System.EventHandler(this.cboxVga數量_SelectedIndexChanged);
            // 
            // cboxSsd數量
            // 
            this.cboxSsd數量.FormattingEnabled = true;
            this.cboxSsd數量.Location = new System.Drawing.Point(648, 250);
            this.cboxSsd數量.Name = "cboxSsd數量";
            this.cboxSsd數量.Size = new System.Drawing.Size(61, 26);
            this.cboxSsd數量.TabIndex = 36;
            this.cboxSsd數量.SelectedIndexChanged += new System.EventHandler(this.cboxSsd數量_SelectedIndexChanged);
            // 
            // cboxRam數量
            // 
            this.cboxRam數量.FormattingEnabled = true;
            this.cboxRam數量.Location = new System.Drawing.Point(648, 190);
            this.cboxRam數量.Name = "cboxRam數量";
            this.cboxRam數量.Size = new System.Drawing.Size(61, 26);
            this.cboxRam數量.TabIndex = 34;
            this.cboxRam數量.SelectedIndexChanged += new System.EventHandler(this.cboxRam數量_SelectedIndexChanged);
            // 
            // cboxMb數量
            // 
            this.cboxMb數量.FormattingEnabled = true;
            this.cboxMb數量.Location = new System.Drawing.Point(648, 130);
            this.cboxMb數量.Name = "cboxMb數量";
            this.cboxMb數量.Size = new System.Drawing.Size(61, 26);
            this.cboxMb數量.TabIndex = 32;
            this.cboxMb數量.SelectedIndexChanged += new System.EventHandler(this.cboxMb數量_SelectedIndexChanged);
            // 
            // cboxCpu數量
            // 
            this.cboxCpu數量.FormattingEnabled = true;
            this.cboxCpu數量.Location = new System.Drawing.Point(648, 70);
            this.cboxCpu數量.Name = "cboxCpu數量";
            this.cboxCpu數量.Size = new System.Drawing.Size(61, 26);
            this.cboxCpu數量.TabIndex = 30;
            this.cboxCpu數量.SelectedIndexChanged += new System.EventHandler(this.cboxCpu數量_SelectedIndexChanged);
            // 
            // cboxCASE機殼
            // 
            this.cboxCASE機殼.FormattingEnabled = true;
            this.cboxCASE機殼.Location = new System.Drawing.Point(38, 430);
            this.cboxCASE機殼.Name = "cboxCASE機殼";
            this.cboxCASE機殼.Size = new System.Drawing.Size(604, 26);
            this.cboxCASE機殼.TabIndex = 19;
            this.cboxCASE機殼.SelectedIndexChanged += new System.EventHandler(this.cboxCASE機殼_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(33, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "CASE機殼";
            // 
            // cboxVGA顯示卡
            // 
            this.cboxVGA顯示卡.FormattingEnabled = true;
            this.cboxVGA顯示卡.Location = new System.Drawing.Point(38, 310);
            this.cboxVGA顯示卡.Name = "cboxVGA顯示卡";
            this.cboxVGA顯示卡.Size = new System.Drawing.Size(604, 26);
            this.cboxVGA顯示卡.TabIndex = 15;
            this.cboxVGA顯示卡.SelectedIndexChanged += new System.EventHandler(this.cboxVGA顯示卡_SelectedIndexChanged);
            // 
            // cboxPSU電源供應
            // 
            this.cboxPSU電源供應.FormattingEnabled = true;
            this.cboxPSU電源供應.Location = new System.Drawing.Point(38, 370);
            this.cboxPSU電源供應.Name = "cboxPSU電源供應";
            this.cboxPSU電源供應.Size = new System.Drawing.Size(604, 26);
            this.cboxPSU電源供應.TabIndex = 17;
            this.cboxPSU電源供應.SelectedIndexChanged += new System.EventHandler(this.cboxPSU電源供應_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(33, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "VGA顯示卡";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(33, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "PSU電源供應";
            // 
            // cboxRAM記憶體
            // 
            this.cboxRAM記憶體.FormattingEnabled = true;
            this.cboxRAM記憶體.Location = new System.Drawing.Point(38, 190);
            this.cboxRAM記憶體.Name = "cboxRAM記憶體";
            this.cboxRAM記憶體.Size = new System.Drawing.Size(604, 26);
            this.cboxRAM記憶體.TabIndex = 11;
            this.cboxRAM記憶體.SelectedIndexChanged += new System.EventHandler(this.cboxRAM記憶體_SelectedIndexChanged);
            // 
            // cboxSSD硬碟
            // 
            this.cboxSSD硬碟.FormattingEnabled = true;
            this.cboxSSD硬碟.Location = new System.Drawing.Point(38, 250);
            this.cboxSSD硬碟.Name = "cboxSSD硬碟";
            this.cboxSSD硬碟.Size = new System.Drawing.Size(604, 26);
            this.cboxSSD硬碟.TabIndex = 13;
            this.cboxSSD硬碟.SelectedIndexChanged += new System.EventHandler(this.cboxSSD硬碟_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(33, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "RAM記憶體";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(33, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "硬碟/SSD";
            // 
            // lbl品項總價
            // 
            this.lbl品項總價.AutoSize = true;
            this.lbl品項總價.BackColor = System.Drawing.Color.Transparent;
            this.lbl品項總價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl品項總價.Location = new System.Drawing.Point(577, 88);
            this.lbl品項總價.Name = "lbl品項總價";
            this.lbl品項總價.Size = new System.Drawing.Size(105, 30);
            this.lbl品項總價.TabIndex = 61;
            this.lbl品項總價.Text = "總價:0元";
            // 
            // btn清空估價單
            // 
            this.btn清空估價單.Location = new System.Drawing.Point(908, 78);
            this.btn清空估價單.Name = "btn清空估價單";
            this.btn清空估價單.Size = new System.Drawing.Size(132, 40);
            this.btn清空估價單.TabIndex = 63;
            this.btn清空估價單.Text = "重新估價";
            this.btn清空估價單.UseVisualStyleBackColor = true;
            this.btn清空估價單.Click += new System.EventHandler(this.btn清空估價單_Click);
            // 
            // btn下單
            // 
            this.btn下單.Location = new System.Drawing.Point(1046, 78);
            this.btn下單.Name = "btn下單";
            this.btn下單.Size = new System.Drawing.Size(76, 40);
            this.btn下單.TabIndex = 62;
            this.btn下單.Text = "下單";
            this.btn下單.UseVisualStyleBackColor = true;
            this.btn下單.Click += new System.EventHandler(this.btn下單_Click);
            // 
            // btn返回首頁
            // 
            this.btn返回首頁.Image = ((System.Drawing.Image)(resources.GetObject("btn返回首頁.Image")));
            this.btn返回首頁.Location = new System.Drawing.Point(12, 12);
            this.btn返回首頁.Name = "btn返回首頁";
            this.btn返回首頁.Size = new System.Drawing.Size(50, 38);
            this.btn返回首頁.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn返回首頁.TabIndex = 64;
            this.btn返回首頁.TabStop = false;
            this.btn返回首頁.Click += new System.EventHandler(this.btn返回首頁_Click);
            // 
            // UserControlOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 654);
            this.Controls.Add(this.btn返回首頁);
            this.Controls.Add(this.lbl品項總價);
            this.Controls.Add(this.btn清空估價單);
            this.Controls.Add(this.btn下單);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt會員姓名);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserControlOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "電腦估價單";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn返回首頁)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt會員姓名;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxCPU處理器;
        private System.Windows.Forms.ComboBox cboxMB主機板;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxCASE機殼;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxVGA顯示卡;
        private System.Windows.Forms.ComboBox cboxPSU電源供應;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxRAM記憶體;
        private System.Windows.Forms.ComboBox cboxSSD硬碟;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxCpu數量;
        private System.Windows.Forms.ComboBox cboxCase數量;
        private System.Windows.Forms.ComboBox cboxPsu數量;
        private System.Windows.Forms.ComboBox cboxVga數量;
        private System.Windows.Forms.ComboBox cboxSsd數量;
        private System.Windows.Forms.ComboBox cboxRam數量;
        private System.Windows.Forms.ComboBox cboxMb數量;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCase小計;
        private System.Windows.Forms.Label lblCase單價;
        private System.Windows.Forms.Label lblPsu小計;
        private System.Windows.Forms.Label lblPsu單價;
        private System.Windows.Forms.Label lblVga小計;
        private System.Windows.Forms.Label lblVga單價;
        private System.Windows.Forms.Label lblSsd小計;
        private System.Windows.Forms.Label lblSsd單價;
        private System.Windows.Forms.Label lblRam小計;
        private System.Windows.Forms.Label lblRam單價;
        private System.Windows.Forms.Label lblMb小計;
        private System.Windows.Forms.Label lblMb單價;
        private System.Windows.Forms.Label lblCpu小計;
        private System.Windows.Forms.Label lblCpu單價;
        private System.Windows.Forms.Label lbl品項總價;
        private System.Windows.Forms.Button btn清空估價單;
        private System.Windows.Forms.Button btn下單;
        private System.Windows.Forms.PictureBox btn返回首頁;
    }
}