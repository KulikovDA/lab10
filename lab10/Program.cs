public class MyClass
{
    public int a;
    public int b;
    public int c;
    public int d;
    public MyClass()
    {
        Console.WriteLine("Введите значение для a:");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для b:");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для c:");
        c = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для d:");
        d = int.Parse(Console.ReadLine());
    }
    public MyClass(int aValue, int bValue, int cValue, int dValue)
    {
        a = aValue;
        b = bValue;
        c = cValue;
        d = dValue;
    }
    public double CalculateAverage()
    {
        return (a + b + c + d) / 4.0;
    }
    public int FindMaxNumber()
    {
        return Math.Max(Math.Max(a, b), Math.Max(c, d));
    }

    public string GetInfoString()
    {
        return $"a: {a}, b: {b}, c: {c}, d: {d}";
    }
}
class MySubclass : MyClass
{
    private int e;
    private int x;
    public MySubclass()
    {
        Console.WriteLine("Введите значение для e:");
        e = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение для x:");
        x = int.Parse(Console.ReadLine());
    }
    public MySubclass(int aValue, int bValue, int cValue, int dValue, int eValue, int xValue)
    : base(aValue, bValue, cValue, dValue)
    {
        e = eValue;
        x = xValue;
    }
    public int CalculateSumOfSquares()
    {
        int kv1 = a - x;
        int kv2 = b - x;
        int kv3 = c - x;
        int kv4 = d - x;

        int sumOfSquares = kv1 * kv1 + kv2 * kv2 + kv3 * kv3 + kv4 * kv4;

        return sumOfSquares;
    }
    public new string GetInfoString()
    {
        return base.GetInfoString() + $", e: {e}, x: {x}";
    }
}