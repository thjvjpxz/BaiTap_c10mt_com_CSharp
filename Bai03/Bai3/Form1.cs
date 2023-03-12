using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listWeb.Items.Add("www.tamga.tk");
            listWeb.Items.Add("www.c10mt.tk");
            listWeb.Items.Add("www.zing.vn");
            listWeb.Items.Add("Facebook");
            listWeb.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Bạn đã chọn website:\n\n";
            lblLink.Text = listWeb.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            lblLink.Text = "";
        }
    }
}
