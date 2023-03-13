using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (TextBox text in panel1.Controls.OfType<TextBox>())
                text.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chuThuong.Checked)
                txtResult.Text = Solution.inThuong(txtEnter.Text);
            else if (chuHoa.Checked)
                txtResult.Text = Solution.inHoa(txtEnter.Text);
            else
                MessageBox.Show("Vui lòng lựa chọn in hoa hoặc in thường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
