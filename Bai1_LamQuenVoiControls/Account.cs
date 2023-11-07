using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_LamQuenVoiControls
{
    internal class Account
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool GT { get; set; }
        public DateTime DOB { get; set; }
        public string ImgPath { get; set; }

        public Account(string name, string address, string username, string password, string phone, bool gT, DateTime dOB, string imgPath)
        {
            Name = name;
            Address = address;
            Username = username;
            Password = password;
            Phone = phone;
            GT = gT;
            DOB = dOB;
            ImgPath = imgPath;
        }

        public Account()
        {
        }
        public string CreateAccount() // Thực hiện tạo 1 dòng string chứa account để lưu vào file txt
        {
            return $"{Name}|{Address}|{Username}|{Password}|{Phone}|{GT}|{DOB}|{ImgPath}\n";
        }
        // C:\Users\Acer\source\repos\Bai1_LamQuenVoiControls\Bai1_LamQuenVoiControls\DangKy.cs
    }
}
