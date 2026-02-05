using Csharp_Fundament_Generics_Classes.Interfaces;

namespace Csharp_Fundament_Generics_Classes.Models;

public class ToDoList
{
    public List<IToDoInfo> Todos { get; } = new();
    private int _id = 0;

    public void Add(string title)
    {
        Todos.Add(
            new IToDoInfo
            {
                Id = _id++,
                Title = title,
                Done = false,
            }
        );
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
