// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Give water level");

        int waterLevel = int.Parse(Console.ReadLine());

        if (waterLevel > 1000)
        {
            Console.WriteLine("Poziom wody jest za wysoki");
        }
        else if (waterLevel >= 800 && waterLevel <= 1000)
        {
            Console.WriteLine("Poziom wody jest ok");
        }
        else
        {
            Console.WriteLine("Poziom wody jest za niski1");
        }
        
        
        
        
    }
}