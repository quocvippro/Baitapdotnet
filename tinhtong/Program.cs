using System;


class Program
{
    static void Main(string[] args)
    {

        int tong = 0;
        int so = 0;
        int b = 0;
        Console.Write("Nhap n : ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            b = i;
            String nn = b.ToString() + b.ToString();
            so = Convert.ToInt32(nn);
            tong += so;

        }
        Console.WriteLine("Tong la: " + tong);
    }
}