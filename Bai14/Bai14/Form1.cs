using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Hình Tròn - Hình Vuông\nHình Tam Giác - Hình Chữ Nhật";


            groupBox4.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TextBox text in groupBox2.Controls.OfType<TextBox>())
                text.Clear();

            foreach (TextBox text in groupBox3.Controls.OfType<TextBox>())
                text.Clear();

            foreach (TextBox text in groupBox4.Controls.OfType<TextBox>())
                text.Clear();

            foreach (TextBox text in groupBox5.Controls.OfType<TextBox>())
                text.Clear();

            foreach (GroupBox group in this.Controls.OfType<GroupBox>())
                group.Visible = false;
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dienTich = 0, chuVi = 0;
            string message = "Lỗi nhập liệu";
            string title = "Thông báo";
            if (hv.Checked)
            {
                double a;
                if (!double.TryParse(txtHVA.Text, out a))
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Solution.HinhVuong(a, out chuVi, out dienTich);
                    txtHVC.Text = chuVi + "";
                    txtHVS.Text = dienTich + "";
                }
            }
            else if (hcn.Checked)
            {
                double a, b;
                if (!double.TryParse(txtHCNA.Text, out a) ||
                    !double.TryParse(txtHCNB.Text, out b))
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Solution.HinhChuNhat(a, b, out chuVi, out dienTich);
                    txtHCNC.Text = chuVi + "";
                    txtHCNS.Text = dienTich + "";
                }
            }
            else if (htg.Checked)
            {
                double a, b, c;
                if (!double.TryParse(txta.Text, out a) ||
                    !double.TryParse(txtb.Text, out b) ||
                    !double.TryParse(txtc.Text, out c))
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Solution.HinhTamGiac(a, b, c, out chuVi, out dienTich);
                    string res = Solution.checkTamGiac(a, b, c);
                    if (res == "-1")
                        txtTamGiacLoai.Text = "Không phải là tam giác";
                    else
                    {
                        txtTamGiacC.Text = chuVi + "";
                        txtTamGiacS.Text = dienTich + "";
                        txtTamGiacLoai.Text = res + "";
                    }
                }
            }
            else if (ht.Checked)
            {
                double r;
                if (!double.TryParse(txtHinhTron.Text, out r))
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Solution.HinhTron(r, out chuVi, out dienTich);
                    txtHinhTronC.Text = chuVi + "";
                    txtHinhTronS.Text = dienTich + "";
                }
            }
        }

        private void hv_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
        }

        private void ht_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
        }

        private void hcn_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox3.Visible = true;
        }

        private void htg_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox2.Visible = true;
        }
    }
}
