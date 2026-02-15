using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        bool hasDigit = false;
        bool hasUpper = false;
        bool hasSpecial = false;



        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                hasDigit = true;
            }
            if (char.IsUpper(c))
            {
                hasUpper = true;
            }
                if (!char.IsLetterOrDigit(c))
                {hasSpecial = true;
                }

        }
        if (password.Length >= 8 && hasDigit && hasUpper && hasSpecial)
        {
            Console.WriteLine("Strong password");
        }
        else
        {
            Console.WriteLine("Passwword requirements not met");

            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long");
            }

            if (!hasDigit)
            {
                Console.WriteLine("Password must contain at least one digit");
            }
              
            if (!hasUpper)
            {
                Console.WriteLine("Password must contain at least one uppercase letter");
            }


            if (!hasSpecial)
                {
                    Console.WriteLine("Password must contain at least one special character");
                }
        }

    }
}
