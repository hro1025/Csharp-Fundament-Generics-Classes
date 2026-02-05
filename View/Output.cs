using Csharp_Fundament_Generics_Classes.Controller;
using Csharp_Fundament_Generics_Classes.Models;
using Spectre.Console;

namespace Csharp_Fundament_Generics_Classes.View;

public class ViewOutput
{
    ControllerClass controllerClass = new ControllerClass();

    public void Run()
    {
        // Styled text with markup
        AnsiConsole.MarkupLine("[bold blue]Your To-Do-List[/]!");

        // A simple table
        var table = new Table().AddColumn("Id").AddColumn("Title").AddColumn("Done");
        foreach (var item in toDoList)
        {
            table.AddRow(item.Name, item.Age.ToString(), item.City);
        }

        AnsiConsole.Write(table);
        Console.ReadKey();
    }
}
