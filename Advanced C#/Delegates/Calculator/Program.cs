using System;
using System.Reflection.Metadata.Ecma335;
namespace Calculator;

public class Program
{
    delegate double DelegateOperation(double x, double y);//It will store the refernce of all methods have two same parameters
    delegate void DelegatePrint(string name);
    public static void Main(string[] args)
    {
        DelegateOperation opr;
        opr = Add;
        Console.WriteLine(opr(221.3, 56.3));
        opr = Subtract;
        Console.WriteLine(opr(221.3, 56.3));

        Console.WriteLine("--------Pass delgate as parameter --------");
        // now pass delegate as parameter
        Calaculate(43.5, 23.9, Multiply);
        Calaculate(43.5, 23.9, Divide);

        DelegatePrint print;

        print = Name;
        print += WhatsAppNotify;
        print += SmsNotify;
        print += EmailAppNotify;

        Console.WriteLine("--------Delegate invoke all operations in 1 call --------");

        print("Hanan");
    }
    static void Calaculate(double a, double b, DelegateOperation op)
    {
        Console.WriteLine($"{op(a, b):F2}");//upto 2 decimal after digit
    }
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => b != 0 ? a / b : double.NaN;

    static void Name(string name) => Console.WriteLine("Hanan Qaisar\n");
    static void SmsNotify(string name) => Console.WriteLine($"Sms Notification sent to {name}\n");
    static void WhatsAppNotify(string name) => Console.WriteLine($"Whatsapp Notification sent to {name}\nConfirm your WhatsApp OTP\n");
    static void EmailAppNotify(string name) => Console.WriteLine($"Email Notification sent to {name}\nWant to change Password?\n\tClick this url\n");
}