using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Nhập số nguyên dương n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.WriteLine("Các số nguyên tố trong khoảng từ 1 đến {0} là:", n);
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ.");
        }
    }
}