using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Bai1
    {
        private dynamic x = 10; // Đưa x ra thành biến thành viên

        public void Bai1a()
        {
            Console.WriteLine("x:" + x);
        }

        public void Bai1b()
        {
            getDetail(10);
            getDetail("game");
            getDetail(true);
            getDetail(9.5);
        }

        public void getDetail(dynamic value)
        {
            Console.WriteLine("value: " + value);
        }
        public void Bai1c()
        {
            UserData user = new UserData("2023", "Hi", 1);
            user.GetInfor();
        }
        public class UserData
        {
            public string id { get; set; }
            public string userName { get; set; }
            public int level { get; set; }

            public UserData(string id, string userName, int level)
            {
                this.id = id;
                this.userName = userName;
                this.level = level;
            }

            public void GetInfor()
            {
                Console.WriteLine("id: " + id);
                Console.WriteLine("userName: " + userName);
                Console.WriteLine("level: " + level);
            }
        }
    }
}
