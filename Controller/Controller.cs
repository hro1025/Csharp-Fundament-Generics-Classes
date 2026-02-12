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
                    .AddChoices(new[] { "Create", "Delete", "Done", "Exit" })
            );

            switch (choice)
            {
                case "Create":

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
