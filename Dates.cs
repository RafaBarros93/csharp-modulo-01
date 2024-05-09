
using System.Globalization;

namespace HelloWorld.dates;

public class Dates

{
    public void OptionsDate()
    {
        Console.WriteLine("Escolha uma opção");
        Console.WriteLine("1-Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
        Console.WriteLine("2-Apenas a data no formato \"01/03/2024\".");
        Console.WriteLine("3-Apenas a hora no formato de 24 horas.");
        Console.WriteLine("4-A data com o mês por extenso.");
        Console.WriteLine("0-Sair");
        Thread.Sleep(1000);

        Console.Write("\nOpção:");
        string options = Console.ReadLine()!;


        switch (options)
        {
            case "1":   
                Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("pt-br")));
                break;

            case "2":
                Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
                break;

            case "3":
                Console.WriteLine(DateTime.Now.ToString("HH:mm"));
                break;


            case "4":
                Console.WriteLine(DateTime.Now.ToString("D", CultureInfo.CreateSpecificCulture("pt-br")));
                break;

            case "0":
                Exit();
                break;

            default:
                Console.WriteLine("Opção invalida!");
                break;

        }
    }

    public static void Exit()
    {
        Console.WriteLine("Saindo....");
        Thread.Sleep(1000);
        Console.Clear();
    }
}
