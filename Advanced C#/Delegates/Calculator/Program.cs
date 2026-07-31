using Extension.Calculate;

namespace Calculator;

public class Program
{
    delegate double DelegateOperation(double x, double y);
    delegate void DelegatePrint(string name);

    public static void Main(string[] args)
    {
        Console.WriteLine("======================================");
        Console.WriteLine("          C# Delegate Demo");
        Console.WriteLine("======================================\n");

        double a = 32.2;
        double b = 20.8;

        Break();
        // Delegate storing method references
        Console.WriteLine(">> Delegate → Method Reference\n");

        DelegateOperation opr;

        opr = Add;
        Console.WriteLine($"Addition       : {opr(a, b):F2}");

        opr = Subtract;
        Console.WriteLine($"Subtraction    : {opr(a, b):F2}");

        Break();
        // Delegate as parameter
        Console.WriteLine("\n>> Delegate → Passed as Parameter\n");

        Calculate(a, b, (a, b) => a * b);//Passes delagte as Lambda Expression
        Calculate(a, b, Divide);//here i passes Method as delegate

        // Extension method + Lambda
        Break();
        Console.WriteLine("\n>> Extension Method + Lambda\n");

        Console.WriteLine($"Addition       : {a.Calculator(b, (a, b) => a + b):F2}");//Passes Lambda Expressions as arguments
        Console.WriteLine($"Subtraction    : {a.Calculator(b, (a, b) => a - b):F2}");
        Console.WriteLine($"Multiplication : {a.Calculator(b, (a, b) => a * b):F2}");
        Console.WriteLine($"Division       : {a.Calculator(b, (a, b) => a / b):F2}");
        Console.WriteLine($"Modulus        : {a.Calculator(b, (a, b) => a % b):F2}");

        Break();
        // Multicast delegate
        Console.WriteLine("\n>> Multicast Delegate in Notification alert\n");

        DelegatePrint print = Name;

        print += WhatsAppNotify;
        print += SmsNotify;
        print += EmailAppNotify;

        print("Hanan");

        Console.WriteLine("\n======================================");
        Console.WriteLine("              Finished");
        Console.WriteLine("======================================");
    }

    static void Break()
    {
        Console.WriteLine("Press any button");
        Console.ReadKey();
    }
    static void Calculate(double a, double b, DelegateOperation opr)
    {
        Console.WriteLine($"Result         : {opr(a, b):F2}");
    }

    static double Add(double a, double b) => a + b;

    static double Subtract(double a, double b) => a - b;

    static double Divide(double a, double b) =>
        b != 0 ? a / b : double.NaN;

    static void Name(string name) =>
        Console.WriteLine($"Hello, {name}!\n");

    static void SmsNotify(string name) =>
        Console.WriteLine($"SMS        -> Notification sent to {name}");

    static void WhatsAppNotify(string name) =>
        Console.WriteLine($"WhatsApp   -> Notification sent to {name}\n             Confirm your WhatsApp OTP");

    static void EmailAppNotify(string name) =>
        Console.WriteLine($"Email      -> Notification sent to {name}\n             Password change link available");
}