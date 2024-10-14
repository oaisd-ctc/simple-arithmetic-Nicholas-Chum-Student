using System;
public class Program
{
    public static void Main(string[] args)
    {
    Console.WriteLine("Provide a number to perform an operation.");
    double num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Provide a second number to perform an operation.");
    double num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Provide an operation to perform the operation.");
    string oper = Console.ReadLine();

    if (oper.Contains("+"))
    {
        double num3 = num1 + num2;
        Console.WriteLine(num2 + ", alright! That's simple. " + num1 + " + " + num2 + " is " + num3 + ".");
    }
    else if (oper.Contains("-"))
    {
        double num3 = num1 - num2;
        Console.WriteLine(num2 + ", alright! That's simple. " + num1 + " - " + num2 + " is " + num3 + ".");
    }
    else if (oper.Contains("/"))
    {
        double num3 = num1 / num2;
        Console.WriteLine(num2 + ", alright! That's simple. " + num1 + " / " + num2 + " is " + num3 + ".");
    } 
    else if (oper.Contains("*"))
    {
        double num3 = num1 * num2;
        Console.WriteLine(num2 + ", alright! That's simple. " + num1 + " * " + num2 + " is " + num3 + ".");
    }
    else if (oper.Contains("%"))
    {
        double num3 = num1 % num2;
        Console.WriteLine(num2 + ", alright! That's simple. " + num1 + " % " + num2 + " is " + num3 + ".");
    }
    }
}