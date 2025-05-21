using System;
using System.Collections.Generic;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var listIntNullable = new List<int?> { 1, 2, null, null, 5 };
            //foreach (var item in listIntNullable)
            //{
            //    Console.WriteLine(item);
            //}
            //Action<int> tinhGiaiThua = delegate (int n)
            //{
            //    int giaiThua = 1;
            //    for (int i = 1; i <= n; i++)
            //    {
            //        giaiThua *= i;
            //    }
            //    Console.WriteLine("Giai thua cua " + n + " la: " + giaiThua);
            //};

            
            //tinhGiaiThua(3);

            Console.WriteLine("Bai1");
            Bai1 bai1 = new Bai1();
            bai1.Bai1c();
            Console.WriteLine();

            Console.WriteLine("Bai2");
            Bai2 bai2 = new Bai2();
            bai2.bai2();
            bai2.Bai2b();
            Console.WriteLine();

            Console.WriteLine("Bai3");
            UserData bai3 = new UserData("1", "DefaultUser", new List<float> { 90.5f, 85.0f, 78.0f });
            bai3.bai3();
        }
    }
}
