using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtBoi.Clear();
            txtUoc.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            string message = "Vui lòng nhập số";
            string title = "Chú ý";
            if (!int.TryParse(txtA.Text, out a) || !int.TryParse(txtB.Text, out b))
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                txtUoc.Text = Solution.GCD(a, b) + "";
                txtBoi.Text = Solution.LCM(a, b) + "";
            }
                
        }
    }
}
