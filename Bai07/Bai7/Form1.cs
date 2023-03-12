using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TextBox text in panel1.Controls.OfType<TextBox>())
                text.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(txta.Text, out a) || !int.TryParse(txtb.Text, out b))
                MessageBox.Show("Nhập sai định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                txtUoc.Text = Solution.GCD(a, b) + "";
                txtBoi.Text = Solution.LCM(a, b) + "";
            }
        }
    }
}
