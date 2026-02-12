using System.Runtime.CompilerServices;
using Csharp_Fundament_Generics_Classes.Interfaces;

namespace Csharp_Fundament_Generics_Classes.Models;

public class ToDoList
{
    public List<IToDoInfo> Todos { get; } = [];
    private int id = 0;

    public void Add(string title)
    {
        Todos.Add(
            new IToDoInfo
            {
                Id = id++,
                Title = title,
                Done = false,
            }
        );
    }

    public IToDoInfo GetTask(string title = "default task")
    {
        var todo = new IToDoInfo
        {
            Id = id++,
            Title = title,
            Done = false,
        };

        return todo;
    }

    public void Remove(int id)
    {
        var todo = Todos.FirstOrDefault(t => t.Id == id);
        if (todo != null)
        {
            Todos.Remove(todo);
        }
    }

    public void Done(int id)
    {
        var todo = Todos.FirstOrDefault(t => t.Id == id);
        if (todo != null)
        {
            todo.Done = true;
        }
    }
}
