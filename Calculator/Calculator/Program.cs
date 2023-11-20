using System;

class Program
{
    static void Main()
    {
        double num1, num2;
        char operation;
        bool TF = true;

        Console.WriteLine("Simple Calculator in C#");
        Console.WriteLine("========================");
        do
        {
            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operation (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operation.");
                    return;
            }

            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            Console.ReadKey();
            Console.WriteLine("Continue? Y/N?");
            Console.Write("Option: ");
            char operation2 = Convert.ToChar(Console.ReadLine());

            switch (operation2)
            {

                case 'Y':
                    TF = true;
                    Console.WriteLine();
                    break;
                case 'y':
                    TF = true;
                    Console.WriteLine();
                    break;
                case 'N':
                    TF = false;
                    Console.Write("Program ended");
                    break;
                case 'n':
                    TF = false;
                    Console.Write("Program ended");
                    break;
            }
        } while (TF);
        
    }
}
