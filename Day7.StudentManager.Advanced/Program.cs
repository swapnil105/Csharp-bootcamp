using Day7.StudentManager.Advanced.Services;
App.UseSwagger();
App.UseSwaggerUI();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
var service = new StudentService();

while (true)
{
    Console.Clear();
    Console.WriteLine("1 Add");
    Console.WriteLine("2 Show");
    Console.WriteLine("3 Delete");
    Console.WriteLine("4 Update");
    Console.WriteLine("5 Search");
    Console.WriteLine("6 Sort A-Z");
    Console.WriteLine("7 Sort Z-A");
    Console.WriteLine("8 Exit");

    var choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Name: ");
        service.Add(Console.ReadLine() ?? "");
    }
    else if (choice == "2")
    {
        foreach (var s in service.GetAll())
            Console.WriteLine($"{s.Id} {s.Name}");

        Console.ReadLine();
    }
    else if (choice == "3")
    {
        Console.Write("Id: ");
        service.Delete(int.Parse(Console.ReadLine() ?? "0"));
    }
    else if (choice == "4")
    {
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("New name: ");
        service.Update(id, Console.ReadLine() ?? "");
    }
    else if (choice == "5")
    {
        Console.Write("Search: ");
        var results = service.Search(Console.ReadLine() ?? "");

        foreach (var s in results)
            Console.WriteLine($"{s.Id} {s.Name}");

        Console.ReadLine();
    }
    else if (choice == "6")
    {
        service.SortByName();
    }
    else if (choice == "7")
    {
        service.SortByName(true);
    }
    else if (choice == "8")
        break;
}

var sucess = service.Add(Console.ReadLine() ?? "");

Console.WriteLine(sucess ? "Student added" : "Invalid name");
Console.ReadLine();