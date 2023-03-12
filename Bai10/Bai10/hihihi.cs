using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class hihihi : Form
    {
        public string GetText { get; set; }
        public hihihi()
        {
            InitializeComponent();
        }

        private void hihihi_Load(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetText = textBox1.Text;
            textBox1.Text = "";
            textBox1.Focus();
        }


    }
}
