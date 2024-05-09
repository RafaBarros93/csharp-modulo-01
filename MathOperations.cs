
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld;

public class MathOperations




{

    public void OptionsMath()
    {
        Console.WriteLine("Escolha uma opção");
        Console.WriteLine("1-Soma");
        Console.WriteLine("2-Subtração");
        Console.WriteLine("3-Multiplicação");
        Console.WriteLine("4-Divisão");
        Console.WriteLine("0-Sair");
        Thread.Sleep(1000);
       
        Console.Write("\nOpção:");
        string options = Console.ReadLine()!;
    

        switch (options)
        {
            case "1" :
             Add();
             break;

            case "2":
             Sub();
             break;

            case "3":
                Mult();
                break;

            case "4":
                Divide();
                break;

            case "0":
               Exit();
                break;

            default:
                Console.WriteLine("Opção invalida!");
                break;

        }
    }

     public static void Add() 
     {

         Console.Write("Informe o primeiro valor:");
         double  num1 = double.Parse(Console.ReadLine()!);

         Console.Write("Informe o segudndo valor:");
         double  num2 = double.Parse(Console.ReadLine()!);
      
         Console.WriteLine($"Resultado:{num1 + num2}");
    }

    public static void Sub()
    {

        Console.Write("Informe o primeiro valor: ");
        double num1 = double.Parse(Console.ReadLine()!);

        Console.Write("Informe o segudndo valor: ");
        double num2 = double.Parse(Console.ReadLine()!);


        Console.WriteLine($"Resultado:{num1 - num2}");


    }

    public static void Mult()
    {

        Console.Write("Informe o primeiro valor: ");
        double num1 = double.Parse(Console.ReadLine()!);

        Console.Write("Informe o segudndo valor: ");
        double num2 = double.Parse(Console.ReadLine()!);


        Console.WriteLine($"Resultado:{num1 * num2}");


    }
    public static void Divide()
    {

        Console.Write("Informe o primeiro valor: ");
        double num1 = double.Parse(Console.ReadLine()!);

        Console.Write("Informe o segudndo valor: ");
        double num2 = double.Parse(Console.ReadLine()!);

        if(num2 == 0)
        {
            Console.WriteLine("Não e possivel dividir por zero");
           
        }
        else
        {
            Console.WriteLine($"Resultado:{num1 / num2}");
        } 

    }
   public static void Exit()
    {
        Console.WriteLine("Saindo....");
        Thread.Sleep(1000);
        Console.Clear();
    }
}

