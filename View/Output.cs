using Spectre.Console;

namespace Csharp_Fundament_Generics_Classes.View;

public class ViewOutput
{
    public void Run()
    {
        // Styled text with markup
        AnsiConsole.MarkupLine("[bold blue]Your To-Do-List[/]!");

        // A simple table
        var table = new Table()
            .AddColumn("Id")
            .AddColumn("Title")
            .AddColumn("Done")
            .AddRow("[green]Markup[/]", "Rich text with colors and styles")
            .AddRow("[blue]Tables[/]", "Structured data display")
            .AddRow("[yellow]Progress[/]", "Spinners and progress bars");
        AnsiConsole.Write(table);
        Console.ReadKey();
    }
}
