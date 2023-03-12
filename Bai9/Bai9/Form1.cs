using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        int tongAll = 0, tongChan = 0, tongLe = 0;
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
            txtNumber.Clear();
            txtDay.Clear();
            txtTongAll.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Vui lòng nhập số nguyên";
            string title = "Chú ý";
            int a;
            if (!int.TryParse(txtNumber.Text, out a))
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                txtDay.Text += a + " ";

                tongAll += a;
                txtTongAll.Text = tongAll + "";

                tongChan += (a % 2 != 0 ? 0 : a);
                txtTongChan.Text = tongChan + "";

                tongLe += (a % 2 != 0 ? a : 0);
                txtTongLe.Text = tongLe + "";
            }
            txtNumber.Focus();
        }
    }
}
