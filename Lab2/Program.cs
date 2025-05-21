using System;
using System.Collections.Generic;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listIntNullable = new List<int?> { 1, 2, null, null, 5 };
            foreach (var item in listIntNullable)
            {
                Console.WriteLine(item);
            }
            Action<int> tinhGiaiThua = delegate (int n)
            {
                int giaiThua = 1;
                for (int i = 1; i <= n; i++)
                {
                    giaiThua *= i;
                }
                Console.WriteLine("Giai thua cua " + n + " la: " + giaiThua);
            };

            int a;
            Console.WriteLine("Nhap so nguyen duong n: ");
            a = int.Parse(Console.ReadLine());
            tinhGiaiThua(a);

            Console.WriteLine("Bai1");
            Bai1 bai1Instance = new Bai1();
            bai1Instance.Bai1c();

            Console.WriteLine("Bai2");
            Bai2 bai2Instance = new Bai2();
            bai2Instance.bai2();
            bai2Instance.Bai2b();

            Console.WriteLine("Bai3");
            UserData bai3Instance = new UserData("1", "DefaultUser", new List<float> { 90.5f, 85.0f, 78.0f });
            bai3Instance.bai3();
        }
    }
}
