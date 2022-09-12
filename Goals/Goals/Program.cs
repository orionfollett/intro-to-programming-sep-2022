// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("View previous entries?");


Console.WriteLine("Enter your goal for today:");
Console.WriteLine("--------------------------");

string? goal = Console.ReadLine();

Console.WriteLine($"\n[For {DateTime.Today} Your Goal is:]");

if (goal != null)
{
    Console.WriteLine($"\n\"{goal}\"");
}
else {
    Console.WriteLine("\nYour goal is null!");
}

Console.Write("\n[Save Changes (Y/n)] ");   
string? resp = Console.ReadLine();

if (resp != null) {
    if (resp.Trim().ToLower().Equals("y"))
    {
        using StreamWriter file = new("WriteLines.txt", append: true);
        await file.WriteLineAsync(goal);
        Console.WriteLine("Saved");
    }
    else {
        Console.WriteLine("Not Saved");
    }
}