public class Program
{
    public delegate void PrintDelegate(object message);

    public static void Calculate(int a, int b, PrintDelegate printer)
    {
        int result = a + b;
        printer(result);
    }

    public static void Main(string[] args)
    {
        //Pass Print Method
        Calculate(10, 5, Print);
        
        //Pass Print2 Method
        Calculate(2, 3, Print2);
    }

    public static void Print(object message)
    {
        Console.WriteLine(message);
    }

    public static void Print2(object message)
    {
        Console.WriteLine("---" + message + "---");
    }
}
