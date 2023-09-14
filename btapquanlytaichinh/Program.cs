using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Tai Khoan Ca Nhan");
        Console.Write("Moi ban nhap ten :");
        String ten = Console.ReadLine();
        Console.Write("Nhap so tien trong tai khoan:");
        int tien = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Moi ban nhap cac giao dich trong thang :");
        int n = 1;
        int tientt = 0;
        while(tien > 0)
        {
            Console.Write("Giao dich " + n +":");
            int tgd = Convert.ToInt32(Console.ReadLine());
            tientt += tgd;
            n++;
            if(tgd == -1) {
                break;
                    }
        }
        tien = tien - tientt-1;
        Console.WriteLine("So tien con lai cua " + ten + " la :");
        Console.WriteLine("So tien con lai:" + tien);

    }
}
