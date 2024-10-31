namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the world's population: ");
            long worldPopulation = long.Parse(Console.ReadLine());
            Console.Write("Enter the population of the US: ");
            long usPopulation = long.Parse(Console.ReadLine());
            double percent = (double)usPopulation / worldPopulation;
            Console.WriteLine($"The population of the US is {percent*100}% of the world population.");
        }
    }
}
