using System;


class Program 
{
    static void Main()
    {
        bool running = true;

        while (running)
        
        {
            Console.Clear();
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Validate Email");
            Console.WriteLine("2. Validate Password");
            Console.WriteLine("3. Exit");

            Console.Write("Choose option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                ValidateEmail();
            }
            else if (choice == "2")
            {
                ValidatePassword();
            }
            else if (choice == "3")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
                                                                                  //outside main method but still inside class
          static void ValidateEmail()
           {
        Console.Write("Enter email: ");
        string email = Console.ReadLine();

        if (email.Contains("@") && email.Contains("."))
        {             Console.WriteLine("Valid email");
        }
        else
        {
            Console.WriteLine("Invalid email address");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }


                                                       //outside main method but still inside class
             static void ValidatePassword()
    {
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        bool hasDigit = false;
        bool hasUpper = false;
        bool hasSpecial = false;

        foreach (char c in password)
        {
            if (char.IsDigit(c)) hasDigit = true;
            if (char.IsUpper(c)) hasUpper = true;
            if (!char.IsLetterOrDigit(c)) hasSpecial = true;
        }

        if (password.Length >= 8 && hasDigit && hasUpper && hasSpecial)
            Console.WriteLine("Strong password");
        else
            Console.WriteLine("Weak password");

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}
