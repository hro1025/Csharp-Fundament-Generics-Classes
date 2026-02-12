using System.Runtime.CompilerServices;
using Csharp_Fundament_Generics_Classes.Controller;
using Csharp_Fundament_Generics_Classes.Interfaces;
using Csharp_Fundament_Generics_Classes.Models;
using Spectre.Console;

namespace Csharp_Fundament_Generics_Classes.View;

public class ViewOutput()
{
    ToDoList ToDo = new ToDoList();

    public void DisplayList(string title = "default", bool done = false)
    {
        AnsiConsole.MarkupLine("[bold blue]Your To-Do-List[/]!");
        var table = new Table().AddColumn("Id").AddColumn("Title").AddColumn("Done");

        foreach (var item in ToDo.Todos)
        {
            table.AddRow(item.Id.ToString(), item.Title = title, item.Done.ToString());
        }

        AnsiConsole.Write(table);
    }
}
