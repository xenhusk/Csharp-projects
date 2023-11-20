using System;
public class BasketApp {
    public static void Main(String[] args) {
        Console.Write("Enter apple price: ");
        int apple = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter banana price: ");
        int banana = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter orange price: ");
        int orange = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("___________________________________");Console.WriteLine();
        double totalPrice = apple + banana + orange;

        int[]array1 = new int[8];
        array1[0] = 1;

        foreach (int array in array1) {
            Console.WriteLine(array+" / ");
        }
        
        string condition = totalPrice <= 150 ? $"You have a remaining balance of: {150 - totalPrice}" : "Oops You're running out of money";
        Console.WriteLine(condition);
        Console.ReadKey();
    }
    }   