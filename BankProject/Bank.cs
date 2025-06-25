using System;

class Bank
{
    static void Main()
    {
        Console.WriteLine("******** Harsha Bank ********");
        Console.WriteLine("::Login Page::");

        string userName = "";
        string password = "";

        Console.Write("Username: ");
        userName = Console.ReadLine();

        if (!string.IsNullOrEmpty(userName))
        {
            Console.Write("Password: ");
            password = Console.ReadLine();
        }

        if (userName == "system" && password == "admin")
        {
            int mainMenuChoice = -1;

            do
            {
                Console.WriteLine("::Main Page::");
                
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Funds Transfer");
                Console.WriteLine("4. Funds Transfer Statement");
                Console.WriteLine("5. Account Statement");
                Console.WriteLine("0. Exit");

                Console.Write("Enter choice:");

                mainMenuChoice = int.Parse(Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        CustomerMenu();
                        break;
                    case 2:
                        AccountsMenu();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }

            } while (mainMenuChoice != 0);
            
        }
        else
        {
            Console.WriteLine("Login failed.");
        }


        static void CustomerMenu()
        {
            int customerMenuChoice = -1;
            do
            {
                Console.WriteLine("\n::Customer Page::");

                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Delete Customer");
                Console.WriteLine("3. Update Customer");
                Console.WriteLine("4. Delete Customer");
                Console.WriteLine("5. View Customer");
                Console.WriteLine("0. Back to Main Menu");

                Console.Write("Enter choice:");

                customerMenuChoice = int.Parse(Console.ReadLine());

            } while (customerMenuChoice != 0);
            

        }

        static void AccountsMenu()
        {
            int accountMenuChoice = -1;
            do
            {
                Console.WriteLine("\n::Account Page::");

                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Delete Account");
                Console.WriteLine("3. Update Account");
                Console.WriteLine("4. Delete Account");
                Console.WriteLine("5. View Account");
                Console.WriteLine("0. Back to Main Menu");

                Console.Write("Enter choice:");

                accountMenuChoice = int.Parse(Console.ReadLine());

            } while (accountMenuChoice != 0);
        }
    }
}
