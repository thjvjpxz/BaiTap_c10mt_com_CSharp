using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                txtC.Enabled = false;
            else
                txtC.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            string message = "Vui lòng chỉ nhập số!";
            string title = "Chú ý";
            if (!double.TryParse(txtA.Text, out a) || !double.TryParse(txtB.Text, out b))
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (radioButton1.Checked)
                {
                    txtResult.Text = "PT có nghiệm: " + Solution.phuongTrinhBac1(a, b);
                }
                else
                {
                    if (!double.TryParse(txtC.Text, out c))
                        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    double? res1 = null;
                    double? res2 = null;
                    if (Solution.phuongTrinhBac2(a, b, c, out res1, out res2))
                    {
                        txtResult.Text = "PT có 2 nghiệm: x1=" + res2 + " và x2=" + res1;
                    }
                    else
                        txtResult.Text = "PT vô nghiệm";
                }
            }
                
        }
    }
}
