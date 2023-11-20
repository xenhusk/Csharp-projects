using System;
namespace UserNamespace
{
    public abstract class User
    {
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;
        }

        public bool verifyLogin(string id, string pass)
        {
            return user_id.Equals(id) && user_password.Equals(pass);
        }

        public bool verifyPassword(string pass)
        {
            return user_password.Equals(pass);
        }
        public abstract void updatePassword(string newPassword);


        public void displayID() {
            Console.WriteLine($"UserID: {user_id}");
            Console.WriteLine($"Password: {user_password}");

        }
    }

    public class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            this.admin_name = name;
        }

        public override void updatePassword(string newPassword)
        {
            this.user_password = newPassword;
        }

        public void updateAdminName(string name)
        {
            this.admin_name = name;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Name: {admin_name}");
            base.displayID();

        }
    }

    
    class mainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Create New User");
            Console.Write("Enter User Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter User ID: ");
            string userID = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            Administrator admin = new Administrator(name, userID, password);
            Console.WriteLine("Account created succesfully");
            Console.WriteLine("Log In or New user");
            Console.Write(" Enter Option: ");
            string optionMain = Console.ReadLine();
            if (optionMain.ToLowerInvariant() == "log in") { 
            Console.Write("Enter UserID: ");
            string loginID = Console.ReadLine();
            Console.Write("Enter Password: ");
            string loginPassword = Console.ReadLine();
            bool PassIDmatch = admin.verifyLogin(loginID, loginPassword);
            if (PassIDmatch)
            {
                Console.WriteLine("Log in successfully");
            }
            else
            {
                Console.WriteLine("Password / userID mismatch");
            }
                if (PassIDmatch)
                {
                    bool LogInMenu = true;
                    while (LogInMenu)
                    {
                        Console.WriteLine("Choose Option");
                        Console.WriteLine("Update Password : Update Name : Show Info");
                        Console.Write("Enter Option: ");
                        string option = Console.ReadLine();
                        switch (option.ToLowerInvariant())
                        {
                            case "update password":
                                Console.Write("Enter Old Password: ");
                                string oldPassword = Console.ReadLine();
                                if (admin.verifyPassword(oldPassword))
                                {
                                    Console.Write("Enter new password:  ");
                                    string newPassword = Console.ReadLine();
                                    admin.updatePassword(newPassword);
                                    Console.Write("Password updated successfully");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Password");
                                }
                                break;
                            case "update name":
                                Console.Write("Enter new Name: ");
                                string newName = Console.ReadLine();
                                Console.WriteLine($"Name changed to {newName}");
                                admin.updateAdminName(newName);
                                break;
                            case "show info":
                                admin.displayInfo();
                                break;
                            case "log out":
                                Console.WriteLine("Logged Out");
                                LogInMenu = false;
                                break;

                        }
                    }
                }

                
            }
            else if (optionMain.ToLowerInvariant() == "new user")
            {
                Console.WriteLine("Create New User");
                Console.Write("Enter User Name: ");
                string Newname = Console.ReadLine();
                Console.Write("Enter User ID: ");
                string NewuserID = Console.ReadLine();
                Console.Write("Enter Password: ");
                string Newpassword = Console.ReadLine();
                if (admin.verifyLogin(NewuserID, Newpassword))
                {
                    Console.WriteLine($"User {NewuserID} already exists");
                }
                else
                {
                    Administrator admin2 = new Administrator(Newname, NewuserID, Newpassword);
                    Console.WriteLine("New Account created succesfully!!");
                }
            }
            Console.ReadKey();
        }
    }
}