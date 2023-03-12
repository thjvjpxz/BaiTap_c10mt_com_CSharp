using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai1
{
    public partial class Form1 : Form
    {
        string strConn = "Data Source=DESKTOP-BED894K;Initial Catalog=Account;Integrated Security=True";
        SqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
        }

        private void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        private void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private bool CheckLogin(Account acc)
        {
            OpenConnection();

            string query = "select TaiKhoan, MatKhau from tbl_taikhoan where TaiKhoan = @user";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user", acc.TaiKhoan);
            SqlDataReader reader = cmd.ExecuteReader();
            bool check = false;
            if (reader.HasRows && reader.Read() && reader.GetString(1) == acc.MatKhau)
                check = true;
            reader.Close();

            CloseConnection();
            return check;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn thoát ?";
            string title = "Chú ý";
            DialogResult thongbao = (MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = "Chú ý";
            if (txtUser.Text == "")
                MessageBox.Show("Vui lòng nhập tài khoản !", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtPass.Text == "")
                MessageBox.Show("Vui lòng nhập mật khẩu !", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (CheckLogin(new Account(txtUser.Text, txtPass.Text)))
                MessageBox.Show("Đăng nhập thành công !");
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !");

        }
    }
}
