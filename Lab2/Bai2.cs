using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab2
{
    internal class Bai2
    {
        public void bai2()
        {
            var data = new
            {
                id = "2023",
                userName = "Hi",
                isPLaying = false,
                bag = new
                {
                    skins = 10,
                    cups = 1
                }
            };

            Console.WriteLine("id: " + data.id);
            Console.WriteLine("userName: " + data.userName);
            Console.WriteLine("isPlaying: " + data.isPLaying);
            Console.WriteLine("skins: " + data.bag.skins);
            Console.WriteLine("cups: " + data.bag.cups);
        }

        public void Bai2b()
        {
            int y = 10;
            Action<int> AnonymousMethod = delegate (int x)
            {
                int sum = x + y;
                int sub = x - y;
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Sub: " + sub);
            }; AnonymousMethod(5);
        }
    }
};