using System.Runtime.CompilerServices;
using Csharp_Fundament_Generics_Classes.Interfaces;

namespace Csharp_Fundament_Generics_Classes.Models;

public class ToDoList
{
    public readonly List<IToDoInfo> todos = new();
    private int Id = 0;

    public void Add()
    {
        var title = Console.ReadLine();

        todos.Add(
            new IToDoInfo
            {
                Id = Id++,
                Title = title ?? string.Empty,
                Done = false,
            }
        );
    }

    public void Remove()
    {
        var input = Console.ReadLine();

        if (int.TryParse(input, out int id))
        {
            var todo = todos.FirstOrDefault(t => t.Id == id);

            if (todo != null)
            {
                todos.Remove(todo);
            }
        }
    }

    public void Update()
    {
        var input = Console.ReadLine();

        if (int.TryParse(input, out int id))
        {
            var update = todos.FirstOrDefault(t => t.Id == id);

            if (update != null)
            {
                todos.Remove(update);

                var title = Console.ReadLine();

                todos.Add(
                    new IToDoInfo
                    {
                        Id = Id++,
                        Title = title ?? string.Empty,
                        Done = false,
                    }
                );
            }
        }
    }
}
