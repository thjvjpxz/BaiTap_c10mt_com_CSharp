using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai12
{
    public partial class Form1 : Form
    {
        int ts1, ms1;
        int ts2, ms2;
        string phepTinh = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtms1.Clear();
            txtms2.Clear();
            txtResultms.Clear();
            txtResultts.Clear();
            txtts1.Clear();
            txtts2.Clear();
        }

        private bool CheckLoiCuPhap()
        {
            if (!int.TryParse(txtts1.Text, out ts1) ||
                !int.TryParse(txtts2.Text, out ts2) ||
                !int.TryParse(txtms1.Text, out ms1) ||
                !int.TryParse(txtms2.Text, out ms2))
                return true;
            return false;
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int tsr, msr;
            
            if (CheckLoiCuPhap())
            {
                string message = "Lỗi nhập liệu";
                string title = "Thông báo";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            phepTinh = ((Button)sender).Text;

            switch (phepTinh)
            {
                case "Cộng":
                    Solution.CongPS(ts1, ts2, ms1, ms2, out tsr, out msr);
                    break;
                case "Trừ":
                    Solution.TruPS(ts1, ts2, ms1, ms2, out tsr, out msr);
                    break;
                case "Nhân":
                    Solution.NhanPS(ts1, ts2, ms1, ms2, out tsr, out msr);
                    break;
                case "Chia":
                    Solution.NhanPS(ts1, ms2, ms1, ts2, out tsr, out msr);
                    break;
                default:
                    msr = 0;
                    tsr = 0;
                    break;
            }
            txtResultms.Text = msr + "";
            txtResultts.Text = tsr + "";
        }
    }
}
