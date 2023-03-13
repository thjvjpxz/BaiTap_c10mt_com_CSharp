namespace Bai14
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.htg = new System.Windows.Forms.RadioButton();
            this.hcn = new System.Windows.Forms.RadioButton();
            this.ht = new System.Windows.Forms.RadioButton();
            this.hv = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTamGiacLoai = new System.Windows.Forms.TextBox();
            this.txtTamGiacS = new System.Windows.Forms.TextBox();
            this.txtTamGiacC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHCNB = new System.Windows.Forms.TextBox();
            this.txtHCNA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHCNS = new System.Windows.Forms.TextBox();
            this.txtHCNC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtHVA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHVS = new System.Windows.Forms.TextBox();
            this.txtHVC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtHinhTron = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHinhTronS = new System.Windows.Forms.TextBox();
            this.txtHinhTronC = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chu Vi và Diện Tích";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(2, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 60);
            this.label2.TabIndex = 0;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.htg);
            this.groupBox1.Controls.Add(this.hcn);
            this.groupBox1.Controls.Add(this.ht);
            this.groupBox1.Controls.Add(this.hv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(422, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mời bạn lựa chọn";
            // 
            // htg
            // 
            this.htg.AutoSize = true;
            this.htg.Location = new System.Drawing.Point(238, 87);
            this.htg.Name = "htg";
            this.htg.Size = new System.Drawing.Size(131, 23);
            this.htg.TabIndex = 3;
            this.htg.Text = "Hình Tam Giác";
            this.htg.UseVisualStyleBackColor = true;
            this.htg.CheckedChanged += new System.EventHandler(this.htg_CheckedChanged);
            // 
            // hcn
            // 
            this.hcn.AutoSize = true;
            this.hcn.Location = new System.Drawing.Point(238, 37);
            this.hcn.Name = "hcn";
            this.hcn.Size = new System.Drawing.Size(131, 23);
            this.hcn.TabIndex = 2;
            this.hcn.Text = "Hình Chữ Nhật";
            this.hcn.UseVisualStyleBackColor = true;
            this.hcn.CheckedChanged += new System.EventHandler(this.hcn_CheckedChanged);
            // 
            // ht
            // 
            this.ht.AutoSize = true;
            this.ht.Location = new System.Drawing.Point(42, 87);
            this.ht.Name = "ht";
            this.ht.Size = new System.Drawing.Size(98, 23);
            this.ht.TabIndex = 1;
            this.ht.Text = "Hình Tròn";
            this.ht.UseVisualStyleBackColor = true;
            this.ht.CheckedChanged += new System.EventHandler(this.ht_CheckedChanged);
            // 
            // hv
            // 
            this.hv.AutoSize = true;
            this.hv.Location = new System.Drawing.Point(42, 37);
            this.hv.Name = "hv";
            this.hv.Size = new System.Drawing.Size(110, 23);
            this.hv.TabIndex = 0;
            this.hv.Text = "Hình Vuông";
            this.hv.UseVisualStyleBackColor = true;
            this.hv.CheckedChanged += new System.EventHandler(this.hv_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thực Hiện";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(185, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(340, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 53);
            this.button3.TabIndex = 5;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTamGiacLoai);
            this.groupBox2.Controls.Add(this.txtTamGiacS);
            this.groupBox2.Controls.Add(this.txtTamGiacC);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtc);
            this.groupBox2.Controls.Add(this.txtb);
            this.groupBox2.Controls.Add(this.txta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 216);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình Tam Giác";
            // 
            // txtTamGiacLoai
            // 
            this.txtTamGiacLoai.Enabled = false;
            this.txtTamGiacLoai.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamGiacLoai.Location = new System.Drawing.Point(42, 178);
            this.txtTamGiacLoai.Multiline = true;
            this.txtTamGiacLoai.Name = "txtTamGiacLoai";
            this.txtTamGiacLoai.Size = new System.Drawing.Size(342, 31);
            this.txtTamGiacLoai.TabIndex = 10;
            // 
            // txtTamGiacS
            // 
            this.txtTamGiacS.Enabled = false;
            this.txtTamGiacS.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamGiacS.Location = new System.Drawing.Point(125, 137);
            this.txtTamGiacS.Multiline = true;
            this.txtTamGiacS.Name = "txtTamGiacS";
            this.txtTamGiacS.Size = new System.Drawing.Size(259, 31);
            this.txtTamGiacS.TabIndex = 9;
            // 
            // txtTamGiacC
            // 
            this.txtTamGiacC.Enabled = false;
            this.txtTamGiacC.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamGiacC.Location = new System.Drawing.Point(125, 96);
            this.txtTamGiacC.Multiline = true;
            this.txtTamGiacC.Name = "txtTamGiacC";
            this.txtTamGiacC.Size = new System.Drawing.Size(259, 31);
            this.txtTamGiacC.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Diện Tích :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chu Vi :";
            // 
            // txtc
            // 
            this.txtc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc.Location = new System.Drawing.Point(318, 58);
            this.txtc.Multiline = true;
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(66, 28);
            this.txtc.TabIndex = 5;
            // 
            // txtb
            // 
            this.txtb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb.Location = new System.Drawing.Point(173, 58);
            this.txtb.Multiline = true;
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(66, 28);
            this.txtb.TabIndex = 4;
            // 
            // txta
            // 
            this.txta.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txta.Location = new System.Drawing.Point(38, 58);
            this.txta.Multiline = true;
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(66, 28);
            this.txta.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập C :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập B :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập A :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHCNB);
            this.groupBox3.Controls.Add(this.txtHCNA);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtHCNS);
            this.groupBox3.Controls.Add(this.txtHCNC);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(30, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 216);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hình Chữ Nhật";
            // 
            // txtHCNB
            // 
            this.txtHCNB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCNB.Location = new System.Drawing.Point(125, 78);
            this.txtHCNB.Multiline = true;
            this.txtHCNB.Name = "txtHCNB";
            this.txtHCNB.Size = new System.Drawing.Size(259, 31);
            this.txtHCNB.TabIndex = 13;
            // 
            // txtHCNA
            // 
            this.txtHCNA.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCNA.Location = new System.Drawing.Point(125, 31);
            this.txtHCNA.Multiline = true;
            this.txtHCNA.Name = "txtHCNA";
            this.txtHCNA.Size = new System.Drawing.Size(259, 31);
            this.txtHCNA.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nhập B :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nhập A :";
            // 
            // txtHCNS
            // 
            this.txtHCNS.Enabled = false;
            this.txtHCNS.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCNS.Location = new System.Drawing.Point(125, 172);
            this.txtHCNS.Multiline = true;
            this.txtHCNS.Name = "txtHCNS";
            this.txtHCNS.Size = new System.Drawing.Size(259, 31);
            this.txtHCNS.TabIndex = 9;
            // 
            // txtHCNC
            // 
            this.txtHCNC.Enabled = false;
            this.txtHCNC.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHCNC.Location = new System.Drawing.Point(125, 125);
            this.txtHCNC.Multiline = true;
            this.txtHCNC.Name = "txtHCNC";
            this.txtHCNC.Size = new System.Drawing.Size(259, 31);
            this.txtHCNC.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Diện Tích :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Chu Vi :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtHVA);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtHVS);
            this.groupBox4.Controls.Add(this.txtHVC);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(30, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 216);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hình Vuông";
            // 
            // txtHVA
            // 
            this.txtHVA.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHVA.Location = new System.Drawing.Point(125, 28);
            this.txtHVA.Multiline = true;
            this.txtHVA.Name = "txtHVA";
            this.txtHVA.Size = new System.Drawing.Size(259, 31);
            this.txtHVA.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 19);
            this.label13.TabIndex = 10;
            this.label13.Text = "Nhập Cạnh A :";
            // 
            // txtHVS
            // 
            this.txtHVS.Enabled = false;
            this.txtHVS.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHVS.Location = new System.Drawing.Point(125, 170);
            this.txtHVS.Multiline = true;
            this.txtHVS.Name = "txtHVS";
            this.txtHVS.Size = new System.Drawing.Size(259, 31);
            this.txtHVS.TabIndex = 9;
            // 
            // txtHVC
            // 
            this.txtHVC.Enabled = false;
            this.txtHVC.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHVC.Location = new System.Drawing.Point(125, 99);
            this.txtHVC.Multiline = true;
            this.txtHVC.Name = "txtHVC";
            this.txtHVC.Size = new System.Drawing.Size(259, 31);
            this.txtHVC.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 19);
            this.label14.TabIndex = 7;
            this.label14.Text = "Diện Tích :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Chu Vi :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtHinhTron);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtHinhTronS);
            this.groupBox5.Controls.Add(this.txtHinhTronC);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(30, 324);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(422, 216);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hình Tròn";
            // 
            // txtHinhTron
            // 
            this.txtHinhTron.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHinhTron.Location = new System.Drawing.Point(125, 34);
            this.txtHinhTron.Multiline = true;
            this.txtHinhTron.Name = "txtHinhTron";
            this.txtHinhTron.Size = new System.Drawing.Size(259, 31);
            this.txtHinhTron.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 19);
            this.label12.TabIndex = 10;
            this.label12.Text = "Nhập Bán Kính :";
            // 
            // txtHinhTronS
            // 
            this.txtHinhTronS.Enabled = false;
            this.txtHinhTronS.Location = new System.Drawing.Point(125, 170);
            this.txtHinhTronS.Multiline = true;
            this.txtHinhTronS.Name = "txtHinhTronS";
            this.txtHinhTronS.Size = new System.Drawing.Size(259, 31);
            this.txtHinhTronS.TabIndex = 9;
            // 
            // txtHinhTronC
            // 
            this.txtHinhTronC.Enabled = false;
            this.txtHinhTronC.Location = new System.Drawing.Point(125, 102);
            this.txtHinhTronC.Multiline = true;
            this.txtHinhTronC.Name = "txtHinhTronC";
            this.txtHinhTronC.Size = new System.Drawing.Size(259, 31);
            this.txtHinhTronC.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 19);
            this.label16.TabIndex = 7;
            this.label16.Text = "Diện Tích :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(55, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 19);
            this.label17.TabIndex = 6;
            this.label17.Text = "Chu Vi :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 552);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton htg;
        private System.Windows.Forms.RadioButton hcn;
        private System.Windows.Forms.RadioButton ht;
        private System.Windows.Forms.RadioButton hv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtTamGiacS;
        private System.Windows.Forms.TextBox txtTamGiacC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTamGiacLoai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtHCNS;
        private System.Windows.Forms.TextBox txtHCNC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHCNB;
        private System.Windows.Forms.TextBox txtHCNA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtHVA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHVS;
        private System.Windows.Forms.TextBox txtHVC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtHinhTron;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHinhTronS;
        private System.Windows.Forms.TextBox txtHinhTronC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

