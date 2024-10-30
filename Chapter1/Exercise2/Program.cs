namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Distance in furlongs: ");
            int furlongs = int.Parse(Console.ReadLine());
            Console.WriteLine($"Distance in yards is {furlongs * 220}");
        }
    }
}
