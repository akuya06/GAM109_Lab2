using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab2.Bai1;

namespace Lab2
{
    internal class UserData
    {
        public string id { get; set; }
        public string userName { get; set; }
        public List<float> Scores { get; set; }

        public UserData(string id, string userName, List<float> scores)
        {
            this.id = id;
            this.userName = userName;
            this.Scores = scores;
        }
        public void bai3()
        {
            List<float> Idata = new List<float> { 8.5f, 9.0f, 7.5f };
            UserData userData = new UserData("3333", "Hu", Idata);
            Console.WriteLine("id: " + userData.id);
            Console.WriteLine("userName: " + userData.userName);
            Console.WriteLine("Scores: " + string.Join(", ", userData.Scores));
        }
    }
}
