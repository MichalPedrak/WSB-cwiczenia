// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            
            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Podaj ocenę");
                array[i] = int.Parse(Console.ReadLine());
            }

            float average = (float)(array.Average(x => x) * array.Length / array.Length);
            
            Console.WriteLine($"Średnia to {average}");
    
        }
    }
}