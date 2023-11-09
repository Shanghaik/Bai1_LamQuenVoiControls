using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_LamQuenVoiControls
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tbt_Username_MouseHover(object sender, EventArgs e)
        {
            tbt_Username.BackColor = Color.LightBlue;
        }

        private void tbt_Username_MouseLeave(object sender, EventArgs e)
        {
            tbt_Username.BackColor = Color.White;
        }
        // Sự kiện bên dưới là TextChange Nhưng đã được đổi tên
        private void NhapUsername_Event(object sender, EventArgs e)
        {
            if (tbt_Username.Text.Length < 8)
            {
                tbt_Username.ForeColor = Color.Red;
            }
            else
            {
                tbt_Username.ForeColor = Color.Black;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Điều kiện để đăng nhập
            // Username có độ dài > 8
            // Password chứa Chữ in hoa
            // Check vào checkBox tôi là người máy
            // => Hiển thị ra Message đăng nhập thành công
            string username = tbt_Username.Text; string password = tbt_Password.Text;
            Account account = Services.CheckLogin(username, password);
            if (username.Length > 8 && password.ToLower() != password 
                && account != null && cb_Robot.Checked)
            {
                MessageBox.Show("Đặng nhập thành công");
                // Khi đăng nhập thành công ta khởi tạo 1 Đối tượng là Form hiển thị
                // với tham số username được lấy từ TextBox Username vừa nhập
                HienThi hienthi = new HienThi(account);
                hienthi.ShowDialog();
            }
            else MessageBox.Show("Đặng nhập thất bại, hãy kiểm tra lại");
        }

        private void cb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowPass.Checked)
            {
                tbt_Password.PasswordChar = '\0';
            }
            else tbt_Password.PasswordChar = '*';
        }
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }
    }
}
