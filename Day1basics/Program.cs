namespace _04_02_XX_Exercicio_01
{
    class Program
    {
        static void Main(string[] args) //main is also a method but it is the entry point of the program
        {
            Console.Write("Enter name: ");
            string characterName = Console.ReadLine();           //yha pe hmlog characterName ko input kr skte h

            Console.Write("Enter age: ");
            int characterAge = Convert.ToInt32(Console.ReadLine());    //yha pe hmlog characterAge ko input kr skte h

         
            Tellstory(characterName, characterAge);
        }

        static void Tellstory(string characterName, int characterAge)
        {      //this part is method , evrything inside this {} is method body            
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge +" old");

            characterName = "Trump";   //yha pe hmlog kbhi bhi characterName ko change kr skte h 
            Console.WriteLine("He really liked the name " + characterName);

            characterAge = 62;   // yha pe hmlog kbhi bhi characterAge ko change kr skte h
            Console.WriteLine("But didn't like being " + characterAge );
            Console.WriteLine("He wished he was kid again but he was too old for that");
           

            
        }
    }
}