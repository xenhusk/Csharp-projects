using System;

public class ComputeAverageProgram
{
    public static void Main(String[] args) {
        Console.WriteLine("Enter 5 grades seperated by new line: ");
        double[] grades = new double[5];
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            grades[i] = Convert.ToDouble(Console.ReadLine());
            sum = sum + grades[i];
        }
        double average = sum / (int)5;
        Console.WriteLine($" The average is {average} and rounded off to {Math.Round(average)}");

        int a = 5;

        string result = a < 6 ? "true" :"false" ;

        Console.WriteLine(result);
        Console.ReadKey();
    }
}