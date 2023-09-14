using System;

class Program
{
    static int Solont2(int[] arr)
    {
        if (arr.Length < 2)
        {
            Console.WriteLine("Mang phai lon hon 2 phan tu");
            return -1;
        }

        int solonnhat = arr[0];
        int solonthu2 = arr[0];

        foreach (int num in arr)
        {
            if (num > solonnhat)
            {
                solonthu2 = solonnhat;
                solonnhat = num;
            }
            else if (num > solonthu2 && num != solonnhat)
            {
                solonthu2 = num;
            }
        }

        if (solonthu2 == solonnhat)
        {
            Console.WriteLine("Khong tim thay");
            return -1;
        }

        return solonthu2;
    }

    static void Main()
    {
        Console.Write("Nhap So Luong Phan Tu mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write(" Nhap phan tu thu" + i + " :");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int result = Solont2(arr);

        if (result != -1)
        {

            Console.WriteLine("Phan tu lon thu 2: " + result);
        }
    }
}