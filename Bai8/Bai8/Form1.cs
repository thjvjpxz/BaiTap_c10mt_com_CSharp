using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        string phepTinh = "";
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtResult.Clear();
        }

        private void GetAB()
        {
            string message = "Vui lòng nhập số !";
            string title = "Chú ý";
            if (!int.TryParse(txtA.Text, out a) || !int.TryParse(txtB.Text, out b))
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            phepTinh = ((Button)sender).Text;

            GetAB();

            switch (phepTinh)
            {
                case "Cộng":
                    txtResult.Text = (a + b) + "";
                    break;
                case "Trừ":
                    txtResult.Text = (a - b) + "";
                    break;
                case "Nhân":
                    txtResult.Text = (a * b) + "";
                    break;
                case "Chia":
                    if (b == 0)
                        txtResult.Text = "Không chia được";
                    else
                        txtResult.Text = (a / b) + "";
                    break;
            }
        }
    }
}
