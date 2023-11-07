using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Bai1_LamQuenVoiControls
{
    public partial class DangKy : Form
    {
        string path = ""; // Biến này để lưu dường dẫn ảnh khi được chọn ở sự kiện click vào pictureBox
        public DangKy()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        { 
            bool check = true; // tạo 1 biến check để thực hiện validate dữ liệu
            // Validate dữ liệu
            foreach (Control item in this.Controls)
            {
                if (item is TextBox && item.Text == "") // Nếu control là textbox rỗng
                {
                    MessageBox.Show("Bạn hãy điền đủ thông tin");
                    check = false;
                    break;
                }
                else if (path == "") // Chưa có ảnh
                {

                    check = false;
                    item.BackColor = Color.LightPink;
                    MessageBox.Show("Bạn hãy Up ảnh nhé");
                }
            }
            DialogResult result = MessageBox.Show("Do You Want to Save Data?", "", MessageBoxButtons.YesNoCancel);
            if (check && result == DialogResult.Yes)
            {
                // Lấy data từ form để tạo ra đối tượng Account
                string Name = tb_Name.Text;
                string Address = tb_Address.Text;
                string Username = tb_Username.Text;
                string Password = tb_Password.Text;
                string Phone = tb_Phone.Text;
                bool GT = rb_Male.Checked; // Nếu radio Button male được check thì là true => Nam
                DateTime DOB = dtp_DOB.Value;
                string ImgPath = ptb_Avatar.ImageLocation;
                Account ac = new Account(Name, Address, Username, Password, Phone, GT, DOB, ImgPath);
                string accountFile = ac.CreateAccount(); // tạo ra chuỗi từ phương thức đã được viết để lưu
                File.AppendAllText("account.txt", accountFile);
                // Mỗi 1 thực thể controls (textbox, label,...) trên Form đều có thể được lấy ra
                // sử dụng foreach để duyệt qua tất cả các control trên form (this - chính là form đang chạy)
                // Sau đó kiểm tra điều kiện và làm điều mình thích vd như set text về rỗng như bên dưới
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox) { c.Text = ""; }
                }
            }

        }

        private void ptb_Avatar_Click(object sender, EventArgs e)
        {
            // Tạo 1 OpenFile Dialog để lấy file từ máy
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Please select an image file to encrypt."; // Set title - tiêu đề
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;..."; // tạo bộ lọc file
            openFileDialog.ShowDialog(); // Hiển thị Hộp thoại - Dialog
            ptb_Avatar.SizeMode = PictureBoxSizeMode.StretchImage; // Set Size mode để fit với khung hình
            ptb_Avatar.ImageLocation = openFileDialog.FileName; // Gán hình ảnh của pictureBox bằng file lấy được
            path = openFileDialog.FileName; // Gán đường dẫn cho biến path
        }
    }
}
