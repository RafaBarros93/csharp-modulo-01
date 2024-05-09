
using System.Text.RegularExpressions;

namespace HelloWorld.plates_car;

public class Plates
{
    public void ValidBrazilianCarPlate()
    {
        Console.Write("Informe a placa do Carro:");
        var caracteres = Console.ReadLine()!;

        bool isValidPlate = Regex.IsMatch(caracteres, "[A-z]{3}-\\d[A-j0-9]\\d{2}");

        if (!isValidPlate)
        {
            Console.WriteLine("Não é uma placa válida.");
        }
        else
        {
          
            Console.WriteLine($"O é uma placa válida {caracteres}");
        }

       

    }

    public void ValidCaracteres() {
        Console.Write("Informe a palavra:");

        var word = Console.ReadLine()!;


        var trimWord = word.Replace(" ","");


        int numberOfLetters = trimWord.ToCharArray().Length;

        Console.WriteLine($"A palavra possui {numberOfLetters} caracteres.");



    }
}
