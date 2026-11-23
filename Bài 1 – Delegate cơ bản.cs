
using System;

delegate void ThongBao(string msg);

class Program
{
    static void GuiEmail(string msg)
    {
        Console.WriteLine("Email: " + msg);
    }

    static void GuiSMS(string msg)
    {
        Console.WriteLine("SMS: " + msg);
    }

    static void Main()
    {
       
        ThongBao tb = GuiEmail;
        tb("Dang ky thanh cong");

        tb = GuiSMS;
        tb("Dang ky thanh cong");
    }
}
