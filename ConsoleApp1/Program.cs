// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Podaj element z talicy");
            
            int element = int.Parse(Console.ReadLine());
        
            int[] array = { 5, 6, 7, 1, 2 };
        
            string isInArray = array.Contains(element) ? "Element zawiera sie w tablicy" : "Element nie nie nie ";

            Console.WriteLine(isInArray);   
        }
    }
}