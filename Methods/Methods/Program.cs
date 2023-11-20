using System;
public struct Student {

    private string name;
    private int age;
    private string birthday;
    private string course;

    public void setInfo(string name, int age, string birthday, string course) {
        this.name = name;
        this.age = age;
        this.birthday = birthday;
        this.course = course;
    }

    public void DisplayInfo() {
        Console.WriteLine($"Name: {this.name}");
        Console.WriteLine($"Age: {this.age}");
        Console.WriteLine($"Birthday: {this.birthday}");
        Console.WriteLine($"Course: {this.course}");
    }


}
public class StendInfo
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your birthday: ");
        string bday = Console.ReadLine();
        Console.WriteLine("Enter your Course: ");
        string course = Console.ReadLine();
        Student stud = new Student();
        stud.setInfo(name, age, bday, course);
        Console.WriteLine("______________________________________");
        stud.DisplayInfo();
        Console.ReadKey();
    }
}