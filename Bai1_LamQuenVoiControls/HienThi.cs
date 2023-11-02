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
    public partial class HienThi : Form
    {
        string username;
        // Tạo 1 tham số username để có thể lấy dữ thiệu từ form Login thông qua
        // việc tạo contructor có tham số là string username
        public HienThi(string username) // Constructor
        {
            InitializeComponent();
            this.username = username;
            string vanmau = $"Người anh em {username} học bách khoa cơ khí, sinh năm 96. Tự mày mò học code rồi đi làm remote cho công ty Mỹ 2 năm nay. Mỗi tối online 3-4 giờ là xong việc. Lương tháng 3k6. Nhưng thu nhập chính vẫn là từ nhận các project bên ngoài làm thêm. Tuần làm 2,3 cái nhẹ nhàng 9,10k tiền tươi thóc thật không phải đóng thuế. Làm gần được 3 năm mà nhà xe nó đã mua đủ cả. Nghĩ mà thèm.\r\n\r\nGái gú thì cứ nghe nó bảo làm CNTT thì chảy nước. Có bé kia dân du học sinh Úc, về được cô chị giới thiệu làm ngân hàng VCB. Thế nào thằng ấy đi mở thẻ tín dụng gặp phải thế là hốt được cả chị lẫn em. 3 đứa nó sống chung một căn hộ cao cấp. Nhà con bé kia biết chuyện ban đầu phản đối sau biết thằng đấy học IT thì đổi thái độ, cách ba bữa hỏi thăm, năm bữa tặng quà lấy long, luôn giục cưới kẻo lỡ kèo ngon.";
            textBox1.Text = vanmau;
            textBox1.Font = new Font("Arial", 14);
        }
    }
}
