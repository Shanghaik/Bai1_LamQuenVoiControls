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
        Account account;
        // Tạo 1 tham số username để có thể lấy dữ thiệu từ form Login thông qua
        // việc tạo contructor có tham số là string username
        public HienThi(Account account) // Constructor
        {
            InitializeComponent();
            this.account = account; 
            tb_Address.Text = account.Address;
            tb_Name.Text = account.Name;
            tb_Phone.Text = account.Phone;
            if (account.GT) rb_Male.Checked = true;
            else rb_Female.Checked = true;
            ptb_Avatar.Image = Image.FromFile(account.ImgPath);
            dtp_DOB.Value = account.DOB;
        }
    }
}
