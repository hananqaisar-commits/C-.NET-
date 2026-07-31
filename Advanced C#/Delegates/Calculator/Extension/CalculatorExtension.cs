namespace Extension.Calculate;

public static class CalculatorExtension
{
    public static double Calculator(this double a, double b, Func<double, double, double> operation) => operation(a, b);
}