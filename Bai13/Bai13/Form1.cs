using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai13
{
    public partial class Form1 : Form
    {
        string phepTinh = "";
        double result = 0;
        byte demPhepTinh = 0;
        bool nhapLai = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nhapLai)
                txtPhepTinh.Clear();
            nhapLai = false;
            Button button = (Button)sender;

            txtPhepTinh.Text += button.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtPhepTinh.Clear();
            phepTinh = "";
            result = 0;
            demPhepTinh = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            demPhepTinh++;
            phepTinh = ((Button)sender).Text;

            if (demPhepTinh == 1)
            {
                result = double.Parse(txtPhepTinh.Text);
                txtPhepTinh.Clear();
            }
            else
            {
                button11.PerformClick();
                nhapLai = true;
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (phepTinh)
            {
                case "+":
                    result += double.Parse(txtPhepTinh.Text);
                    txtPhepTinh.Text = result + "";
                    break;
                case "-":
                    result -= double.Parse(txtPhepTinh.Text);
                    txtPhepTinh.Text = result + "";
                    break;
                case "*":
                    result *= double.Parse(txtPhepTinh.Text);
                    txtPhepTinh.Text = result + "";
                    break;
                case "/":
                    result /= double.Parse(txtPhepTinh.Text);
                    txtPhepTinh.Text = result + "";
                    break;
            }
            demPhepTinh = 0;
        }
    }
}
