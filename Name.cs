
using System.Text.RegularExpressions;

namespace HelloWorld.add.name;

public class Name
{
    public void ViewNameMessage()
    {
        Console.Write("Informe o nome:");
        var name = Console.ReadLine();

        Console.WriteLine($"Olá,{name}! Seja muito bem-vindo!");


    }

    public void ConcatFullname()
    {
        Console.Write("Informe o nome:");
        string name = Console.ReadLine()!;

        Console.Write("Informe o sobrnome:");
        string lastName = Console.ReadLine()!;


        Console.WriteLine($"Nome completo:{name.Trim()} {lastName.Trim()}");


    }

}
