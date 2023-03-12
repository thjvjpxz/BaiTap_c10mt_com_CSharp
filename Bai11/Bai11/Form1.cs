using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            int n;

            if (!int.TryParse(txtNumber.Text, out n))
                //MessageBox.Show("Lỗi nhập liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblError.Text = "Vui lòng nhập số";
            else
            {
                lblError.Text = "";
                txtCheckSNT.Text = (Solution.checkSNT(n) ? n + " là số nguyên tố" : n + " không là số nguyên tố");
                txtSearch.Text = Solution.SNT(n);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
