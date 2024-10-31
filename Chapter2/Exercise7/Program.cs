namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much liters of petrolium per 100km have used your car: ");
            double literPerKM = double.Parse(Console.ReadLine());
            double mpg = 62.14 / (literPerKM / 3.875);
            Console.WriteLine($"Your car have used {mpg} mpg");
        }
    }
}
