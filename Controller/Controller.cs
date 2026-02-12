using Csharp_Fundament_Generics_Classes.Models;
using Csharp_Fundament_Generics_Classes.View;
using Spectre.Console;

namespace Csharp_Fundament_Generics_Classes.Controller;

public class ControllerClass(ToDoList toDo, ViewOutput output)
{
    private ToDoList modelInfo = toDo;
    private ViewOutput viewInfo = output;

    public void Run()
    {
        while (true)
        {
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Choose your operation")
                    .AddChoices(new[] { "ShowList", "Create", "Delete", "Done", "Exit" })
            );

            switch (choice)
            {
                case "ShowList":
                    viewInfo.DisplayList();
                    break;
                case "Create":
                    var title = AnsiConsole.Ask<string>("Name of the task");
                    modelInfo.Add(title);
                    break;
                case "Delete":
                    break;

                case "Done":
                    break;

                case "Exit":
                    return;
            }
        }
    }
}
