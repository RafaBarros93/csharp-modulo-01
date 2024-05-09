using System.Drawing;

namespace HelloWorld;

public class Car
{
    public string Model { get; set; }
    public Color Color { get; set; }

    public DateOnly CreatedIn { get; set; }

    public Car(string model, Color color, DateOnly date)
    {
        Model = model;
        Color = color;
        CreatedIn = date;
    }

    public void ModelName()
    {
        Console.WriteLine($"Carro:{ModelName}");
        Console.WriteLine($"Cor:{Color}");
        Console.WriteLine($"Fabricação:{CreatedIn}");

    }
}

