using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_LamQuenVoiControls
{
    internal static class Services
    {
        // 1. Lấy các account từ trong file ra, phương thức này trả về 1 List Account
        public static List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>(); // Khởi tạo List để chứa
            // Lấy data từ file account.txt đã được tạo ra 1 mảng string, mỗi dòng là 1 account
            string[] datas = File.ReadAllLines("account.txt");
            foreach (string data in datas) // Xử lý cho mỗi dòng lấy được thành 1 account
            {
                if (!string.IsNullOrEmpty(data)) // Nếu chuỗi không rỗng
                { // Cắt chuỗi ra thành từng thuộc tính riêng biệt
                    string[] thuoctinhs = data.Split('|'); // Cắt theo gạch |
                    // Tạo đối tượng từ các thuộc tính và thu được
                    // string name, string address, string username, string password, string phone, bool gT, DateTime dOB, string imgPath
                    string name = thuoctinhs[0];
                    string address = thuoctinhs[1];
                    string username = thuoctinhs[2];
                    string password = thuoctinhs[3];
                    string phone = thuoctinhs[4];
                    bool gt = thuoctinhs[5] == "True";
                    DateTime dob = Convert.ToDateTime(thuoctinhs[6]);
                    string imgPath = thuoctinhs[7];
                    Account account = new Account(name, address, username, password, phone, gt, dob, imgPath);
                    accounts.Add(account); // thâm account vừa lấy được vào list để trả về
                }
            }
            return accounts; // Trả về danh sách
        }
        // 2. Kiểm tra account nhập vào từ form đăng nhập có nằm trong danh sách account ko
        // khi mà account được xác nhận là có tồn tại thì ta trả về 1 đối tượng account
        public static Account CheckLogin(string TK, string MK)
        {
            var allAccounts = GetAllAccounts(); // Lấy danh sách account từ file txt
            var check = allAccounts.FirstOrDefault(p => p.Username == TK && p.Password == MK);
            // LinQ vs Lambda expression
            var check2 = from account in allAccounts 
                         where account.Username == TK && account.Password == MK
                         select account; // Thuần LinQ -- Mở rộng
            return check;    // trả về check, nếu check không được tìm thấy thì bản chất nó vẫn là null
        }
        // 3. Kiểm tra xem account có bị trùng hay không khi thêm mới (Đăng ký)
    }
}
