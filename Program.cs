using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using Csharp_Fundament_Generics_Classes.Controller;
using Csharp_Fundament_Generics_Classes.Models;
using Csharp_Fundament_Generics_Classes.View;

namespace Csharp_Fundament_Generics_Classes;

class Program
{
    static void Main(string[] args)
    {
        ControllerClass controller = new ControllerClass(new ToDoList(), new ViewOutput());
        controller.Run();
    }
}
