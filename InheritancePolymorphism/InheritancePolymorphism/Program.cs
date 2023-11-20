using System;
using System.Collections.Generic;
namespace UserNamespace
{
    public class User
    {
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            user_id = id;
            user_password = pass;
        }

        public bool verifyLogin(string id, string pass)
        {
            return user_id.Equals(id) && user_password.Equals(pass);
        }

        public virtual void updatePassword(string newPassword)//abstract class "virtual"
        {
            user_password = newPassword;
        }
    }

    public class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string pass) : base(id, pass)//communicates with the User constructor
        {
            admin_name = name;
        }

        public override void updatePassword(string newPassword)
        {
            user_password = newPassword;
        }

        public void updateAdminName(string name)
        {
            admin_name = name;
        }
    }

    class MainClass {
        public static void Main(string[] args) {
            LinkedList<string> UserID = new LinkedList<string>();
            LinkedList<string> Name = new LinkedList<string>();
            LinkedList<string> Password = new LinkedList<string>();
            UserID.AddLast("xenhusk");
            Name.AddLast("David");
            Password.AddLast("123");
            bool loginLoop = true;
            bool mainloop = true;
            bool menu = false;
            string currentRunTimeID = null;
            while (mainloop) { 
            while (loginLoop)
            {
                Console.WriteLine("<------------------------------------->");
                Console.WriteLine("Login Admin Account type log in");
                Console.WriteLine("If no account please type create user");
                Console.WriteLine("To exit program type end");

                Console.Write("Please type your option: ");
                string UserAdminOption = Console.ReadLine();

                switch (UserAdminOption.ToLowerInvariant())
                {
                    case "log in":
                        bool loginloop = true;
                        bool userExists,passwordExists;
                        string enteredUserID = null, enteredPassword = null;
                            Console.WriteLine("<------------------------------------->");
                           
                                Console.Write("Enter userID: ");
                                enteredUserID = Console.ReadLine();
                                Console.Write("Enter Password: ");
                                enteredPassword = Console.ReadLine();
                                userExists = UserID.Contains(enteredUserID);
                                if (userExists) { loginloop = false; } else { Console.WriteLine($"UserID {enteredUserID} does not exist"); }
                            
                            int verifyIndexID = FindIndex(UserID, enteredUserID);
                        passwordExists = Password.Contains(enteredPassword);
                        int verifyIndexPassword = FindIndex(Password, enteredPassword);
                            if (userExists)
                            {
                                string verifyIDandPass = (verifyIndexID == verifyIndexPassword) ? "Log in Successful!" : "UserID and Password does not match!";
                                Console.WriteLine(verifyIDandPass); loginLoop = false; currentRunTimeID = enteredUserID; menu = true;
                            }
                        break;

                    case "create user":
                            Console.WriteLine("<------------------------------------->");
                            string createUserID = null;
                        Console.Write("Enter Name: ");
                        string createName = Console.ReadLine();
                        Name.AddLast(createName);
                        bool userIDexists = true;
                        while (userIDexists)
                        {
                            Console.Write("Enter user ID: ");
                             createUserID = Console.ReadLine();
                            userIDexists = UserID.Contains(createUserID);
                            string userIDalr = (userIDexists) ? "UserID already exists/taken" : "User name is available";
                            Console.WriteLine(userIDalr);
                        }
                        UserID.AddLast(createUserID);
                        Console.Write("Enter password: ");
                        string createPassword = Console.ReadLine();
                        Password.AddLast(createPassword);
                        bool passwordLoop = true;
                        while (passwordLoop)
                        {
                            Console.Write("Enter password again: ");
                            string passwordAgain = Console.ReadLine();
                            passwordLoop = !(createPassword == passwordAgain);
                            string passwordMatch = (!passwordLoop) ? "Password matches" : "Password does not match";
                            Password.AddLast(createPassword);
                            Console.WriteLine(passwordMatch);
                        }
                        Console.WriteLine("Account Created Succesfully!");
                        break;
                        case "end":
                            loginLoop = false; mainloop = false; menu = false;
                            break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }
            while (menu) {
                    
            Console.WriteLine("<------------------------------------->");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Change Name : Change Password : Show Info : Log Out");
            Console.Write("Please type your option: ");
            string NamePasswordOption = Console.ReadLine();

                    switch (NamePasswordOption.ToLowerInvariant())
                    {
                        case "change name":
                            Console.Write("Change name to: ");
                            string changeNameto = Console.ReadLine();
                            int changeIndex = FindIndex(UserID, currentRunTimeID);
                            Console.WriteLine($"Name successfully changed from {Name.ToArray()[changeIndex]} to {changeNameto}");
                            ReplaceValueByIndex(Name,changeIndex, changeNameto);
                            break;

                        case "change password":
                            bool correctPass = false;
                            while (!correctPass)
                            {
                                Console.Write("Enter Old Password: ");
                                string oldPassword = Console.ReadLine();
                                int changePassIndex = FindIndex(UserID, currentRunTimeID);
                                correctPass = oldPassword == Password.ToArray()[changePassIndex];
                                if (correctPass)
                                {
                                    Console.Write("Enter New Password: ");
                                    string newPass = Console.ReadLine();
                                    ReplaceValueByIndex(Password, changePassIndex, newPass);
                                }
                                string result = (correctPass) ? "Password Successfully Changed" : "Incorrect Password";
                                Console.WriteLine(result);
                            }
                            break;
                        case "show info":
                            string userIDToShow = currentRunTimeID;
                            if (UserID.Contains(userIDToShow))
                            {
                                int userIndex = FindIndex(UserID, userIDToShow);
                                Console.WriteLine("User ID: " + userIDToShow);
                                Console.WriteLine("Name: " + Name.ToArray()[userIndex]);
                                Console.WriteLine("Password: " + Password.ToArray()[userIndex]);
                            }
                            else
                            {
                                Console.WriteLine("User ID not found.");
                            }
                            break;
                        case "log out":
                            menu = false; loginLoop = true;
                            currentRunTimeID = null;
                            Console.WriteLine("Logging Out");
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
            }
            Console.WriteLine("Program ended!");Console.ReadKey();
        }
        // method for finding index on a linked list
        static int FindIndex(LinkedList<string> list, string value)
        {
            int index = 0;
            foreach (var item in list)
            {
                if (item == value)
                {
                    return index;
                }
                index++;
            }
            return -1; // Element not found
        }
        // method for replacing value on a linked list using index
        static void ReplaceValueByIndex(LinkedList<string> list, int index, string newValue)
        {
            var node = list.First;
            for (int i = 0; i < index && node != null; i++)
            {
                node = node.Next;
            }
            if (node != null)
            {
                node.Value = newValue;
            }
        }
    }
}
