namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much kilometers you have driven: ");
            int kilometers = int.Parse(Console.ReadLine());
            Console.Write("How many petrol in liters you've used: ");
            int liters = int.Parse(Console.ReadLine());
            double litersPerKilometers = (double)liters / kilometers * 100;
            Console.WriteLine($"Your car has gotten {litersPerKilometers} liters per kilometer" );
        }
    }
}
