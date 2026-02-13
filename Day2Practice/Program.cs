using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

namespace _Day2Practice
{
    class Program
    {
        static void Main(string[] args)
        {  
             Console.Write("Enter text: ");

             string phrase = Console.ReadLine();
             char grade = 'A';
             int age = 30;
             double price = 19.99;
             bool isCodingFun = true;

                Console.WriteLine("Phrase: " + phrase);
                Console.WriteLine("Grade: " + grade);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Price: " + price);
                

             age = 31;
             Console.WriteLine("Hey but i need my age to be " + age);


             price = 6.78;
             Console.WriteLine ("and i want to purchase my life for " + price);
             Console.WriteLine(phrase .Contains("Academy"));
            
             Console.WriteLine(phrase .StartsWith("junkie"));
             Console.WriteLine(phrase .EndsWith("hub"));
             Console.WriteLine(phrase .ToUpper());
             Console.WriteLine(phrase .ToLower());    
             Console.WriteLine(phrase .Length);     
                Console.WriteLine(phrase [0]);
                Console.WriteLine(phrase [phrase.Length - 1]);
                Console.WriteLine(phrase .Replace("junkie", "coding"));
                Console.WriteLine(phrase [phrase.Length - 2]);

               if (phrase .Contains("hub"))
             {
                Console.WriteLine("Found it!");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
               

     
    }
    }
}