namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of light years: ");
            double lightYears = double.Parse(Console.ReadLine());
            double astronomicalUnits = LightYearsToAstronomicalUnits(lightYears);
            Console.WriteLine($"{lightYears} light years = {astronomicalUnits} astronomical units");
        }
        static double LightYearsToAstronomicalUnits(double lightYears)
        {
            return lightYears * 63240;
        }
    }
}
