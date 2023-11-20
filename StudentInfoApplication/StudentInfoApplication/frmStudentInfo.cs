using System;

public class frmStudentInfo {
    private string[] fname; private string[] lname; private string []id;
    private int noOfStudents, i;

    public void setInfo(string []fname, string []lname, string []id, int noOfStudents) {
        this.noOfStudents = noOfStudents;
        this.fname = new string[noOfStudents];
        this.lname = new string[noOfStudents];
        this.id = new string[noOfStudents];

        for (this.i = 0; i < noOfStudents; this.i++) {
            this.fname[this.i] = fname[this.i];
            this.lname[this.i] = lname[this.i];
            this.id[this.i] = id[this.i];
        }
    }

    public static void Main(string[] args) {
        Console.Write("Enter no. of students to add: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());
        string[] firstName = new string[numStudents];
        string[] lastName = new string[numStudents];
        string[] ID = new string[numStudents];
        frmStudentInfo Info = new frmStudentInfo();

        
        for (int i = 0; i < numStudents; i++) {
            Console.WriteLine($"Student no. {i+1}");
            Console.Write("Enter First Name: ");
            firstName[i] = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            lastName[i] = Console.ReadLine();
            Console.Write("Enter ID: ");
            ID[i] = Console.ReadLine();
            Info.setInfo(firstName, lastName, ID, numStudents);
            Console.WriteLine("_______________________________________________________________");
        }
        Info.displayInfo();
        Console.ReadKey();
    }

    public void displayInfo()
    {
        Console.WriteLine("_______________________________________________________________\n");
        Console.WriteLine("First Name\t\tLast Name\t\tID");
        Console.WriteLine("---------------------------------------------------------------");

        for (int i = 0; i < noOfStudents; i++)
        {
            if (lname[i].Length >= 9 && !lname[i].Contains(" ")) { Console.WriteLine($"{fname[i]}\t\t\t{lname[i]}\t\t{id[i]}"); }
            else if (fname[i].Length >= 9 && !fname[i].Contains(" ") && lname[i].Length >= 9 && !lname.Contains(" ")) { Console.WriteLine($"{fname[i]}\t\t{lname[i]}\t\t{id[i]}"); }
            else if (fname[i].Length >= 9 && !fname[i].Contains(" ")) { Console.WriteLine($"{fname[i]}\t\t{lname[i]}\t\t\t{id[i]}"); }
            else if (!fname[i].Contains(" ") && !lname[i].Contains(" ")) { Console.WriteLine($"{fname[i]}\t\t\t{lname[i]}\t\t\t{id[i]}"); }
            else if (fname[i].Contains(" ") && !lname[i].Contains(" ")) { Console.WriteLine($"{fname[i]}\t\t{lname[i]}\t\t\t{id[i]}"); }
            else if (!fname[i].Contains(" ") && lname[i].Contains(" ")) { Console.WriteLine($"{fname[i]}\t\t\t{lname[i]}\t\t{id[i]}"); }
            else if (fname[i].Contains(" ") && lname[i].Contains(" ")) { Console.WriteLine($"{fname[i]}\t\t{lname[i]}\t\t{id[i]}"); }
        }

    }
}