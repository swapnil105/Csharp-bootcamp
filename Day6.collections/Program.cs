using System;
using System.Collections.Generic;
using System.Linq;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        int idCounter = 1;

        void ReassignIds()
        {
            for (int i = 0; i < students.Count; i++)
            {
                students[i].Id = i + 1;
            }
            idCounter = students.Count + 1;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1 Add");
            Console.WriteLine("2 Show");
            Console.WriteLine("3 Delete");
            Console.WriteLine("4 Exit");

            var choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter name: ");
                var name = Console.ReadLine();

                students.Add(new Student
                {
                    Id = idCounter++,
                    Name = name
                });
            }
            else if (choice == "2")
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"{student.Id} {student.Name}");
                }

                Console.ReadLine();
            }
            else if (choice == "3")
            {
                Console.Write("Enter student ID to delete: ");
                int id = int.Parse(Console.ReadLine());

                var studentToRemove = students.FirstOrDefault(s => s.Id == id);

                if (studentToRemove != null)
                {
                    students.Remove(studentToRemove);
                    ReassignIds();
                    Console.WriteLine("Student removed.");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
                
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }

                else if (choice == "4")
                {
                    Console.WriteLine("Exiting...");
                    break;  //breaks while loop
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    Console.ReadLine();
                }
            }
        }
    }
