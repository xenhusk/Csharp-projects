using System;

public class DataTypesProgram
{
    public static void Main(String[] args) {
        Console.Write("Enter the piecees of apples: ");
        int pieces = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter total price of "+pieces+" apple(s): ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The total price of {pieces} apple(s) is {price}");
        Console.WriteLine($"The value of original price is {price}");
        Console.WriteLine($"The converted value of the price is {price = (int) price}");
        Console.ReadKey();

    }
}