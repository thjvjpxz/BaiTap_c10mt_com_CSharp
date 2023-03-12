using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = txtName.Text + "\n" + dtBirth.Value.ToString("dd/MM/yyyy")
                + "\n" + txtSoThich.Text;
            lblNoiDung.Text = message;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = 
                MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }
    }
}
