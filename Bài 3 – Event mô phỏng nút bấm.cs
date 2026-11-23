
using System;


delegate void XuLyBam(string tenNut);

class NutBam
{

    public event XuLyBam DaBam;

    public string TenNut { get; set; }

  
    public NutBam(string tenNut)
    {
        TenNut = tenNut;
    }

    public void Bam()
    {
        Console.WriteLine("Da bam: " + TenNut);

      
        DaBam?.Invoke(TenNut);
    }
}

class Program
{
    static void GhiNhatKy(string tenNut)
    {
        Console.WriteLine("Ghi nhat ky nut: " + tenNut);
    }

    static void HienThiThongBao(string tenNut)
    {
        Console.WriteLine("Thong bao: Ban da bam nut " + tenNut);
    }

    static void Main()
    {
        NutBam nut = new NutBam("Luu");

       
        nut.DaBam += GhiNhatKy;
        nut.DaBam += HienThiThongBao;

    
        nut.Bam();
    }
}
