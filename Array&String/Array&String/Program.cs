using System;
using System.Collections;

public class Program {
    public static void Main(string[]args) {
        //1.
        string[] names = { "James", "Mc", "Harvey", "Shanel", "Jeremiah", "Jefferson"};
        Console.WriteLine("My classmates are the ff: ");
        foreach (string classmates in  names) {
            Console.Write(classmates+" ");
        }
        Console.WriteLine();
        //2.
        char[,] alphabet = new char[2,3]
            {
        {'A', 'B', 'C' },
        {'D', 'E', 'F'}
        };
        Console.WriteLine("First 6 letter of the Alphabet: ");
        foreach (char alpha in alphabet) {
            Console.Write(alpha);
        }
        /*
        for (int i = 0; i<2; i++) {
            for (int ii=0; ii<3; ii++) {
                Console.Write(alphabet[i,ii]);
            }
            Console.WriteLine();
        }*/
        Console.WriteLine();
        //3.
        Console.WriteLine("Contains Hello: ");
        string hello_world = "Hello World";
        bool cointainingHello = hello_world.Contains("Hello");
        Console.Write(cointainingHello);
        Console.ReadKey();

    }
}