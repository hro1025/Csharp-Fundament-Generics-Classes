using System.ComponentModel;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Csharp_Fundament_Generics_Classes.Interfaces;
using Csharp_Fundament_Generics_Classes.Models;
using Csharp_Fundament_Generics_Classes.View;

namespace Csharp_Fundament_Generics_Classes.Controller;

public class ControllerClass
{
    ViewOutput view = new ViewOutput();

    public void Controller()
    {
        view.Run();
    }
}
