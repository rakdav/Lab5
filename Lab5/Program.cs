using Lab5;
double a, b, c, x;
try
{
    Console.Write("Введите a:");
    a = double.Parse(Console.ReadLine());
    Console.Write("Введите b:");
    b = double.Parse(Console.ReadLine());
    Console.Write("Введите c:");
    c = double.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    x = double.Parse(Console.ReadLine());
    Console.WriteLine($"y={FuncWithout(x, a, b, c):F2}");
    try
    {
        double y = FuncWith(x, a, b, c);
        Console.WriteLine($"y={y:F2}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    try
    {
        FuncExept(x, a, b, c);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    try
    {
        double y = FuncOur(x, a, b, c);
        Console.WriteLine($"y={y:F2}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}

double FuncWithout(double x,double a,double b,double c)
{
    return (a*x*x+b)/(c*x);
}

double FuncWith(double x, double a, double b, double c)
{
    if (c != 0 && x != 0)
        return (a * x * x + b) / (c * x);
    throw new Exception("Деление на ноль запрещено");
}

void FuncExept(double x, double a, double b, double c)
{
    double y=0;
    try
    {
        y=(a * x * x + b) / (c * x);
        Console.WriteLine($"y={y:F2}");
    }
    catch(ArithmeticException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

double FuncOur(double x, double a, double b, double c)
{
    if (c != 0 && x != 0)
        return (a * x * x + b) / (c * x);
    throw new OurException("Деление на ноль запрещено");
}