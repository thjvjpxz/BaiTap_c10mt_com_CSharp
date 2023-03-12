namespace Bai9
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtTongAll = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Dãy Số và Tính Tổng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtTongAll);
            this.panel1.Controls.Add(this.txtDay);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.txtTongLe);
            this.panel1.Controls.Add(this.txtTongChan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 173);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập số :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dãy vừa nhập :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng các phần tử trong dãy :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng Chẵn :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tổng lẻ :";
            // 
            // txtTongChan
            // 
            this.txtTongChan.Enabled = false;
            this.txtTongChan.Location = new System.Drawing.Point(104, 130);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(81, 22);
            this.txtTongChan.TabIndex = 5;
            // 
            // txtTongLe
            // 
            this.txtTongLe.Enabled = false;
            this.txtTongLe.Location = new System.Drawing.Point(279, 130);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.Size = new System.Drawing.Size(81, 22);
            this.txtTongLe.TabIndex = 6;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(87, 27);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(116, 22);
            this.txtNumber.TabIndex = 7;
            // 
            // txtDay
            // 
            this.txtDay.Enabled = false;
            this.txtDay.Location = new System.Drawing.Point(122, 62);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(238, 22);
            this.txtDay.TabIndex = 8;
            // 
            // txtTongAll
            // 
            this.txtTongAll.Enabled = false;
            this.txtTongAll.Location = new System.Drawing.Point(209, 95);
            this.txtTongAll.Name = "txtTongAll";
            this.txtTongAll.Size = new System.Drawing.Size(151, 22);
            this.txtTongAll.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tiếp Tục";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 333);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTongAll;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

