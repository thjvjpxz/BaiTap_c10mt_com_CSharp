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
    public partial class Form1 : Form
    {
        int so;
        int tongChan = 0, tongLe = 0, tong = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            DialogResult thongBao;
            do
            {
                thongBao = EnterNumber.NhapSo(ref a);
                if (thongBao == DialogResult.Cancel)
                    break;
                else if (!int.TryParse(a, out so))
                    MessageBox.Show("Nhập dữ liệu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    txtDanhSach.Text += so + " ";
                    tong += so;
                    tongChan += (so % 2 == 0 ? so : 0);
                    tongLe += (so % 2 != 0 ? so : 0);
                    txtTong.Text = tong + "";
                    txtTongChan.Text = tongChan + "";
                    txtTongLe.Text = tongLe + "";
                }

            } while (thongBao == DialogResult.OK && a != "");
            */

            hihihi frm2 = new hihihi();

            DialogResult thongbao;

            do 
            {
                thongbao = frm2.ShowDialog();
                
                if (thongbao == DialogResult.Cancel)
                    break;
                else if (!int.TryParse(frm2.GetText, out so))
                    MessageBox.Show("Nhập dữ liệu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    txtDanhSach.Text += so + " ";
                    tong += so;
                    tongChan += (so % 2 == 0 ? so : 0);
                    tongLe += (so % 2 != 0 ? so : 0);
                    txtTong.Text = tong + "";
                    txtTongChan.Text = tongChan + "";
                    txtTongLe.Text = tongLe + "";
                }
            } while (thongbao == DialogResult.OK && frm2.GetText != "");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*// Cách 1
            foreach (Control control in panel1.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Text = "";
            }
             */
            // Cách 2
            foreach (TextBox text in panel1.Controls.OfType<TextBox>())
                text.Text = "";
        }
    }
}
