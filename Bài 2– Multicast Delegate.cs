
using System;

delegate void XuLyKetQua(string ten, double diem);

class Program
{
  
    static void InKetQua(string ten, double diem)
    {
        Console.WriteLine("Ten: " + ten + ", Diem: " + diem);
    }

   
    static void CanhBao(string ten, double diem)
    {
        if (diem < 5)
            Console.WriteLine("Can cai thien");
        else
            Console.WriteLine("Dat");
    }

    static void Main()
    {
      
        XuLyKetQua xl = InKetQua;
        xl += CanhBao;

        Console.WriteLine("Lan 1:");
        xl("Tỉnh", 4.5);

        xl -= CanhBao;

        Console.WriteLine("Lan 2:");
        xl("Tỉnh", 4.5);
    }
}
