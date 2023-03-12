using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb1.Items.Add("tamga");
            lb1.Items.Add("c10mt");
            lb1.Items.Add("c10maytinh");
            lb2.Items.Add("Bạn đã chọn site:");
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb2.Items.Add("www." + lb1.Text + ".tk");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb2.Items.Clear();
            lb2.Items.Add("Bạn đã chọn site:");
        }
    }
}
