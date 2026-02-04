using Csharp_Fundament_Generics_Classes.Models;
using Csharp_Fundament_Generics_Classes.View;

namespace Csharp_Fundament_Generics_Classes;

class Program
{
    static void Main(string[] args)
    {
        ToDoListModel toDoListModel = new ToDoListModel();
        ViewOutput viewOutput = new ViewOutput();
        Controller controller = new Controller();

        Console.Write("Create new To-Do?: ");
        string? newToDO = Console.ReadLine();
    }
}
