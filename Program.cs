using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        // 
        // a = 5; b = 7 -> max = 7
        // a = 2 b = 10 -> max = 10
        // a = -9 b = -3 -> max = -3
        double x;
        double y;
        
        Console.WriteLine("Введите x=");
        x = inputValue();
        Console.WriteLine("Введите y = ");
        y = inputValue();
        if (y > x)
        {
            Console.WriteLine(y);
        }
        else
        {
            Console.WriteLine(x);
        }
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
