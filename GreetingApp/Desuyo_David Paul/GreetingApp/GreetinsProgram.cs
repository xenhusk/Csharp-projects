using System;

class GreetingProgram {
    static void Main(string[] args) {

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the total number of your enrolled courses: ");
        int noCourse = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the price of your Book: ");
        double bookPrice = double.Parse(Console.ReadLine());
        Console.WriteLine("_____________________________");
        Console.WriteLine("");
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Total enrolled courses: "+noCourse);
        Console.WriteLine("Price of my favorite book: "+bookPrice);
        Console.ReadKey();
    }
}