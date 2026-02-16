using System.Runtime.CompilerServices;
using Csharp_Fundament_Generics_Classes.Controller;
using Csharp_Fundament_Generics_Classes.Interfaces;
using Csharp_Fundament_Generics_Classes.Models;
using Spectre.Console;

namespace Csharp_Fundament_Generics_Classes.View;

public class ViewOutput(ToDoList toDo)
{
    ToDoList ToDo = toDo;

    public void DisplayList()
    {
        AnsiConsole.MarkupLine("[bold blue]Your To-Do-List[/]!");
        var table = new Table().AddColumn("Id").AddColumn("Title").AddColumn("Done");

        foreach (var item in ToDo.Todos)
        {
            table.AddRow(item.Id.ToString(), item.Title, item.Done.ToString());
        }

        AnsiConsole.Write(table);
    }
}
