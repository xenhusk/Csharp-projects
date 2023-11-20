using System;
namespace MidtermNameSpace
{
    //Overloading
    public class OverloadConstructor
    {
        private string name, bday, address;
        private int age;
        public OverloadConstructor(string name, int age, string bday)
        {
            this.name = name;
            this.age = age;
            this.bday = bday;
            this.address = "No input for address";

        }

        public OverloadConstructor(string name, int age, string bday, string address)
        {
            this.name = name;
            this.age = age;
            this.bday = bday;
            this.address = address;
        }

        public void displayInfo()
        {
            Console.WriteLine($" Name: {name}\n Age: {age} \n Birthdate: {bday} \n Address: {address}");
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Birthdate: ");
            string bday = Console.ReadLine();

            Console.Write("Do you have an address? Y/N: ");
            string haveAddress = Console.ReadLine();
            switch (haveAddress.ToUpperInvariant())
            {
                case "Y":
                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine();
                    OverloadConstructor person1 = new OverloadConstructor(name, age, bday, address);
                    person1.displayInfo(); break;
                case "N":
                    OverloadConstructor person2 = new OverloadConstructor(name, age, bday);
                    person2.displayInfo();
                    break;
                default:
                    Console.WriteLine("Invalid Input"); break;
            }

            Console.Write("Enter Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Enter Model: ");
            string model = Console.ReadLine();
            Console.Write("Enter Color: ");
            string color = Console.ReadLine();
            Car car1 = new Car(brand, model, color);
            
            car1.displayCar();
            Override over = new Override();
            over.Methods();
            OverrideChild overChild = new OverrideChild();
            overChild.Methods();
            Console.ReadKey();
        }

    }

    //struct
    public struct Car
    {
        string brand, model, color;

        public Car(string brand, string model, string color)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
        }
        public void displayCar()
        {
            Console.WriteLine($"Brand: {brand}\nModel: {model}\nColor: {color}");
        }
    }

    //virtual and Override
    public class Override
    {
        public virtual void Methods()
        {
            Console.WriteLine("This is the Parent Class");
        }
    }
    public class OverrideChild : Override
    {
        public override void Methods()
        {
            Console.WriteLine("This is the Child Class that ovveridden a method that has been inherited from the Parent Class");
        }
    }
}
